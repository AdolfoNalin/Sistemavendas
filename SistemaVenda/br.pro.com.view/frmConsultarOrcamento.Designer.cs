namespace SistemaVenda.br.pro.com.view
{
    partial class frmConsultarOrcamento
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
            this.lblDataInicio = new System.Windows.Forms.Label();
            this.lblDataFim = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.dtpDataFim = new System.Windows.Forms.DateTimePicker();
            this.dtpDataInicio = new System.Windows.Forms.DateTimePicker();
            this.dgHistoricoOrcamento = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgHistoricoOrcamento)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDataInicio
            // 
            this.lblDataInicio.AutoSize = true;
            this.lblDataInicio.Location = new System.Drawing.Point(6, 27);
            this.lblDataInicio.Name = "lblDataInicio";
            this.lblDataInicio.Size = new System.Drawing.Size(63, 13);
            this.lblDataInicio.TabIndex = 11;
            this.lblDataInicio.Text = "Data Início:";
            // 
            // lblDataFim
            // 
            this.lblDataFim.AutoSize = true;
            this.lblDataFim.Location = new System.Drawing.Point(17, 52);
            this.lblDataFim.Name = "lblDataFim";
            this.lblDataFim.Size = new System.Drawing.Size(52, 13);
            this.lblDataFim.TabIndex = 10;
            this.lblDataFim.Text = "Data Fim:";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(33, 84);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 9;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // dtpDataFim
            // 
            this.dtpDataFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFim.Location = new System.Drawing.Point(70, 49);
            this.dtpDataFim.Name = "dtpDataFim";
            this.dtpDataFim.Size = new System.Drawing.Size(96, 20);
            this.dtpDataFim.TabIndex = 8;
            // 
            // dtpDataInicio
            // 
            this.dtpDataInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInicio.Location = new System.Drawing.Point(70, 23);
            this.dtpDataInicio.Name = "dtpDataInicio";
            this.dtpDataInicio.Size = new System.Drawing.Size(96, 20);
            this.dtpDataInicio.TabIndex = 7;
            this.dtpDataInicio.Value = new System.DateTime(2023, 11, 5, 13, 50, 16, 0);
            // 
            // dgHistoricoOrcamento
            // 
            this.dgHistoricoOrcamento.AllowUserToAddRows = false;
            this.dgHistoricoOrcamento.AllowUserToDeleteRows = false;
            this.dgHistoricoOrcamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHistoricoOrcamento.Location = new System.Drawing.Point(191, 23);
            this.dgHistoricoOrcamento.Name = "dgHistoricoOrcamento";
            this.dgHistoricoOrcamento.ReadOnly = true;
            this.dgHistoricoOrcamento.Size = new System.Drawing.Size(571, 323);
            this.dgHistoricoOrcamento.TabIndex = 12;
            this.dgHistoricoOrcamento.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgHistoricoOrcamento_CellClick);
            // 
            // frmConsultarOrcamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 383);
            this.Controls.Add(this.dgHistoricoOrcamento);
            this.Controls.Add(this.lblDataInicio);
            this.Controls.Add(this.lblDataFim);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.dtpDataFim);
            this.Controls.Add(this.dtpDataInicio);
            this.Name = "frmConsultarOrcamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalhes Orçamento";
            this.Load += new System.EventHandler(this.frmDetalhesOrcamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgHistoricoOrcamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDataInicio;
        private System.Windows.Forms.Label lblDataFim;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DateTimePicker dtpDataFim;
        private System.Windows.Forms.DateTimePicker dtpDataInicio;
        public System.Windows.Forms.DataGridView dgHistoricoOrcamento;
    }
}