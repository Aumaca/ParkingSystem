using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEstacionamento
{
    public partial class Config : Form
    {
        private Action UpdateVagas;
        public Config(Action updateVagas)
        {
            InitializeComponent();
            UpdateVagas = updateVagas;
        }

        private void Config_Load(object sender, EventArgs e)
        {
            inputValorHora.Text = SharedData.ValorHora;
            inputNumVagas.Text = SharedData.NumeroVagas;
        }

        private void ConfigBtn_Click(object sender, EventArgs e)
        {
            if (Double.TryParse(inputValorHora.Text, out _) && int.TryParse(inputNumVagas.Text, out _))
            {
                SharedData.ValorHora = inputValorHora.Text;
                SharedData.NumeroVagas = inputNumVagas.Text;
            }
            UpdateVagas();
        }
    }
}
