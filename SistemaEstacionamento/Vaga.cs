using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEstacionamento
{
    public partial class Vaga : Form
    {
        private string NumeroVaga;
        private Action ShowCadastro;
        public Vaga(string numeroVaga, Action showCadastro)
        {
            InitializeComponent();
            DB.Transacao VagaInfo;
            ShowCadastro = showCadastro;
            int IntNumeroVaga = int.Parse(numeroVaga);
            using (var context = new DB())
            {
                VagaInfo = (from item in context.Transacoes
                            orderby item.DataEntrada descending
                            where item.NumVaga == IntNumeroVaga
                            select item).FirstOrDefault();
            }
            NumeroVaga = numeroVaga;
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
            SharedData.ActiveVaga = int.Parse(NumeroVaga);
            ShowCadastro();
        }
    }
}
