using System.Windows.Forms;
using System.Diagnostics;

namespace SistemaEstacionamento
{
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
        }

        private void LinkInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/Aumaca");
        }
    }
}
