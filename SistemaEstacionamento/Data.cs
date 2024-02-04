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
    public partial class Data : Form
    {
        public Data()
        {
            InitializeComponent();
        }

        private void Data_Load(object sender, EventArgs e)
        {
            transacoesTableAdapter.Fill(estacionamentoDataSet.Transacoes);
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                transacoesTableAdapter.FillBy(estacionamentoDataSet.Transacoes);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                transacoesTableAdapter.FillBy(estacionamentoDataSet.Transacoes);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                transacoesTableAdapter.FillBy1(estacionamentoDataSet.Transacoes);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
