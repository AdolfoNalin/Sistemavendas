namespace SistemaVenda.br.pro.com.view
{
    partial class frmPagamento
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
            this.mtbDinheiro = new System.Windows.Forms.MaskedTextBox();
            this.mtbPix = new System.Windows.Forms.MaskedTextBox();
            this.mtbCrediario = new System.Windows.Forms.MaskedTextBox();
            this.mtbTotal = new System.Windows.Forms.MaskedTextBox();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtTroco = new System.Windows.Forms.MaskedTextBox();
            this.lblTroco = new System.Windows.Forms.Label();
            this.mtbCartao = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblDinheiro
            // 
            this.lblDinheiro.AutoSize = true;
            this.lblDinheiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.lblTotal.Location = new System.Drawing.Point(47, 274);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(40, 13);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total:";
            // 
            // mtbDinheiro
            // 
            this.mtbDinheiro.Location = new System.Drawing.Point(88, 95);
            this.mtbDinheiro.Name = "mtbDinheiro";
            this.mtbDinheiro.Size = new System.Drawing.Size(100, 20);
            this.mtbDinheiro.TabIndex = 7;
            this.mtbDinheiro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbDinheiro_KeyPress);
            // 
            // mtbPix
            // 
            this.mtbPix.Location = new System.Drawing.Point(88, 152);
            this.mtbPix.Name = "mtbPix";
            this.mtbPix.Size = new System.Drawing.Size(100, 20);
            this.mtbPix.TabIndex = 8;
            this.mtbPix.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbPix_KeyPress);
            // 
            // mtbCrediario
            // 
            this.mtbCrediario.Location = new System.Drawing.Point(88, 178);
            this.mtbCrediario.Name = "mtbCrediario";
            this.mtbCrediario.Size = new System.Drawing.Size(100, 20);
            this.mtbCrediario.TabIndex = 9;
            // 
            // mtbTotal
            // 
            this.mtbTotal.Location = new System.Drawing.Point(88, 267);
            this.mtbTotal.Name = "mtbTotal";
            this.mtbTotal.Size = new System.Drawing.Size(100, 20);
            this.mtbTotal.TabIndex = 10;
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
            this.lblObservacao.Location = new System.Drawing.Point(310, 72);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(79, 13);
            this.lblObservacao.TabIndex = 13;
            this.lblObservacao.Text = "Observação:";
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnFinalizar.Location = new System.Drawing.Point(511, 396);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(98, 42);
            this.btnFinalizar.TabIndex = 14;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnCancelar.Location = new System.Drawing.Point(213, 396);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(98, 42);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtTroco
            // 
            this.txtTroco.Location = new System.Drawing.Point(88, 241);
            this.txtTroco.Name = "txtTroco";
            this.txtTroco.Size = new System.Drawing.Size(100, 20);
            this.txtTroco.TabIndex = 17;
            // 
            // lblTroco
            // 
            this.lblTroco.AutoSize = true;
            this.lblTroco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTroco.Location = new System.Drawing.Point(42, 244);
            this.lblTroco.Name = "lblTroco";
            this.lblTroco.Size = new System.Drawing.Size(44, 13);
            this.lblTroco.TabIndex = 16;
            this.lblTroco.Text = "Troco:";
            // 
            // mtbCartao
            // 
            this.mtbCartao.Location = new System.Drawing.Point(88, 125);
            this.mtbCartao.Name = "mtbCartao";
            this.mtbCartao.Size = new System.Drawing.Size(100, 20);
            this.mtbCartao.TabIndex = 18;
            // 
            // frmPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mtbCartao);
            this.Controls.Add(this.txtTroco);
            this.Controls.Add(this.lblTroco);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.lblObservacao);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(this.mtbTotal);
            this.Controls.Add(this.mtbCrediario);
            this.Controls.Add(this.mtbPix);
            this.Controls.Add(this.mtbDinheiro);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblCrediario);
            this.Controls.Add(this.lblPix);
            this.Controls.Add(this.lblCartao);
            this.Controls.Add(this.lblDinheiro);
            this.Name = "frmPagamento";
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
        private System.Windows.Forms.MaskedTextBox mtbDinheiro;
        private System.Windows.Forms.MaskedTextBox mtbPix;
        private System.Windows.Forms.MaskedTextBox mtbCrediario;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.MaskedTextBox mtbTotal;
        public System.Windows.Forms.MaskedTextBox txtTroco;
        private System.Windows.Forms.Label lblTroco;
        private System.Windows.Forms.MaskedTextBox mtbCartao;
    }
}