namespace SistemaVenda.br.pro.com.view
{
    partial class frmPayment
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
            this.lblDinheiro = new System.Windows.Forms.Label();
            this.lblCartao = new System.Windows.Forms.Label();
            this.lblPix = new System.Windows.Forms.Label();
            this.lblCrediario = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.mtbCash = new System.Windows.Forms.MaskedTextBox();
            this.mtbPix = new System.Windows.Forms.MaskedTextBox();
            this.mtbCredit = new System.Windows.Forms.MaskedTextBox();
            this.txtTotal = new System.Windows.Forms.MaskedTextBox();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.btnFinish = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtChange = new System.Windows.Forms.MaskedTextBox();
            this.lblTroco = new System.Windows.Forms.Label();
            this.mtbCard = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblDinheiro
            // 
            this.lblDinheiro.AutoSize = true;
            this.lblDinheiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDinheiro.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblDinheiro.Location = new System.Drawing.Point(32, 98);
            this.lblDinheiro.Name = "lblDinheiro";
            this.lblDinheiro.Size = new System.Drawing.Size(58, 13);
            this.lblDinheiro.TabIndex = 0;
            this.lblDinheiro.Text = "Dinheiro:";
            // 
            // lblCartao
            // 
            this.lblCartao.AutoSize = true;
            this.lblCartao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCartao.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblCartao.Location = new System.Drawing.Point(40, 128);
            this.lblCartao.Name = "lblCartao";
            this.lblCartao.Size = new System.Drawing.Size(48, 13);
            this.lblCartao.TabIndex = 1;
            this.lblCartao.Text = "Cartão:";
            // 
            // lblPix
            // 
            this.lblPix.AutoSize = true;
            this.lblPix.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPix.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblPix.Location = new System.Drawing.Point(57, 155);
            this.lblPix.Name = "lblPix";
            this.lblPix.Size = new System.Drawing.Size(28, 13);
            this.lblPix.TabIndex = 2;
            this.lblPix.Text = "Pix:";
            // 
            // lblCrediario
            // 
            this.lblCrediario.AutoSize = true;
            this.lblCrediario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrediario.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblCrediario.Location = new System.Drawing.Point(32, 178);
            this.lblCrediario.Name = "lblCrediario";
            this.lblCrediario.Size = new System.Drawing.Size(61, 13);
            this.lblCrediario.TabIndex = 3;
            this.lblCrediario.Text = "Crediário:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTotal.Location = new System.Drawing.Point(47, 274);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(40, 13);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total:";
            // 
            // mtbCash
            // 
            this.mtbCash.Location = new System.Drawing.Point(88, 95);
            this.mtbCash.Name = "mtbCash";
            this.mtbCash.Size = new System.Drawing.Size(100, 20);
            this.mtbCash.TabIndex = 7;
            this.mtbCash.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbDinheiro_KeyPress);
            // 
            // mtbPix
            // 
            this.mtbPix.Location = new System.Drawing.Point(88, 152);
            this.mtbPix.Name = "mtbPix";
            this.mtbPix.Size = new System.Drawing.Size(100, 20);
            this.mtbPix.TabIndex = 8;
            this.mtbPix.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbPix_KeyPress);
            // 
            // mtbCredit
            // 
            this.mtbCredit.Location = new System.Drawing.Point(88, 178);
            this.mtbCredit.Name = "mtbCredit";
            this.mtbCredit.Size = new System.Drawing.Size(100, 20);
            this.mtbCredit.TabIndex = 9;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(88, 267);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 10;
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(313, 88);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(439, 288);
            this.txtObs.TabIndex = 12;
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacao.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblObservacao.Location = new System.Drawing.Point(310, 72);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(79, 13);
            this.lblObservacao.TabIndex = 13;
            this.lblObservacao.Text = "Observação:";
            // 
            // btnFinish
            // 
            this.btnFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinish.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnFinish.Location = new System.Drawing.Point(511, 396);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(98, 42);
            this.btnFinish.TabIndex = 14;
            this.btnFinish.Text = "Finalizar";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnCancel.Location = new System.Drawing.Point(213, 396);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(98, 42);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtChange
            // 
            this.txtChange.Location = new System.Drawing.Point(88, 241);
            this.txtChange.Name = "txtChange";
            this.txtChange.Size = new System.Drawing.Size(100, 20);
            this.txtChange.TabIndex = 17;
            // 
            // lblTroco
            // 
            this.lblTroco.AutoSize = true;
            this.lblTroco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTroco.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTroco.Location = new System.Drawing.Point(42, 244);
            this.lblTroco.Name = "lblTroco";
            this.lblTroco.Size = new System.Drawing.Size(44, 13);
            this.lblTroco.TabIndex = 16;
            this.lblTroco.Text = "Troco:";
            // 
            // mtbCard
            // 
            this.mtbCard.Location = new System.Drawing.Point(88, 125);
            this.mtbCard.Name = "mtbCard";
            this.mtbCard.Size = new System.Drawing.Size(100, 20);
            this.mtbCard.TabIndex = 18;
            // 
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mtbCard);
            this.Controls.Add(this.txtChange);
            this.Controls.Add(this.lblTroco);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.lblObservacao);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.mtbCredit);
            this.Controls.Add(this.mtbPix);
            this.Controls.Add(this.mtbCash);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblCrediario);
            this.Controls.Add(this.lblPix);
            this.Controls.Add(this.lblCartao);
            this.Controls.Add(this.lblDinheiro);
            this.Name = "frmPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagamento";
            this.Load += new System.EventHandler(this.frmPagamento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDinheiro;
        private System.Windows.Forms.Label lblCartao;
        private System.Windows.Forms.Label lblPix;
        private System.Windows.Forms.Label lblCrediario;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.MaskedTextBox mtbCash;
        private System.Windows.Forms.MaskedTextBox mtbPix;
        private System.Windows.Forms.MaskedTextBox mtbCredit;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.MaskedTextBox txtTotal;
        public System.Windows.Forms.MaskedTextBox txtChange;
        private System.Windows.Forms.Label lblTroco;
        private System.Windows.Forms.MaskedTextBox mtbCard;
    }
}