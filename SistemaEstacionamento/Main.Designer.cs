namespace SistemaEstacionamento
{
    partial class Main
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.NavPanel = new System.Windows.Forms.Panel();
            this.CadastroCarroIcon = new System.Windows.Forms.PictureBox();
            this.ConfigIcon = new System.Windows.Forms.PictureBox();
            this.InfoIcon = new System.Windows.Forms.PictureBox();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.vagasPanel = new System.Windows.Forms.Panel();
            this.NavPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CadastroCarroIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConfigIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfoIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // NavPanel
            // 
            this.NavPanel.BackColor = System.Drawing.Color.Gray;
            this.NavPanel.Controls.Add(this.CadastroCarroIcon);
            this.NavPanel.Controls.Add(this.ConfigIcon);
            this.NavPanel.Controls.Add(this.InfoIcon);
            this.NavPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.NavPanel.Location = new System.Drawing.Point(0, 0);
            this.NavPanel.Name = "NavPanel";
            this.NavPanel.Size = new System.Drawing.Size(150, 1041);
            this.NavPanel.TabIndex = 0;
            // 
            // CadastroCarroIcon
            // 
            this.CadastroCarroIcon.Image = ((System.Drawing.Image)(resources.GetObject("CadastroCarroIcon.Image")));
            this.CadastroCarroIcon.Location = new System.Drawing.Point(0, 0);
            this.CadastroCarroIcon.Name = "CadastroCarroIcon";
            this.CadastroCarroIcon.Size = new System.Drawing.Size(150, 104);
            this.CadastroCarroIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CadastroCarroIcon.TabIndex = 2;
            this.CadastroCarroIcon.TabStop = false;
            this.CadastroCarroIcon.Click += new System.EventHandler(this.CadastroCarroIcon_Click);
            // 
            // ConfigIcon
            // 
            this.ConfigIcon.Image = ((System.Drawing.Image)(resources.GetObject("ConfigIcon.Image")));
            this.ConfigIcon.Location = new System.Drawing.Point(0, 827);
            this.ConfigIcon.Name = "ConfigIcon";
            this.ConfigIcon.Size = new System.Drawing.Size(150, 104);
            this.ConfigIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ConfigIcon.TabIndex = 1;
            this.ConfigIcon.TabStop = false;
            this.ConfigIcon.Click += new System.EventHandler(this.ConfigIcon_Click);
            // 
            // InfoIcon
            // 
            this.InfoIcon.Image = ((System.Drawing.Image)(resources.GetObject("InfoIcon.Image")));
            this.InfoIcon.Location = new System.Drawing.Point(0, 937);
            this.InfoIcon.Name = "InfoIcon";
            this.InfoIcon.Size = new System.Drawing.Size(150, 104);
            this.InfoIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.InfoIcon.TabIndex = 0;
            this.InfoIcon.TabStop = false;
            this.InfoIcon.Click += new System.EventHandler(this.InfoIcon_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MainPanel.Location = new System.Drawing.Point(150, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(877, 1041);
            this.MainPanel.TabIndex = 1;
            // 
            // vagasPanel
            // 
            this.vagasPanel.BackColor = System.Drawing.Color.Black;
            this.vagasPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vagasPanel.Location = new System.Drawing.Point(1027, 0);
            this.vagasPanel.Name = "vagasPanel";
            this.vagasPanel.Size = new System.Drawing.Size(877, 1041);
            this.vagasPanel.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.vagasPanel);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.NavPanel);
            this.Name = "Main";
            this.Text = "Form1";
            this.NavPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CadastroCarroIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConfigIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfoIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel NavPanel;
        private System.Windows.Forms.PictureBox InfoIcon;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.PictureBox ConfigIcon;
        private System.Windows.Forms.PictureBox CadastroCarroIcon;
        private System.Windows.Forms.Panel vagasPanel;
    }
}

