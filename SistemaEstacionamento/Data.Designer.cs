namespace SistemaEstacionamento
{
    partial class Data
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fabricanteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numVagaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metodoPagamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataEntradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSaidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transacoesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.estacionamentoDataSet = new SistemaEstacionamento.estacionamentoDataSet();
            this.transacoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transacoesTableAdapter = new SistemaEstacionamento.estacionamentoDataSetTableAdapters.TransacoesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transacoesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estacionamentoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transacoesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.placaDataGridViewTextBoxColumn,
            this.fabricanteDataGridViewTextBoxColumn,
            this.numVagaDataGridViewTextBoxColumn,
            this.metodoPagamentoDataGridViewTextBoxColumn,
            this.dataEntradaDataGridViewTextBoxColumn,
            this.dataSaidaDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.transacoesBindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(861, 1002);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // placaDataGridViewTextBoxColumn
            // 
            this.placaDataGridViewTextBoxColumn.DataPropertyName = "Placa";
            this.placaDataGridViewTextBoxColumn.HeaderText = "Placa";
            this.placaDataGridViewTextBoxColumn.Name = "placaDataGridViewTextBoxColumn";
            this.placaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fabricanteDataGridViewTextBoxColumn
            // 
            this.fabricanteDataGridViewTextBoxColumn.DataPropertyName = "Fabricante";
            this.fabricanteDataGridViewTextBoxColumn.HeaderText = "Fabricante";
            this.fabricanteDataGridViewTextBoxColumn.Name = "fabricanteDataGridViewTextBoxColumn";
            this.fabricanteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numVagaDataGridViewTextBoxColumn
            // 
            this.numVagaDataGridViewTextBoxColumn.DataPropertyName = "NumVaga";
            this.numVagaDataGridViewTextBoxColumn.HeaderText = "NumVaga";
            this.numVagaDataGridViewTextBoxColumn.Name = "numVagaDataGridViewTextBoxColumn";
            this.numVagaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // metodoPagamentoDataGridViewTextBoxColumn
            // 
            this.metodoPagamentoDataGridViewTextBoxColumn.DataPropertyName = "MetodoPagamento";
            this.metodoPagamentoDataGridViewTextBoxColumn.HeaderText = "MetodoPagamento";
            this.metodoPagamentoDataGridViewTextBoxColumn.Name = "metodoPagamentoDataGridViewTextBoxColumn";
            this.metodoPagamentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataEntradaDataGridViewTextBoxColumn
            // 
            this.dataEntradaDataGridViewTextBoxColumn.DataPropertyName = "DataEntrada";
            this.dataEntradaDataGridViewTextBoxColumn.HeaderText = "DataEntrada";
            this.dataEntradaDataGridViewTextBoxColumn.Name = "dataEntradaDataGridViewTextBoxColumn";
            this.dataEntradaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataSaidaDataGridViewTextBoxColumn
            // 
            this.dataSaidaDataGridViewTextBoxColumn.DataPropertyName = "DataSaida";
            this.dataSaidaDataGridViewTextBoxColumn.HeaderText = "DataSaida";
            this.dataSaidaDataGridViewTextBoxColumn.Name = "dataSaidaDataGridViewTextBoxColumn";
            this.dataSaidaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "Valor";
            this.valorDataGridViewTextBoxColumn.HeaderText = "Valor";
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            this.valorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // transacoesBindingSource1
            // 
            this.transacoesBindingSource1.DataMember = "Transacoes";
            this.transacoesBindingSource1.DataSource = this.estacionamentoDataSet;
            // 
            // estacionamentoDataSet
            // 
            this.estacionamentoDataSet.DataSetName = "estacionamentoDataSet";
            this.estacionamentoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transacoesBindingSource
            // 
            this.transacoesBindingSource.DataMember = "Transacoes";
            this.transacoesBindingSource.DataSource = this.estacionamentoDataSet;
            // 
            // transacoesTableAdapter
            // 
            this.transacoesTableAdapter.ClearBeforeFill = true;
            // 
            // Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 1002);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Data";
            this.Text = "Data";
            this.Load += new System.EventHandler(this.Data_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transacoesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estacionamentoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transacoesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private estacionamentoDataSet estacionamentoDataSet;
        private System.Windows.Forms.BindingSource transacoesBindingSource;
        private estacionamentoDataSetTableAdapters.TransacoesTableAdapter transacoesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fabricanteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numVagaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn metodoPagamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataEntradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataSaidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource transacoesBindingSource1;
    }
}