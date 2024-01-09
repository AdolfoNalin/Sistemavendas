namespace SistemaVenda.br.pro.com.view
{
    partial class frmCadastrarProduto
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtDescricaoCompleta = new System.Windows.Forms.TextBox();
            this.mtbData = new System.Windows.Forms.MaskedTextBox();
            this.lblDescricaoCompleta = new System.Windows.Forms.Label();
            this.lblDescricaoResumida = new System.Windows.Forms.Label();
            this.txtDescricaoResumida = new System.Windows.Forms.TextBox();
            this.mtbHora = new System.Windows.Forms.MaskedTextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblPrecoAvista = new System.Windows.Forms.Label();
            this.txtPrecoVista = new System.Windows.Forms.MaskedTextBox();
            this.lblPrecoPrazo = new System.Windows.Forms.Label();
            this.txtPrecoPrazo = new System.Windows.Forms.MaskedTextBox();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.txtValorTotal = new System.Windows.Forms.MaskedTextBox();
            this.lblValorEntrada = new System.Windows.Forms.Label();
            this.txtValorEntrada = new System.Windows.Forms.MaskedTextBox();
            this.cbUniMedida = new System.Windows.Forms.ComboBox();
            this.lblUniMedida = new System.Windows.Forms.Label();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.cbFornecedor = new System.Windows.Forms.ComboBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.MaskedTextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(629, 309);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 109);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtDescricaoCompleta
            // 
            this.txtDescricaoCompleta.Location = new System.Drawing.Point(142, 89);
            this.txtDescricaoCompleta.Multiline = true;
            this.txtDescricaoCompleta.Name = "txtDescricaoCompleta";
            this.txtDescricaoCompleta.Size = new System.Drawing.Size(256, 42);
            this.txtDescricaoCompleta.TabIndex = 1;
            // 
            // mtbData
            // 
            this.mtbData.Location = new System.Drawing.Point(640, 89);
            this.mtbData.Mask = "00/00/0000";
            this.mtbData.Name = "mtbData";
            this.mtbData.Size = new System.Drawing.Size(64, 20);
            this.mtbData.TabIndex = 2;
            this.mtbData.ValidatingType = typeof(System.DateTime);
            // 
            // lblDescricaoCompleta
            // 
            this.lblDescricaoCompleta.AutoSize = true;
            this.lblDescricaoCompleta.Location = new System.Drawing.Point(40, 92);
            this.lblDescricaoCompleta.Name = "lblDescricaoCompleta";
            this.lblDescricaoCompleta.Size = new System.Drawing.Size(105, 13);
            this.lblDescricaoCompleta.TabIndex = 3;
            this.lblDescricaoCompleta.Text = "Descrição Completa:";
            // 
            // lblDescricaoResumida
            // 
            this.lblDescricaoResumida.AutoSize = true;
            this.lblDescricaoResumida.Location = new System.Drawing.Point(40, 157);
            this.lblDescricaoResumida.Name = "lblDescricaoResumida";
            this.lblDescricaoResumida.Size = new System.Drawing.Size(108, 13);
            this.lblDescricaoResumida.TabIndex = 5;
            this.lblDescricaoResumida.Text = "Descrição Resumida:";
            // 
            // txtDescricaoResumida
            // 
            this.txtDescricaoResumida.Location = new System.Drawing.Point(147, 154);
            this.txtDescricaoResumida.Name = "txtDescricaoResumida";
            this.txtDescricaoResumida.Size = new System.Drawing.Size(256, 20);
            this.txtDescricaoResumida.TabIndex = 4;
            // 
            // mtbHora
            // 
            this.mtbHora.Location = new System.Drawing.Point(640, 115);
            this.mtbHora.Name = "mtbHora";
            this.mtbHora.Size = new System.Drawing.Size(49, 20);
            this.mtbHora.TabIndex = 6;
            this.mtbHora.ValidatingType = typeof(System.DateTime);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(604, 92);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(33, 13);
            this.lblData.TabIndex = 7;
            this.lblData.Text = "Data:";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(608, 118);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(33, 13);
            this.lblHora.TabIndex = 8;
            this.lblHora.Text = "Hora:";
            // 
            // lblPrecoAvista
            // 
            this.lblPrecoAvista.AutoSize = true;
            this.lblPrecoAvista.Location = new System.Drawing.Point(70, 198);
            this.lblPrecoAvista.Name = "lblPrecoAvista";
            this.lblPrecoAvista.Size = new System.Drawing.Size(73, 13);
            this.lblPrecoAvista.TabIndex = 10;
            this.lblPrecoAvista.Text = "Preço á Vista:";
            // 
            // txtPrecoVista
            // 
            this.txtPrecoVista.Location = new System.Drawing.Point(142, 195);
            this.txtPrecoVista.Name = "txtPrecoVista";
            this.txtPrecoVista.Size = new System.Drawing.Size(64, 20);
            this.txtPrecoVista.TabIndex = 9;
            this.txtPrecoVista.ValidatingType = typeof(System.DateTime);
            // 
            // lblPrecoPrazo
            // 
            this.lblPrecoPrazo.AutoSize = true;
            this.lblPrecoPrazo.Location = new System.Drawing.Point(222, 198);
            this.lblPrecoPrazo.Name = "lblPrecoPrazo";
            this.lblPrecoPrazo.Size = new System.Drawing.Size(77, 13);
            this.lblPrecoPrazo.TabIndex = 12;
            this.lblPrecoPrazo.Text = "Preço á Prazo:";
            // 
            // txtPrecoPrazo
            // 
            this.txtPrecoPrazo.Location = new System.Drawing.Point(294, 195);
            this.txtPrecoPrazo.Name = "txtPrecoPrazo";
            this.txtPrecoPrazo.Size = new System.Drawing.Size(64, 20);
            this.txtPrecoPrazo.TabIndex = 11;
            this.txtPrecoPrazo.ValidatingType = typeof(System.DateTime);
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Location = new System.Drawing.Point(529, 198);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(61, 13);
            this.lblValorTotal.TabIndex = 16;
            this.lblValorTotal.Text = "Valor Total:";
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Location = new System.Drawing.Point(590, 195);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(64, 20);
            this.txtValorTotal.TabIndex = 15;
            this.txtValorTotal.ValidatingType = typeof(System.DateTime);
            // 
            // lblValorEntrada
            // 
            this.lblValorEntrada.AutoSize = true;
            this.lblValorEntrada.Location = new System.Drawing.Point(377, 198);
            this.lblValorEntrada.Name = "lblValorEntrada";
            this.lblValorEntrada.Size = new System.Drawing.Size(74, 13);
            this.lblValorEntrada.TabIndex = 14;
            this.lblValorEntrada.Text = "Valor Entrada:";
            // 
            // txtValorEntrada
            // 
            this.txtValorEntrada.Location = new System.Drawing.Point(449, 195);
            this.txtValorEntrada.Name = "txtValorEntrada";
            this.txtValorEntrada.Size = new System.Drawing.Size(64, 20);
            this.txtValorEntrada.TabIndex = 13;
            this.txtValorEntrada.ValidatingType = typeof(System.DateTime);
            // 
            // cbUniMedida
            // 
            this.cbUniMedida.FormattingEnabled = true;
            this.cbUniMedida.Items.AddRange(new object[] {
            "Metro Linear",
            "M²",
            "Unitário",
            "Peso "});
            this.cbUniMedida.Location = new System.Drawing.Point(533, 153);
            this.cbUniMedida.Name = "cbUniMedida";
            this.cbUniMedida.Size = new System.Drawing.Size(121, 21);
            this.cbUniMedida.TabIndex = 17;
            // 
            // lblUniMedida
            // 
            this.lblUniMedida.AutoSize = true;
            this.lblUniMedida.Location = new System.Drawing.Point(429, 156);
            this.lblUniMedida.Name = "lblUniMedida";
            this.lblUniMedida.Size = new System.Drawing.Size(103, 13);
            this.lblUniMedida.TabIndex = 18;
            this.lblUniMedida.Text = "Unidade de Medida:";
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Location = new System.Drawing.Point(422, 93);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(64, 13);
            this.lblFornecedor.TabIndex = 20;
            this.lblFornecedor.Text = "Fornecedor:";
            // 
            // cbFornecedor
            // 
            this.cbFornecedor.FormattingEnabled = true;
            this.cbFornecedor.Location = new System.Drawing.Point(488, 90);
            this.cbFornecedor.Name = "cbFornecedor";
            this.cbFornecedor.Size = new System.Drawing.Size(93, 21);
            this.cbFornecedor.TabIndex = 19;
            this.cbFornecedor.SelectedIndexChanged += new System.EventHandler(this.cbFornecedor_SelectedIndexChanged);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(118, 309);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(99, 40);
            this.btnSalvar.TabIndex = 21;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(223, 309);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(99, 40);
            this.btnEditar.TabIndex = 22;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(328, 309);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(99, 40);
            this.btnNovo.TabIndex = 23;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(433, 309);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(99, 40);
            this.btnExcluir.TabIndex = 24;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(427, 120);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(65, 13);
            this.lblQuantidade.TabIndex = 26;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(488, 117);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(64, 20);
            this.txtQuantidade.TabIndex = 25;
            this.txtQuantidade.ValidatingType = typeof(System.DateTime);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(103, 53);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 28;
            this.lblCodigo.Text = "Código:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(142, 50);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(64, 20);
            this.txtCodigo.TabIndex = 27;
            this.txtCodigo.ValidatingType = typeof(System.DateTime);
            // 
            // frmCadastrarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblFornecedor);
            this.Controls.Add(this.cbFornecedor);
            this.Controls.Add(this.lblUniMedida);
            this.Controls.Add(this.cbUniMedida);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.lblValorEntrada);
            this.Controls.Add(this.txtValorEntrada);
            this.Controls.Add(this.lblPrecoPrazo);
            this.Controls.Add(this.txtPrecoPrazo);
            this.Controls.Add(this.lblPrecoAvista);
            this.Controls.Add(this.txtPrecoVista);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.mtbHora);
            this.Controls.Add(this.lblDescricaoResumida);
            this.Controls.Add(this.txtDescricaoResumida);
            this.Controls.Add(this.lblDescricaoCompleta);
            this.Controls.Add(this.mtbData);
            this.Controls.Add(this.txtDescricaoCompleta);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmCadastrarProduto";
            this.Text = "frmCadastrarProduto";
            this.Load += new System.EventHandler(this.frmCadastrarProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDescricaoCompleta;
        private System.Windows.Forms.Label lblDescricaoResumida;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblPrecoAvista;
        private System.Windows.Forms.Label lblPrecoPrazo;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Label lblValorEntrada;
        private System.Windows.Forms.Label lblUniMedida;
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblCodigo;
        public System.Windows.Forms.MaskedTextBox txtCodigo;
        public System.Windows.Forms.TextBox txtDescricaoCompleta;
        public System.Windows.Forms.TextBox txtDescricaoResumida;
        public System.Windows.Forms.MaskedTextBox txtPrecoVista;
        public System.Windows.Forms.MaskedTextBox txtPrecoPrazo;
        public System.Windows.Forms.MaskedTextBox txtValorTotal;
        public System.Windows.Forms.MaskedTextBox txtValorEntrada;
        public System.Windows.Forms.ComboBox cbUniMedida;
        public System.Windows.Forms.ComboBox cbFornecedor;
        public System.Windows.Forms.MaskedTextBox txtQuantidade;
        public System.Windows.Forms.MaskedTextBox mtbData;
        public System.Windows.Forms.MaskedTextBox mtbHora;
    }
}