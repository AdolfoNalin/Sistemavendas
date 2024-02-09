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
            ((System.ComponentModel.ISupportInitialize)(this.dgHistoricoOrcamento)).BeginInit();
            this.SuspendLayout();
            // 
            // dgHistoricoOrcamento
            // 
            this.dgHistoricoOrcamento.AllowUserToAddRows = false;
            this.dgHistoricoOrcamento.AllowUserToDeleteRows = false;
            this.dgHistoricoOrcamento.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgHistoricoOrcamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHistoricoOrcamento.Location = new System.Drawing.Point(25, 30);
            this.dgHistoricoOrcamento.Name = "dgHistoricoOrcamento";
            this.dgHistoricoOrcamento.ReadOnly = true;
            this.dgHistoricoOrcamento.Size = new System.Drawing.Size(750, 322);
            this.dgHistoricoOrcamento.TabIndex = 12;
            this.dgHistoricoOrcamento.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgHistoricoOrcamento_CellClick);
            // 
            // frmConsultarOrcamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 383);
            this.Controls.Add(this.dgHistoricoOrcamento);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Name = "frmConsultarOrcamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalhes Orçamento";
            this.Load += new System.EventHandler(this.frmDetalhesOrcamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgHistoricoOrcamento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DataGridView dgHistoricoOrcamento;
    }
}