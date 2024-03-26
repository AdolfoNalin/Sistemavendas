namespace SistemaVenda.br.pro.com.view
{
    partial class frmDetalhesVenda
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
            this.gbDetalheVenda = new System.Windows.Forms.GroupBox();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.txtCodigoVenda = new System.Windows.Forms.TextBox();
            this.lblCodigoVenda = new System.Windows.Forms.Label();
            this.mtbData = new System.Windows.Forms.MaskedTextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dgVenda = new System.Windows.Forms.DataGridView();
            this.mtbHora = new System.Windows.Forms.MaskedTextBox();
            this.lblPagamento = new System.Windows.Forms.Label();
            this.gbDetalheVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVenda)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDetalheVenda
            // 
            this.gbDetalheVenda.Controls.Add(this.mtbHora);
            this.gbDetalheVenda.Controls.Add(this.lblPagamento);
            this.gbDetalheVenda.Controls.Add(this.txtValorTotal);
            this.gbDetalheVenda.Controls.Add(this.lblValorTotal);
            this.gbDetalheVenda.Controls.Add(this.txtObs);
            this.gbDetalheVenda.Controls.Add(this.lblObservacao);
            this.gbDetalheVenda.Controls.Add(this.txtCodigoVenda);
            this.gbDetalheVenda.Controls.Add(this.lblCodigoVenda);
            this.gbDetalheVenda.Controls.Add(this.mtbData);
            this.gbDetalheVenda.Controls.Add(this.lblData);
            this.gbDetalheVenda.Controls.Add(this.txtNome);
            this.gbDetalheVenda.Controls.Add(this.lblNome);
            this.gbDetalheVenda.Location = new System.Drawing.Point(14, 12);
            this.gbDetalheVenda.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbDetalheVenda.Name = "gbDetalheVenda";
            this.gbDetalheVenda.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbDetalheVenda.Size = new System.Drawing.Size(905, 104);
            this.gbDetalheVenda.TabIndex = 0;
            this.gbDetalheVenda.TabStop = false;
            this.gbDetalheVenda.Text = "Dados";
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Location = new System.Drawing.Point(614, 48);
            this.txtValorTotal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(70, 20);
            this.txtValorTotal.TabIndex = 11;
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal.Location = new System.Drawing.Point(540, 51);
            this.lblValorTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(73, 13);
            this.lblValorTotal.TabIndex = 10;
            this.lblValorTotal.Text = "Valor Total:";
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(111, 49);
            this.txtObs.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(405, 30);
            this.txtObs.TabIndex = 9;
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacao.Location = new System.Drawing.Point(13, 51);
            this.lblObservacao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(96, 13);
            this.lblObservacao.TabIndex = 8;
            this.lblObservacao.Text = "Oberservações:";
            // 
            // txtCodigoVenda
            // 
            this.txtCodigoVenda.Location = new System.Drawing.Point(811, 13);
            this.txtCodigoVenda.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCodigoVenda.Name = "txtCodigoVenda";
            this.txtCodigoVenda.Size = new System.Drawing.Size(52, 20);
            this.txtCodigoVenda.TabIndex = 7;
            // 
            // lblCodigoVenda
            // 
            this.lblCodigoVenda.AutoSize = true;
            this.lblCodigoVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoVenda.Location = new System.Drawing.Point(723, 16);
            this.lblCodigoVenda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoVenda.Name = "lblCodigoVenda";
            this.lblCodigoVenda.Size = new System.Drawing.Size(90, 13);
            this.lblCodigoVenda.TabIndex = 6;
            this.lblCodigoVenda.Text = "Código Venda:";
            // 
            // mtbData
            // 
            this.mtbData.Location = new System.Drawing.Point(510, 13);
            this.mtbData.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mtbData.Name = "mtbData";
            this.mtbData.Size = new System.Drawing.Size(136, 20);
            this.mtbData.TabIndex = 3;
            this.mtbData.ValidatingType = typeof(System.DateTime);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(470, 16);
            this.lblData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(38, 13);
            this.lblData.TabIndex = 2;
            this.lblData.Text = "Data:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(86, 13);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(362, 20);
            this.txtNome.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(40, 16);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(43, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // dgVenda
            // 
            this.dgVenda.AllowUserToAddRows = false;
            this.dgVenda.AllowUserToDeleteRows = false;
            this.dgVenda.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVenda.Location = new System.Drawing.Point(14, 133);
            this.dgVenda.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgVenda.Name = "dgVenda";
            this.dgVenda.ReadOnly = true;
            this.dgVenda.Size = new System.Drawing.Size(905, 232);
            this.dgVenda.TabIndex = 1;
            // 
            // mtbHora
            // 
            this.mtbHora.Location = new System.Drawing.Point(783, 63);
            this.mtbHora.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mtbHora.Name = "mtbHora";
            this.mtbHora.Size = new System.Drawing.Size(75, 20);
            this.mtbHora.TabIndex = 13;
            this.mtbHora.ValidatingType = typeof(System.DateTime);
            // 
            // lblPagamento
            // 
            this.lblPagamento.AutoSize = true;
            this.lblPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagamento.Location = new System.Drawing.Point(727, 47);
            this.lblPagamento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPagamento.Name = "lblPagamento";
            this.lblPagamento.Size = new System.Drawing.Size(131, 13);
            this.lblPagamento.TabIndex = 12;
            this.lblPagamento.Text = "Forma De pagamento:";
            // 
            // frmDetalhesVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.dgVenda);
            this.Controls.Add(this.gbDetalheVenda);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmDetalhesVenda";
            this.Text = "Detalhes das Vendas";
            this.Load += new System.EventHandler(this.frmDetalhesVenda_Load);
            this.gbDetalheVenda.ResumeLayout(false);
            this.gbDetalheVenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVenda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDetalheVenda;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.Label lblCodigoVenda;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblValorTotal;
        public System.Windows.Forms.DataGridView dgVenda;
        public System.Windows.Forms.TextBox txtNome;
        public System.Windows.Forms.TextBox txtObs;
        public System.Windows.Forms.TextBox txtCodigoVenda;
        public System.Windows.Forms.MaskedTextBox mtbData;
        public System.Windows.Forms.TextBox txtValorTotal;
        public System.Windows.Forms.MaskedTextBox mtbHora;
        private System.Windows.Forms.Label lblPagamento;
    }
}