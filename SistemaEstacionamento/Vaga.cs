using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SistemaEstacionamento.DB;

namespace SistemaEstacionamento
{
    public partial class Vaga : Form
    {
        private readonly Action ShowCadastro;
        readonly DB.Transacao VagaInfo;
        readonly int NumeroVaga;
        public Vaga(string numeroVaga, Action showCadastro)
        {
            InitializeComponent();
            ShowCadastro = showCadastro;
            NumeroVaga = int.Parse(numeroVaga);
            using (var context = new DB())
            {
                VagaInfo = (
                    from item in context.Transacoes
                    orderby item.DataEntrada descending
                    where item.NumVaga == NumeroVaga && item.Valor == null
                    select item
                ).FirstOrDefault();
            }
            labelVaga.Text = "Vaga " + numeroVaga;
            if (VagaInfo != null)
            {
                txtPlaca.Text = VagaInfo.Placa;
                txtEntrada.Text = VagaInfo.DataEntrada.ToString();
                labelStatus.Text = "OCUPADO";
                labelStatus.ForeColor = Color.Red;
            }   
            else
            {
                labelStatus.Text = "LIVRE";
                labelStatus.ForeColor = Color.Green;
            }
        }

        private void Vaga_Click(object sender, EventArgs e)
        {
            if (VagaInfo != null)
            {
                SharedData.ActiveVaga = VagaInfo;
            }
            else
            {
                SharedData.ActiveVaga = new Transacao
                {
                    NumVaga = NumeroVaga,
                };
            }
            ShowCadastro();
        }
    }
}
