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
            this.dgHistoricoOrcamento = new System.Windows.Forms.DataGridView();
            this.dtpFim = new System.Windows.Forms.DateTimePicker();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.lblDataInicio = new System.Windows.Forms.Label();
            this.lblDataFim = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgHistoricoOrcamento)).BeginInit();
            this.SuspendLayout();
            // 
            // dgHistoricoOrcamento
            // 
            this.dgHistoricoOrcamento.AllowUserToAddRows = false;
            this.dgHistoricoOrcamento.AllowUserToDeleteRows = false;
            this.dgHistoricoOrcamento.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgHistoricoOrcamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHistoricoOrcamento.Location = new System.Drawing.Point(254, 30);
            this.dgHistoricoOrcamento.Name = "dgHistoricoOrcamento";
            this.dgHistoricoOrcamento.ReadOnly = true;
            this.dgHistoricoOrcamento.Size = new System.Drawing.Size(521, 322);
            this.dgHistoricoOrcamento.TabIndex = 12;
            this.dgHistoricoOrcamento.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgHistoricoOrcamento_CellClick);
            // 
            // dtpFim
            // 
            this.dtpFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFim.Location = new System.Drawing.Point(113, 56);
            this.dtpFim.Name = "dtpFim";
            this.dtpFim.Size = new System.Drawing.Size(97, 20);
            this.dtpFim.TabIndex = 13;
            // 
            // dtpInicio
            // 
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(113, 30);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(97, 20);
            this.dtpInicio.TabIndex = 14;
            // 
            // lblDataInicio
            // 
            this.lblDataInicio.AutoSize = true;
            this.lblDataInicio.Location = new System.Drawing.Point(49, 33);
            this.lblDataInicio.Name = "lblDataInicio";
            this.lblDataInicio.Size = new System.Drawing.Size(61, 13);
            this.lblDataInicio.TabIndex = 15;
            this.lblDataInicio.Text = "Data Inicio:";
            // 
            // lblDataFim
            // 
            this.lblDataFim.AutoSize = true;
            this.lblDataFim.Location = new System.Drawing.Point(58, 59);
            this.lblDataFim.Name = "lblDataFim";
            this.lblDataFim.Size = new System.Drawing.Size(52, 13);
            this.lblDataFim.TabIndex = 16;
            this.lblDataFim.Text = "Data Fim:";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(88, 91);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(87, 30);
            this.btnPesquisar.TabIndex = 17;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // frmConsultarOrcamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 383);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.lblDataFim);
            this.Controls.Add(this.lblDataInicio);
            this.Controls.Add(this.dtpInicio);
            this.Controls.Add(this.dtpFim);
            this.Controls.Add(this.dgHistoricoOrcamento);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Name = "frmConsultarOrcamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalhes Orçamento";
            this.Load += new System.EventHandler(this.frmDetalhesOrcamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgHistoricoOrcamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DataGridView dgHistoricoOrcamento;
        private System.Windows.Forms.DateTimePicker dtpFim;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Label lblDataInicio;
        private System.Windows.Forms.Label lblDataFim;
        private System.Windows.Forms.Button btnPesquisar;
    }
}