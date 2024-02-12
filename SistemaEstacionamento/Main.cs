using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEstacionamento
{
    public partial class Main : Form
    {
        
        public List<Vaga> Vagas = new List<Vaga>();

        public Main()
        {
            InitializeComponent();
            ShowFormInVagasPanel();
        }

        public void UpdateVaga()
        {
            ShowFormInVagasPanel();
        }

        private void ShowFormInMainPanel(Type formType)
        {
            Form form = (Form)Activator.CreateInstance(formType);

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            MainPanel.Controls.Add(form);
            form.BringToFront();
            form.Show();
        }

        private void ShowFormInVagasPanel()
        {

            Vagas form = new Vagas(ShowCadastro)
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            vagasPanel.Controls.Add(form);
            form.BringToFront();
            form.Show();
        }

        private void InfoIcon_Click(object sender, EventArgs e)
        {
            ShowFormInMainPanel(typeof(Info));
        }

        private void ConfigIcon_Click(object sender, EventArgs e)
        {
            Config form = new Config(ShowFormInVagasPanel)
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            MainPanel.Controls.Add(form);
            form.BringToFront();
            form.Show();
        }

        private void CadastroCarroIcon_Click(object sender, EventArgs e)
        {
            CadastroCarro form = new CadastroCarro(UpdateVaga)
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            MainPanel.Controls.Add(form);
            form.BringToFront();
            form.Show();
        }

        private void ShowCadastro()
        {
            CadastroCarro form = new CadastroCarro(UpdateVaga)
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            MainPanel.Controls.Add(form);
            form.BringToFront();
            form.Show();
        }

        private void dataIcon_Click(object sender, EventArgs e)
        {
            ShowFormInMainPanel(typeof(Data));
        }
    }
}
