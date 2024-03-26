namespace SistemaVenda.br.pro.com.veiw
{
    partial class frmVenda
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
            this.dgCarrinho = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnPagar = new System.Windows.Forms.Button();
            this.gbConsumidor = new System.Windows.Forms.GroupBox();
            this.mtbFone = new System.Windows.Forms.MaskedTextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnPesquisarCliente = new System.Windows.Forms.Button();
            this.btnPesquisarNome = new System.Windows.Forms.Button();
            this.lblFone = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNomeCon = new System.Windows.Forms.Label();
            this.mtbCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.gbProduto = new System.Windows.Forms.GroupBox();
            this.txtPrecoVista = new System.Windows.Forms.TextBox();
            this.lblPrecoVista = new System.Windows.Forms.Label();
            this.txtPrecoPrazo = new System.Windows.Forms.TextBox();
            this.lblPrecoPrazo = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtDescricaoResumida = new System.Windows.Forms.TextBox();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.txtCodigoProduto = new System.Windows.Forms.TextBox();
            this.btnPesquisarProduto = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.lblEstoque = new System.Windows.Forms.Label();
            this.btnRemover = new System.Windows.Forms.Button();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblDescriçãoResumida = new System.Windows.Forms.Label();
            this.lblCodigoProduto = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.mtbHora = new System.Windows.Forms.MaskedTextBox();
            this.mtbData = new System.Windows.Forms.MaskedTextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.mtbTotal = new System.Windows.Forms.MaskedTextBox();
            this.mtbDescontoReal = new System.Windows.Forms.MaskedTextBox();
            this.lblDescontoReal = new System.Windows.Forms.Label();
            this.mtbDescontoPorcentagem = new System.Windows.Forms.MaskedTextBox();
            this.lblDescontoPor100 = new System.Windows.Forms.Label();
            this.lbTotalPodutos = new System.Windows.Forms.Label();
            this.lblQuantidadePrutudoQ = new System.Windows.Forms.Label();
            this.cbVendedor = new System.Windows.Forms.ComboBox();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.mtbAgrescimoD = new System.Windows.Forms.MaskedTextBox();
            this.lblAteracaoReal = new System.Windows.Forms.Label();
            this.mtbAgrescimoP = new System.Windows.Forms.MaskedTextBox();
            this.lblAteracoes = new System.Windows.Forms.Label();
            this.rbtnVista = new System.Windows.Forms.RadioButton();
            this.rbtnPrazo = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgCarrinho)).BeginInit();
            this.gbConsumidor.SuspendLayout();
            this.gbProduto.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgCarrinho
            // 
            this.dgCarrinho.AllowUserToAddRows = false;
            this.dgCarrinho.AllowUserToDeleteRows = false;
            this.dgCarrinho.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgCarrinho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCarrinho.Location = new System.Drawing.Point(429, 85);
            this.dgCarrinho.Name = "dgCarrinho";
            this.dgCarrinho.ReadOnly = true;
            this.dgCarrinho.Size = new System.Drawing.Size(502, 305);
            this.dgCarrinho.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnCancelar.Location = new System.Drawing.Point(26, 467);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 43);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnPagar
            // 
            this.btnPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnPagar.Location = new System.Drawing.Point(791, 467);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(112, 43);
            this.btnPagar.TabIndex = 4;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // gbConsumidor
            // 
            this.gbConsumidor.Controls.Add(this.mtbFone);
            this.gbConsumidor.Controls.Add(this.txtID);
            this.gbConsumidor.Controls.Add(this.btnPesquisarCliente);
            this.gbConsumidor.Controls.Add(this.btnPesquisarNome);
            this.gbConsumidor.Controls.Add(this.lblFone);
            this.gbConsumidor.Controls.Add(this.txtEndereco);
            this.gbConsumidor.Controls.Add(this.lblEndereco);
            this.gbConsumidor.Controls.Add(this.txtNome);
            this.gbConsumidor.Controls.Add(this.lblNomeCon);
            this.gbConsumidor.Controls.Add(this.mtbCPF);
            this.gbConsumidor.Controls.Add(this.lblCPF);
            this.gbConsumidor.Controls.Add(this.lblID);
            this.gbConsumidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbConsumidor.Location = new System.Drawing.Point(36, 16);
            this.gbConsumidor.Name = "gbConsumidor";
            this.gbConsumidor.Size = new System.Drawing.Size(372, 182);
            this.gbConsumidor.TabIndex = 10;
            this.gbConsumidor.TabStop = false;
            this.gbConsumidor.Text = "Consumidor";
            // 
            // mtbFone
            // 
            this.mtbFone.Location = new System.Drawing.Point(242, 45);
            this.mtbFone.Mask = "(99) 99999-9999";
            this.mtbFone.Name = "mtbFone";
            this.mtbFone.Size = new System.Drawing.Size(98, 20);
            this.mtbFone.TabIndex = 25;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(67, 19);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(50, 20);
            this.txtID.TabIndex = 22;
            // 
            // btnPesquisarCliente
            // 
            this.btnPesquisarCliente.Image = global::SistemaVenda.Properties.Resources._2093656_seach_look_search_see_icon__1_;
            this.btnPesquisarCliente.Location = new System.Drawing.Point(170, 41);
            this.btnPesquisarCliente.Name = "btnPesquisarCliente";
            this.btnPesquisarCliente.Size = new System.Drawing.Size(26, 26);
            this.btnPesquisarCliente.TabIndex = 21;
            this.btnPesquisarCliente.UseVisualStyleBackColor = true;
            this.btnPesquisarCliente.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnPesquisarNome
            // 
            this.btnPesquisarNome.Image = global::SistemaVenda.Properties.Resources._2093656_seach_look_search_see_icon__1_;
            this.btnPesquisarNome.Location = new System.Drawing.Point(341, 67);
            this.btnPesquisarNome.Name = "btnPesquisarNome";
            this.btnPesquisarNome.Size = new System.Drawing.Size(26, 26);
            this.btnPesquisarNome.TabIndex = 20;
            this.btnPesquisarNome.UseVisualStyleBackColor = true;
            this.btnPesquisarNome.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblFone
            // 
            this.lblFone.AutoSize = true;
            this.lblFone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFone.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblFone.Location = new System.Drawing.Point(209, 48);
            this.lblFone.Name = "lblFone";
            this.lblFone.Size = new System.Drawing.Size(39, 13);
            this.lblFone.TabIndex = 18;
            this.lblFone.Text = "Fone:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(69, 97);
            this.txtEndereco.Multiline = true;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(268, 56);
            this.txtEndereco.TabIndex = 17;
            this.txtEndereco.UseSystemPasswordChar = true;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblEndereco.Location = new System.Drawing.Point(13, 100);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(65, 13);
            this.lblEndereco.TabIndex = 16;
            this.lblEndereco.Text = "Endereço:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(67, 71);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(268, 20);
            this.txtNome.TabIndex = 15;
            // 
            // lblNomeCon
            // 
            this.lblNomeCon.AutoSize = true;
            this.lblNomeCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCon.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblNomeCon.Location = new System.Drawing.Point(22, 74);
            this.lblNomeCon.Name = "lblNomeCon";
            this.lblNomeCon.Size = new System.Drawing.Size(43, 13);
            this.lblNomeCon.TabIndex = 14;
            this.lblNomeCon.Text = "Nome:";
            // 
            // mtbCPF
            // 
            this.mtbCPF.Location = new System.Drawing.Point(67, 45);
            this.mtbCPF.Mask = "000.000.000-00";
            this.mtbCPF.Name = "mtbCPF";
            this.mtbCPF.Size = new System.Drawing.Size(97, 20);
            this.mtbCPF.TabIndex = 13;
            this.mtbCPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbCPF_KeyPress);
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblCPF.Location = new System.Drawing.Point(31, 48);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(34, 13);
            this.lblCPF.TabIndex = 12;
            this.lblCPF.Text = "CPF:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblID.Location = new System.Drawing.Point(23, 22);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(50, 13);
            this.lblID.TabIndex = 10;
            this.lblID.Text = "Código:";
            // 
            // gbProduto
            // 
            this.gbProduto.Controls.Add(this.txtPrecoVista);
            this.gbProduto.Controls.Add(this.lblPrecoVista);
            this.gbProduto.Controls.Add(this.txtPrecoPrazo);
            this.gbProduto.Controls.Add(this.lblPrecoPrazo);
            this.gbProduto.Controls.Add(this.txtQuantidade);
            this.gbProduto.Controls.Add(this.txtDescricaoResumida);
            this.gbProduto.Controls.Add(this.txtEstoque);
            this.gbProduto.Controls.Add(this.txtCodigoProduto);
            this.gbProduto.Controls.Add(this.btnPesquisarProduto);
            this.gbProduto.Controls.Add(this.btnAdicionar);
            this.gbProduto.Controls.Add(this.lblEstoque);
            this.gbProduto.Controls.Add(this.btnRemover);
            this.gbProduto.Controls.Add(this.lblQuantidade);
            this.gbProduto.Controls.Add(this.lblDescriçãoResumida);
            this.gbProduto.Controls.Add(this.lblCodigoProduto);
            this.gbProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbProduto.Location = new System.Drawing.Point(26, 236);
            this.gbProduto.Name = "gbProduto";
            this.gbProduto.Size = new System.Drawing.Size(372, 157);
            this.gbProduto.TabIndex = 11;
            this.gbProduto.TabStop = false;
            this.gbProduto.Text = "Produto";
            // 
            // txtPrecoVista
            // 
            this.txtPrecoVista.Location = new System.Drawing.Point(100, 70);
            this.txtPrecoVista.Name = "txtPrecoVista";
            this.txtPrecoVista.Size = new System.Drawing.Size(50, 20);
            this.txtPrecoVista.TabIndex = 38;
            // 
            // lblPrecoVista
            // 
            this.lblPrecoVista.AutoSize = true;
            this.lblPrecoVista.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoVista.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblPrecoVista.Location = new System.Drawing.Point(13, 73);
            this.lblPrecoVista.Name = "lblPrecoVista";
            this.lblPrecoVista.Size = new System.Drawing.Size(86, 13);
            this.lblPrecoVista.TabIndex = 37;
            this.lblPrecoVista.Text = "Preço á vista:";
            // 
            // txtPrecoPrazo
            // 
            this.txtPrecoPrazo.Location = new System.Drawing.Point(258, 68);
            this.txtPrecoPrazo.Name = "txtPrecoPrazo";
            this.txtPrecoPrazo.Size = new System.Drawing.Size(50, 20);
            this.txtPrecoPrazo.TabIndex = 36;
            // 
            // lblPrecoPrazo
            // 
            this.lblPrecoPrazo.AutoSize = true;
            this.lblPrecoPrazo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoPrazo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblPrecoPrazo.Location = new System.Drawing.Point(170, 71);
            this.lblPrecoPrazo.Name = "lblPrecoPrazo";
            this.lblPrecoPrazo.Size = new System.Drawing.Size(90, 13);
            this.lblPrecoPrazo.TabIndex = 35;
            this.lblPrecoPrazo.Text = "Preço á prazo:";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(297, 14);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(50, 20);
            this.txtQuantidade.TabIndex = 34;
            // 
            // txtDescricaoResumida
            // 
            this.txtDescricaoResumida.Location = new System.Drawing.Point(49, 43);
            this.txtDescricaoResumida.Name = "txtDescricaoResumida";
            this.txtDescricaoResumida.Size = new System.Drawing.Size(240, 20);
            this.txtDescricaoResumida.TabIndex = 33;
            // 
            // txtEstoque
            // 
            this.txtEstoque.Location = new System.Drawing.Point(165, 14);
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.Size = new System.Drawing.Size(50, 20);
            this.txtEstoque.TabIndex = 32;
            // 
            // txtCodigoProduto
            // 
            this.txtCodigoProduto.Location = new System.Drawing.Point(57, 14);
            this.txtCodigoProduto.Name = "txtCodigoProduto";
            this.txtCodigoProduto.Size = new System.Drawing.Size(50, 20);
            this.txtCodigoProduto.TabIndex = 31;
            this.txtCodigoProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoProduto_KeyPress);
            // 
            // btnPesquisarProduto
            // 
            this.btnPesquisarProduto.Image = global::SistemaVenda.Properties.Resources._2093656_seach_look_search_see_icon__1_;
            this.btnPesquisarProduto.Location = new System.Drawing.Point(292, 40);
            this.btnPesquisarProduto.Name = "btnPesquisarProduto";
            this.btnPesquisarProduto.Size = new System.Drawing.Size(26, 26);
            this.btnPesquisarProduto.TabIndex = 30;
            this.btnPesquisarProduto.UseVisualStyleBackColor = true;
            this.btnPesquisarProduto.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnAdicionar.Location = new System.Drawing.Point(220, 98);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(112, 43);
            this.btnAdicionar.TabIndex = 29;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // lblEstoque
            // 
            this.lblEstoque.AutoSize = true;
            this.lblEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstoque.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblEstoque.Location = new System.Drawing.Point(116, 18);
            this.lblEstoque.Name = "lblEstoque";
            this.lblEstoque.Size = new System.Drawing.Size(57, 13);
            this.lblEstoque.TabIndex = 28;
            this.lblEstoque.Text = "Estoque:";
            // 
            // btnRemover
            // 
            this.btnRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnRemover.Location = new System.Drawing.Point(42, 98);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(112, 43);
            this.btnRemover.TabIndex = 28;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblQuantidade.Location = new System.Drawing.Point(224, 18);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(76, 13);
            this.lblQuantidade.TabIndex = 26;
            this.lblQuantidade.Text = "Qauntidade:";
            // 
            // lblDescriçãoResumida
            // 
            this.lblDescriçãoResumida.AutoSize = true;
            this.lblDescriçãoResumida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescriçãoResumida.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblDescriçãoResumida.Location = new System.Drawing.Point(7, 45);
            this.lblDescriçãoResumida.Name = "lblDescriçãoResumida";
            this.lblDescriçãoResumida.Size = new System.Drawing.Size(43, 13);
            this.lblDescriçãoResumida.TabIndex = 24;
            this.lblDescriçãoResumida.Text = "Nome:";
            // 
            // lblCodigoProduto
            // 
            this.lblCodigoProduto.AutoSize = true;
            this.lblCodigoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoProduto.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblCodigoProduto.Location = new System.Drawing.Point(11, 18);
            this.lblCodigoProduto.Name = "lblCodigoProduto";
            this.lblCodigoProduto.Size = new System.Drawing.Size(50, 13);
            this.lblCodigoProduto.TabIndex = 22;
            this.lblCodigoProduto.Text = "Código:";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblHora.Location = new System.Drawing.Point(811, 13);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(38, 13);
            this.lblHora.TabIndex = 12;
            this.lblHora.Text = "Hora:";
            // 
            // mtbHora
            // 
            this.mtbHora.Location = new System.Drawing.Point(847, 9);
            this.mtbHora.Mask = "90:00";
            this.mtbHora.Name = "mtbHora";
            this.mtbHora.Size = new System.Drawing.Size(38, 20);
            this.mtbHora.TabIndex = 14;
            this.mtbHora.ValidatingType = typeof(System.DateTime);
            // 
            // mtbData
            // 
            this.mtbData.Location = new System.Drawing.Point(847, 35);
            this.mtbData.Mask = "99/99/9999";
            this.mtbData.Name = "mtbData";
            this.mtbData.Size = new System.Drawing.Size(67, 20);
            this.mtbData.TabIndex = 16;
            this.mtbData.ValidatingType = typeof(System.DateTime);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblData.Location = new System.Drawing.Point(811, 39);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(38, 13);
            this.lblData.TabIndex = 15;
            this.lblData.Text = "Data:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTotal.Location = new System.Drawing.Point(471, 448);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(40, 13);
            this.lblTotal.TabIndex = 19;
            this.lblTotal.Text = "Total:";
            // 
            // mtbTotal
            // 
            this.mtbTotal.Location = new System.Drawing.Point(508, 444);
            this.mtbTotal.Name = "mtbTotal";
            this.mtbTotal.Size = new System.Drawing.Size(67, 20);
            this.mtbTotal.TabIndex = 20;
            this.mtbTotal.ValidatingType = typeof(System.DateTime);
            // 
            // mtbDescontoReal
            // 
            this.mtbDescontoReal.Location = new System.Drawing.Point(508, 418);
            this.mtbDescontoReal.Name = "mtbDescontoReal";
            this.mtbDescontoReal.Size = new System.Drawing.Size(67, 20);
            this.mtbDescontoReal.TabIndex = 24;
            this.mtbDescontoReal.ValidatingType = typeof(System.DateTime);
            this.mtbDescontoReal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbDescontoReal_KeyPress);
            // 
            // lblDescontoReal
            // 
            this.lblDescontoReal.AutoSize = true;
            this.lblDescontoReal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescontoReal.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblDescontoReal.Location = new System.Drawing.Point(427, 421);
            this.lblDescontoReal.Name = "lblDescontoReal";
            this.lblDescontoReal.Size = new System.Drawing.Size(85, 13);
            this.lblDescontoReal.TabIndex = 23;
            this.lblDescontoReal.Text = "Desconto R$:";
            // 
            // mtbDescontoPorcentagem
            // 
            this.mtbDescontoPorcentagem.Location = new System.Drawing.Point(508, 392);
            this.mtbDescontoPorcentagem.Name = "mtbDescontoPorcentagem";
            this.mtbDescontoPorcentagem.Size = new System.Drawing.Size(67, 20);
            this.mtbDescontoPorcentagem.TabIndex = 22;
            this.mtbDescontoPorcentagem.ValidatingType = typeof(System.DateTime);
            this.mtbDescontoPorcentagem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbDescontoPorcentagem_KeyPress);
            // 
            // lblDescontoPor100
            // 
            this.lblDescontoPor100.AutoSize = true;
            this.lblDescontoPor100.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescontoPor100.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblDescontoPor100.Location = new System.Drawing.Point(427, 395);
            this.lblDescontoPor100.Name = "lblDescontoPor100";
            this.lblDescontoPor100.Size = new System.Drawing.Size(78, 13);
            this.lblDescontoPor100.TabIndex = 21;
            this.lblDescontoPor100.Text = "Desconto %:";
            // 
            // lbTotalPodutos
            // 
            this.lbTotalPodutos.AutoSize = true;
            this.lbTotalPodutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPodutos.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbTotalPodutos.Location = new System.Drawing.Point(749, 63);
            this.lbTotalPodutos.Name = "lbTotalPodutos";
            this.lbTotalPodutos.Size = new System.Drawing.Size(94, 13);
            this.lbTotalPodutos.TabIndex = 25;
            this.lbTotalPodutos.Text = "Total Produtos:";
            // 
            // lblQuantidadePrutudoQ
            // 
            this.lblQuantidadePrutudoQ.AutoSize = true;
            this.lblQuantidadePrutudoQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidadePrutudoQ.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblQuantidadePrutudoQ.Location = new System.Drawing.Point(844, 63);
            this.lblQuantidadePrutudoQ.Name = "lblQuantidadePrutudoQ";
            this.lblQuantidadePrutudoQ.Size = new System.Drawing.Size(80, 13);
            this.lblQuantidadePrutudoQ.TabIndex = 26;
            this.lblQuantidadePrutudoQ.Text = "QuantidadeP";
            // 
            // cbVendedor
            // 
            this.cbVendedor.FormattingEnabled = true;
            this.cbVendedor.Location = new System.Drawing.Point(492, 16);
            this.cbVendedor.Name = "cbVendedor";
            this.cbVendedor.Size = new System.Drawing.Size(121, 21);
            this.cbVendedor.TabIndex = 27;
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendedor.Location = new System.Drawing.Point(427, 19);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(65, 13);
            this.lblVendedor.TabIndex = 28;
            this.lblVendedor.Text = "Vendedor:";
            // 
            // mtbAgrescimoD
            // 
            this.mtbAgrescimoD.Location = new System.Drawing.Point(674, 419);
            this.mtbAgrescimoD.Name = "mtbAgrescimoD";
            this.mtbAgrescimoD.Size = new System.Drawing.Size(67, 20);
            this.mtbAgrescimoD.TabIndex = 32;
            this.mtbAgrescimoD.ValidatingType = typeof(System.DateTime);
            this.mtbAgrescimoD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbAgrescimoD_KeyPress);
            // 
            // lblAteracaoReal
            // 
            this.lblAteracaoReal.AutoSize = true;
            this.lblAteracaoReal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAteracaoReal.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblAteracaoReal.Location = new System.Drawing.Point(587, 422);
            this.lblAteracaoReal.Name = "lblAteracaoReal";
            this.lblAteracaoReal.Size = new System.Drawing.Size(89, 13);
            this.lblAteracaoReal.TabIndex = 31;
            this.lblAteracaoReal.Text = "Agrescimo R$:";
            // 
            // mtbAgrescimoP
            // 
            this.mtbAgrescimoP.Location = new System.Drawing.Point(674, 393);
            this.mtbAgrescimoP.Name = "mtbAgrescimoP";
            this.mtbAgrescimoP.Size = new System.Drawing.Size(67, 20);
            this.mtbAgrescimoP.TabIndex = 30;
            this.mtbAgrescimoP.ValidatingType = typeof(System.DateTime);
            this.mtbAgrescimoP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbAgrescimoP_KeyPress);
            // 
            // lblAteracoes
            // 
            this.lblAteracoes.AutoSize = true;
            this.lblAteracoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAteracoes.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblAteracoes.Location = new System.Drawing.Point(588, 396);
            this.lblAteracoes.Name = "lblAteracoes";
            this.lblAteracoes.Size = new System.Drawing.Size(82, 13);
            this.lblAteracoes.TabIndex = 29;
            this.lblAteracoes.Text = "Agrescimo %:";
            // 
            // rbtnVista
            // 
            this.rbtnVista.AutoSize = true;
            this.rbtnVista.Location = new System.Drawing.Point(630, 16);
            this.rbtnVista.Name = "rbtnVista";
            this.rbtnVista.Size = new System.Drawing.Size(57, 17);
            this.rbtnVista.TabIndex = 33;
            this.rbtnVista.TabStop = true;
            this.rbtnVista.Text = "Á vista";
            this.rbtnVista.UseVisualStyleBackColor = true;
            this.rbtnVista.CheckedChanged += new System.EventHandler(this.rbtnVista_CheckedChanged);
            // 
            // rbtnPrazo
            // 
            this.rbtnPrazo.AutoSize = true;
            this.rbtnPrazo.Location = new System.Drawing.Point(630, 39);
            this.rbtnPrazo.Name = "rbtnPrazo";
            this.rbtnPrazo.Size = new System.Drawing.Size(61, 17);
            this.rbtnPrazo.TabIndex = 34;
            this.rbtnPrazo.TabStop = true;
            this.rbtnPrazo.Text = "Á prazo";
            this.rbtnPrazo.UseVisualStyleBackColor = true;
            this.rbtnPrazo.CheckedChanged += new System.EventHandler(this.rbtnPrazo_CheckedChanged);
            // 
            // frmVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 533);
            this.Controls.Add(this.rbtnPrazo);
            this.Controls.Add(this.rbtnVista);
            this.Controls.Add(this.mtbAgrescimoD);
            this.Controls.Add(this.lblAteracaoReal);
            this.Controls.Add(this.mtbAgrescimoP);
            this.Controls.Add(this.lblAteracoes);
            this.Controls.Add(this.lblVendedor);
            this.Controls.Add(this.cbVendedor);
            this.Controls.Add(this.lblQuantidadePrutudoQ);
            this.Controls.Add(this.lbTotalPodutos);
            this.Controls.Add(this.mtbDescontoReal);
            this.Controls.Add(this.lblDescontoReal);
            this.Controls.Add(this.mtbDescontoPorcentagem);
            this.Controls.Add(this.lblDescontoPor100);
            this.Controls.Add(this.mtbTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.mtbData);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.mtbHora);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.gbProduto);
            this.Controls.Add(this.gbConsumidor);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dgCarrinho);
            this.Name = "frmVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Vendas";
            this.Load += new System.EventHandler(this.frmVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCarrinho)).EndInit();
            this.gbConsumidor.ResumeLayout(false);
            this.gbConsumidor.PerformLayout();
            this.gbProduto.ResumeLayout(false);
            this.gbProduto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox gbConsumidor;
        private System.Windows.Forms.Label lblFone;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblNomeCon;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.GroupBox gbProduto;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblDescriçãoResumida;
        private System.Windows.Forms.Label lblCodigoProduto;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblDescontoReal;
        private System.Windows.Forms.Label lblDescontoPor100;
        private System.Windows.Forms.Button btnPesquisarProduto;
        private System.Windows.Forms.Button btnPesquisarCliente;
        private System.Windows.Forms.Label lblEstoque;
        private System.Windows.Forms.Label lblPrecoVista;
        private System.Windows.Forms.Label lblPrecoPrazo;
        private System.Windows.Forms.Label lbTotalPodutos;
        private System.Windows.Forms.Label lblQuantidadePrutudoQ;
        public System.Windows.Forms.Button btnPagar;
        public System.Windows.Forms.MaskedTextBox mtbTotal;
        public System.Windows.Forms.TextBox txtEndereco;
        public System.Windows.Forms.TextBox txtNome;
        public System.Windows.Forms.MaskedTextBox mtbCPF;
        public System.Windows.Forms.MaskedTextBox mtbHora;
        public System.Windows.Forms.MaskedTextBox mtbData;
        public System.Windows.Forms.TextBox txtID;
        public System.Windows.Forms.TextBox txtCodigoProduto;
        public System.Windows.Forms.MaskedTextBox mtbFone;
        public System.Windows.Forms.TextBox txtDescricaoResumida;
        public System.Windows.Forms.TextBox txtEstoque;
        public System.Windows.Forms.TextBox txtQuantidade;
        public System.Windows.Forms.TextBox txtPrecoVista;
        public System.Windows.Forms.TextBox txtPrecoPrazo;
        public System.Windows.Forms.DataGridView dgCarrinho;
        public System.Windows.Forms.MaskedTextBox mtbDescontoReal;
        public System.Windows.Forms.MaskedTextBox mtbDescontoPorcentagem;
        private System.Windows.Forms.Label lblVendedor;
        public System.Windows.Forms.MaskedTextBox mtbAgrescimoD;
        public System.Windows.Forms.MaskedTextBox mtbAgrescimoP;
        public System.Windows.Forms.Label lblAteracaoReal;
        public System.Windows.Forms.Label lblAteracoes;
        private System.Windows.Forms.RadioButton rbtnVista;
        private System.Windows.Forms.RadioButton rbtnPrazo;
        public System.Windows.Forms.Button btnPesquisarNome;
        public System.Windows.Forms.ComboBox cbVendedor;
    }
}