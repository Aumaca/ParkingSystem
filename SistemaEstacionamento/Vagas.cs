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
    public partial class Vagas : Form
    {
        public Action ShowCadastro;
        public Vagas(Action showCadastro)
        {
            InitializeComponent();
            ShowCadastro = showCadastro;
            SetPanelsToTableLayout();
        }

        public void SetPanelsToTableLayout()
        {
            int NumVagas = int.Parse(SharedData.NumeroVagas);
            int gridSize = 0;

            for (int i = 1; i < NumVagas; i++)
            {
                if (i * i >= NumVagas)
                {
                    gridSize = i;
                    break;
                }
            }

            TablePanel.RowCount = gridSize;
            TablePanel.ColumnCount = gridSize;
            TablePanel.RowStyles.Clear();
            TablePanel.ColumnStyles.Clear();

            int counter = 1;
            for (int i = 0; i < gridSize; i++)
            {
                for (int j = 0; j < gridSize; j++)
                {
                    if (counter <= NumVagas)
                    {
                        Vaga vagaDesign = new Vaga(counter.ToString(), ShowCadastro)
                        {
                            TopLevel = false,
                            FormBorderStyle = FormBorderStyle.None,
                            Dock = DockStyle.Fill
                        };
                        TablePanel.Controls.Add(vagaDesign, j, i);
                        vagaDesign.BringToFront();
                        vagaDesign.Show();
                        counter++;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
    }
}
