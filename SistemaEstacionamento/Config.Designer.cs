namespace SistemaEstacionamento
{
    partial class Config
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.inputValorHora = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ConfigBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.inputNumVagas = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(244, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "Configuração";
            // 
            // inputValorHora
            // 
            this.inputValorHora.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputValorHora.Location = new System.Drawing.Point(425, 172);
            this.inputValorHora.Name = "inputValorHora";
            this.inputValorHora.Size = new System.Drawing.Size(158, 43);
            this.inputValorHora.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(228, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor Hora: ";
            // 
            // ConfigBtn
            // 
            this.ConfigBtn.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfigBtn.Location = new System.Drawing.Point(336, 342);
            this.ConfigBtn.Name = "ConfigBtn";
            this.ConfigBtn.Size = new System.Drawing.Size(143, 40);
            this.ConfigBtn.TabIndex = 3;
            this.ConfigBtn.Text = "ALTERAR";
            this.ConfigBtn.UseVisualStyleBackColor = true;
            this.ConfigBtn.Click += new System.EventHandler(this.ConfigBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(125, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(294, 35);
            this.label3.TabIndex = 5;
            this.label3.Text = "Número de Vagas: ";
            // 
            // inputNumVagas
            // 
            this.inputNumVagas.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputNumVagas.Location = new System.Drawing.Point(425, 235);
            this.inputNumVagas.Name = "inputNumVagas";
            this.inputNumVagas.Size = new System.Drawing.Size(158, 43);
            this.inputNumVagas.TabIndex = 4;
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 1002);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputNumVagas);
            this.Controls.Add(this.ConfigBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputValorHora);
            this.Controls.Add(this.label1);
            this.Name = "Config";
            this.Text = "Configuração";
            this.Load += new System.EventHandler(this.Config_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputValorHora;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ConfigBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputNumVagas;
    }
}