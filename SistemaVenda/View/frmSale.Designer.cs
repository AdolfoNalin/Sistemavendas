namespace SistemaVenda.View
{
    partial class frmSale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSale));
            this.tabSale = new System.Windows.Forms.TabControl();
            this.tpConsult = new System.Windows.Forms.TabPage();
            this.dgSale = new System.Windows.Forms.DataGridView();
            this.tpDetails = new System.Windows.Forms.TabPage();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtnTerm = new System.Windows.Forms.RadioButton();
            this.rbtnSport = new System.Windows.Forms.RadioButton();
            this.mtbAdditionCash = new System.Windows.Forms.MaskedTextBox();
            this.lblAteracaoReal = new System.Windows.Forms.Label();
            this.mtbAdditionPorcentage = new System.Windows.Forms.MaskedTextBox();
            this.lblAteracoes = new System.Windows.Forms.Label();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.cbUsers = new System.Windows.Forms.ComboBox();
            this.lblQuantidadePrutudoQ = new System.Windows.Forms.Label();
            this.lbTotalPodutos = new System.Windows.Forms.Label();
            this.mtbCashDiscount = new System.Windows.Forms.MaskedTextBox();
            this.lblDescontoReal = new System.Windows.Forms.Label();
            this.mtbPorcentageDiscount = new System.Windows.Forms.MaskedTextBox();
            this.lblDescontoPor100 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.MaskedTextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.mtbDate = new System.Windows.Forms.MaskedTextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.gbProduto = new System.Windows.Forms.GroupBox();
            this.txtSpotPrice = new System.Windows.Forms.TextBox();
            this.lblPrecoVista = new System.Windows.Forms.Label();
            this.txtTermPrice = new System.Windows.Forms.TextBox();
            this.lblPrecoPrazo = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtShortDescription = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.btnSearchProduct = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblEstoque = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblDescriçãoResumida = new System.Windows.Forms.Label();
            this.lblCodigoProduto = new System.Windows.Forms.Label();
            this.gbClient = new System.Windows.Forms.GroupBox();
            this.mtbPhone = new System.Windows.Forms.MaskedTextBox();
            this.txtClientId = new System.Windows.Forms.TextBox();
            this.btnPesquisarCliente = new System.Windows.Forms.Button();
            this.btnSearchName = new System.Windows.Forms.Button();
            this.lblFone = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblNomeCon = new System.Windows.Forms.Label();
            this.mtbCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.btnPagar = new System.Windows.Forms.Button();
            this.dgShoppingCar = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.tabSale.SuspendLayout();
            this.tpConsult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSale)).BeginInit();
            this.tpDetails.SuspendLayout();
            this.gbProduto.SuspendLayout();
            this.gbClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgShoppingCar)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabSale
            // 
            this.tabSale.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabSale.Controls.Add(this.tpConsult);
            this.tabSale.Controls.Add(this.tpDetails);
            this.tabSale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabSale.Location = new System.Drawing.Point(0, 100);
            this.tabSale.Multiline = true;
            this.tabSale.Name = "tabSale";
            this.tabSale.SelectedIndex = 0;
            this.tabSale.Size = new System.Drawing.Size(1143, 490);
            this.tabSale.TabIndex = 5;
            // 
            // tpConsult
            // 
            this.tpConsult.Controls.Add(this.dgSale);
            this.tpConsult.Location = new System.Drawing.Point(23, 4);
            this.tpConsult.Name = "tpConsult";
            this.tpConsult.Padding = new System.Windows.Forms.Padding(3);
            this.tpConsult.Size = new System.Drawing.Size(1116, 482);
            this.tpConsult.TabIndex = 0;
            this.tpConsult.Text = "Consulta";
            this.tpConsult.UseVisualStyleBackColor = true;
            // 
            // dgSale
            // 
            this.dgSale.AllowUserToAddRows = false;
            this.dgSale.AllowUserToDeleteRows = false;
            this.dgSale.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgSale.Location = new System.Drawing.Point(3, 3);
            this.dgSale.Name = "dgSale";
            this.dgSale.ReadOnly = true;
            this.dgSale.Size = new System.Drawing.Size(1110, 476);
            this.dgSale.TabIndex = 0;
            this.dgSale.SelectionChanged += new System.EventHandler(this.dgSale_SelectionChanged);
            // 
            // tpDetails
            // 
            this.tpDetails.Controls.Add(this.txtId);
            this.tpDetails.Controls.Add(this.label1);
            this.tpDetails.Controls.Add(this.rbtnTerm);
            this.tpDetails.Controls.Add(this.rbtnSport);
            this.tpDetails.Controls.Add(this.mtbAdditionCash);
            this.tpDetails.Controls.Add(this.lblAteracaoReal);
            this.tpDetails.Controls.Add(this.mtbAdditionPorcentage);
            this.tpDetails.Controls.Add(this.lblAteracoes);
            this.tpDetails.Controls.Add(this.lblVendedor);
            this.tpDetails.Controls.Add(this.cbUsers);
            this.tpDetails.Controls.Add(this.lblQuantidadePrutudoQ);
            this.tpDetails.Controls.Add(this.lbTotalPodutos);
            this.tpDetails.Controls.Add(this.mtbCashDiscount);
            this.tpDetails.Controls.Add(this.lblDescontoReal);
            this.tpDetails.Controls.Add(this.mtbPorcentageDiscount);
            this.tpDetails.Controls.Add(this.lblDescontoPor100);
            this.tpDetails.Controls.Add(this.txtTotal);
            this.tpDetails.Controls.Add(this.lblTotal);
            this.tpDetails.Controls.Add(this.mtbDate);
            this.tpDetails.Controls.Add(this.lblData);
            this.tpDetails.Controls.Add(this.gbProduto);
            this.tpDetails.Controls.Add(this.gbClient);
            this.tpDetails.Controls.Add(this.btnPagar);
            this.tpDetails.Controls.Add(this.dgShoppingCar);
            this.tpDetails.Location = new System.Drawing.Point(23, 4);
            this.tpDetails.Name = "tpDetails";
            this.tpDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tpDetails.Size = new System.Drawing.Size(1116, 482);
            this.tpDetails.TabIndex = 1;
            this.tpDetails.Text = "Detalhes";
            this.tpDetails.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(52, 21);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(50, 20);
            this.txtId.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(8, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 60;
            this.label1.Text = "Código:";
            // 
            // rbtnTerm
            // 
            this.rbtnTerm.AutoSize = true;
            this.rbtnTerm.Location = new System.Drawing.Point(710, 30);
            this.rbtnTerm.Name = "rbtnTerm";
            this.rbtnTerm.Size = new System.Drawing.Size(61, 17);
            this.rbtnTerm.TabIndex = 59;
            this.rbtnTerm.TabStop = true;
            this.rbtnTerm.Text = "Á prazo";
            this.rbtnTerm.UseVisualStyleBackColor = true;
            // 
            // rbtnSport
            // 
            this.rbtnSport.AutoSize = true;
            this.rbtnSport.Location = new System.Drawing.Point(710, 7);
            this.rbtnSport.Name = "rbtnSport";
            this.rbtnSport.Size = new System.Drawing.Size(57, 17);
            this.rbtnSport.TabIndex = 58;
            this.rbtnSport.TabStop = true;
            this.rbtnSport.Text = "Á vista";
            this.rbtnSport.UseVisualStyleBackColor = true;
            this.rbtnSport.CheckedChanged += new System.EventHandler(this.rbtnSport_CheckedChanged);
            // 
            // mtbAdditionCash
            // 
            this.mtbAdditionCash.Location = new System.Drawing.Point(754, 401);
            this.mtbAdditionCash.Name = "mtbAdditionCash";
            this.mtbAdditionCash.Size = new System.Drawing.Size(67, 20);
            this.mtbAdditionCash.TabIndex = 57;
            this.mtbAdditionCash.ValidatingType = typeof(System.DateTime);
            this.mtbAdditionCash.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtbAdditionCash_KeyDown);
            // 
            // lblAteracaoReal
            // 
            this.lblAteracaoReal.AutoSize = true;
            this.lblAteracaoReal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAteracaoReal.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblAteracaoReal.Location = new System.Drawing.Point(667, 404);
            this.lblAteracaoReal.Name = "lblAteracaoReal";
            this.lblAteracaoReal.Size = new System.Drawing.Size(89, 13);
            this.lblAteracaoReal.TabIndex = 56;
            this.lblAteracaoReal.Text = "Agrescimo R$:";
            // 
            // mtbAdditionPorcentage
            // 
            this.mtbAdditionPorcentage.Location = new System.Drawing.Point(754, 375);
            this.mtbAdditionPorcentage.Name = "mtbAdditionPorcentage";
            this.mtbAdditionPorcentage.Size = new System.Drawing.Size(67, 20);
            this.mtbAdditionPorcentage.TabIndex = 55;
            this.mtbAdditionPorcentage.ValidatingType = typeof(System.DateTime);
            this.mtbAdditionPorcentage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtbAdditionPorcentage_KeyDown);
            // 
            // lblAteracoes
            // 
            this.lblAteracoes.AutoSize = true;
            this.lblAteracoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAteracoes.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblAteracoes.Location = new System.Drawing.Point(668, 378);
            this.lblAteracoes.Name = "lblAteracoes";
            this.lblAteracoes.Size = new System.Drawing.Size(82, 13);
            this.lblAteracoes.TabIndex = 54;
            this.lblAteracoes.Text = "Agrescimo %:";
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendedor.Location = new System.Drawing.Point(521, 17);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(54, 13);
            this.lblVendedor.TabIndex = 53;
            this.lblVendedor.Text = "Usuário:";
            // 
            // cbUsers
            // 
            this.cbUsers.FormattingEnabled = true;
            this.cbUsers.Location = new System.Drawing.Point(578, 13);
            this.cbUsers.Name = "cbUsers";
            this.cbUsers.Size = new System.Drawing.Size(121, 21);
            this.cbUsers.TabIndex = 52;
            // 
            // lblQuantidadePrutudoQ
            // 
            this.lblQuantidadePrutudoQ.AutoSize = true;
            this.lblQuantidadePrutudoQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidadePrutudoQ.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblQuantidadePrutudoQ.Location = new System.Drawing.Point(924, 45);
            this.lblQuantidadePrutudoQ.Name = "lblQuantidadePrutudoQ";
            this.lblQuantidadePrutudoQ.Size = new System.Drawing.Size(80, 13);
            this.lblQuantidadePrutudoQ.TabIndex = 51;
            this.lblQuantidadePrutudoQ.Text = "QuantidadeP";
            // 
            // lbTotalPodutos
            // 
            this.lbTotalPodutos.AutoSize = true;
            this.lbTotalPodutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPodutos.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbTotalPodutos.Location = new System.Drawing.Point(829, 45);
            this.lbTotalPodutos.Name = "lbTotalPodutos";
            this.lbTotalPodutos.Size = new System.Drawing.Size(94, 13);
            this.lbTotalPodutos.TabIndex = 50;
            this.lbTotalPodutos.Text = "Total Produtos:";
            // 
            // mtbCashDiscount
            // 
            this.mtbCashDiscount.Location = new System.Drawing.Point(588, 400);
            this.mtbCashDiscount.Name = "mtbCashDiscount";
            this.mtbCashDiscount.Size = new System.Drawing.Size(67, 20);
            this.mtbCashDiscount.TabIndex = 49;
            this.mtbCashDiscount.ValidatingType = typeof(System.DateTime);
            this.mtbCashDiscount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtbCashDiscount_KeyDown);
            // 
            // lblDescontoReal
            // 
            this.lblDescontoReal.AutoSize = true;
            this.lblDescontoReal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescontoReal.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblDescontoReal.Location = new System.Drawing.Point(507, 403);
            this.lblDescontoReal.Name = "lblDescontoReal";
            this.lblDescontoReal.Size = new System.Drawing.Size(85, 13);
            this.lblDescontoReal.TabIndex = 48;
            this.lblDescontoReal.Text = "Desconto R$:";
            // 
            // mtbPorcentageDiscount
            // 
            this.mtbPorcentageDiscount.Location = new System.Drawing.Point(588, 374);
            this.mtbPorcentageDiscount.Name = "mtbPorcentageDiscount";
            this.mtbPorcentageDiscount.Size = new System.Drawing.Size(67, 20);
            this.mtbPorcentageDiscount.TabIndex = 47;
            this.mtbPorcentageDiscount.ValidatingType = typeof(System.DateTime);
            this.mtbPorcentageDiscount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtbPorcentageDiscount_KeyDown);
            // 
            // lblDescontoPor100
            // 
            this.lblDescontoPor100.AutoSize = true;
            this.lblDescontoPor100.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescontoPor100.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblDescontoPor100.Location = new System.Drawing.Point(507, 377);
            this.lblDescontoPor100.Name = "lblDescontoPor100";
            this.lblDescontoPor100.Size = new System.Drawing.Size(78, 13);
            this.lblDescontoPor100.TabIndex = 46;
            this.lblDescontoPor100.Text = "Desconto %:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(588, 426);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(67, 20);
            this.txtTotal.TabIndex = 45;
            this.txtTotal.ValidatingType = typeof(System.DateTime);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTotal.Location = new System.Drawing.Point(551, 430);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(40, 13);
            this.lblTotal.TabIndex = 44;
            this.lblTotal.Text = "Total:";
            // 
            // mtbDate
            // 
            this.mtbDate.Location = new System.Drawing.Point(927, 17);
            this.mtbDate.Mask = "99/99/9999";
            this.mtbDate.Name = "mtbDate";
            this.mtbDate.Size = new System.Drawing.Size(67, 20);
            this.mtbDate.TabIndex = 43;
            this.mtbDate.ValidatingType = typeof(System.DateTime);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblData.Location = new System.Drawing.Point(891, 21);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(38, 13);
            this.lblData.TabIndex = 42;
            this.lblData.Text = "Data:";
            // 
            // gbProduto
            // 
            this.gbProduto.Controls.Add(this.txtSpotPrice);
            this.gbProduto.Controls.Add(this.lblPrecoVista);
            this.gbProduto.Controls.Add(this.txtTermPrice);
            this.gbProduto.Controls.Add(this.lblPrecoPrazo);
            this.gbProduto.Controls.Add(this.txtAmount);
            this.gbProduto.Controls.Add(this.txtShortDescription);
            this.gbProduto.Controls.Add(this.txtStock);
            this.gbProduto.Controls.Add(this.txtProductId);
            this.gbProduto.Controls.Add(this.btnSearchProduct);
            this.gbProduto.Controls.Add(this.btnAdd);
            this.gbProduto.Controls.Add(this.lblEstoque);
            this.gbProduto.Controls.Add(this.btnRemove);
            this.gbProduto.Controls.Add(this.lblQuantidade);
            this.gbProduto.Controls.Add(this.lblDescriçãoResumida);
            this.gbProduto.Controls.Add(this.lblCodigoProduto);
            this.gbProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbProduto.Location = new System.Drawing.Point(106, 218);
            this.gbProduto.Name = "gbProduto";
            this.gbProduto.Size = new System.Drawing.Size(372, 157);
            this.gbProduto.TabIndex = 39;
            this.gbProduto.TabStop = false;
            this.gbProduto.Text = "Produto";
            // 
            // txtSpotPrice
            // 
            this.txtSpotPrice.Location = new System.Drawing.Point(100, 70);
            this.txtSpotPrice.Name = "txtSpotPrice";
            this.txtSpotPrice.Size = new System.Drawing.Size(50, 20);
            this.txtSpotPrice.TabIndex = 38;
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
            // txtTermPrice
            // 
            this.txtTermPrice.Location = new System.Drawing.Point(258, 68);
            this.txtTermPrice.Name = "txtTermPrice";
            this.txtTermPrice.Size = new System.Drawing.Size(50, 20);
            this.txtTermPrice.TabIndex = 36;
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
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(297, 14);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(50, 20);
            this.txtAmount.TabIndex = 34;
            this.txtAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAmount_KeyDown);
            // 
            // txtShortDescription
            // 
            this.txtShortDescription.Location = new System.Drawing.Point(49, 43);
            this.txtShortDescription.Name = "txtShortDescription";
            this.txtShortDescription.Size = new System.Drawing.Size(240, 20);
            this.txtShortDescription.TabIndex = 33;
            this.txtShortDescription.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtShortDescription_KeyDown);
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(165, 14);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(50, 20);
            this.txtStock.TabIndex = 32;
            // 
            // txtProductId
            // 
            this.txtProductId.Location = new System.Drawing.Point(57, 14);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(50, 20);
            this.txtProductId.TabIndex = 31;
            // 
            // btnSearchProduct
            // 
            this.btnSearchProduct.Image = global::SistemaVenda.Properties.Resources._2093656_seach_look_search_see_icon__1_;
            this.btnSearchProduct.Location = new System.Drawing.Point(292, 40);
            this.btnSearchProduct.Name = "btnSearchProduct";
            this.btnSearchProduct.Size = new System.Drawing.Size(26, 26);
            this.btnSearchProduct.TabIndex = 30;
            this.btnSearchProduct.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnAdd.Location = new System.Drawing.Point(220, 98);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 43);
            this.btnAdd.TabIndex = 29;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnRemove.Location = new System.Drawing.Point(42, 98);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(112, 43);
            this.btnRemove.TabIndex = 28;
            this.btnRemove.Text = "Remover";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
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
            // gbClient
            // 
            this.gbClient.Controls.Add(this.mtbPhone);
            this.gbClient.Controls.Add(this.txtClientId);
            this.gbClient.Controls.Add(this.btnPesquisarCliente);
            this.gbClient.Controls.Add(this.btnSearchName);
            this.gbClient.Controls.Add(this.lblFone);
            this.gbClient.Controls.Add(this.txtAddress);
            this.gbClient.Controls.Add(this.lblEndereco);
            this.gbClient.Controls.Add(this.txtName);
            this.gbClient.Controls.Add(this.lblNomeCon);
            this.gbClient.Controls.Add(this.mtbCPF);
            this.gbClient.Controls.Add(this.lblCPF);
            this.gbClient.Controls.Add(this.lblID);
            this.gbClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbClient.Location = new System.Drawing.Point(108, 13);
            this.gbClient.Name = "gbClient";
            this.gbClient.Size = new System.Drawing.Size(372, 182);
            this.gbClient.TabIndex = 38;
            this.gbClient.TabStop = false;
            this.gbClient.Text = "Consumidor";
            // 
            // mtbPhone
            // 
            this.mtbPhone.Location = new System.Drawing.Point(242, 45);
            this.mtbPhone.Mask = "(99) 99999-9999";
            this.mtbPhone.Name = "mtbPhone";
            this.mtbPhone.Size = new System.Drawing.Size(98, 20);
            this.mtbPhone.TabIndex = 25;
            // 
            // txtClientId
            // 
            this.txtClientId.Location = new System.Drawing.Point(67, 19);
            this.txtClientId.Name = "txtClientId";
            this.txtClientId.Size = new System.Drawing.Size(50, 20);
            this.txtClientId.TabIndex = 22;
            // 
            // btnPesquisarCliente
            // 
            this.btnPesquisarCliente.Image = global::SistemaVenda.Properties.Resources._2093656_seach_look_search_see_icon__1_;
            this.btnPesquisarCliente.Location = new System.Drawing.Point(170, 41);
            this.btnPesquisarCliente.Name = "btnPesquisarCliente";
            this.btnPesquisarCliente.Size = new System.Drawing.Size(26, 26);
            this.btnPesquisarCliente.TabIndex = 21;
            this.btnPesquisarCliente.UseVisualStyleBackColor = true;
            // 
            // btnSearchName
            // 
            this.btnSearchName.Image = global::SistemaVenda.Properties.Resources._2093656_seach_look_search_see_icon__1_;
            this.btnSearchName.Location = new System.Drawing.Point(341, 67);
            this.btnSearchName.Name = "btnSearchName";
            this.btnSearchName.Size = new System.Drawing.Size(26, 26);
            this.btnSearchName.TabIndex = 20;
            this.btnSearchName.UseVisualStyleBackColor = true;
            this.btnSearchName.Click += new System.EventHandler(this.btnSearchName_Click);
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
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(69, 97);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(268, 56);
            this.txtAddress.TabIndex = 17;
            this.txtAddress.UseSystemPasswordChar = true;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblEndereco.Location = new System.Drawing.Point(6, 100);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(65, 13);
            this.lblEndereco.TabIndex = 16;
            this.lblEndereco.Text = "Endereço:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(67, 71);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(268, 20);
            this.txtName.TabIndex = 15;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
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
            // btnPagar
            // 
            this.btnPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnPagar.Location = new System.Drawing.Point(899, 401);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(136, 43);
            this.btnPagar.TabIndex = 37;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // dgShoppingCar
            // 
            this.dgShoppingCar.AllowUserToAddRows = false;
            this.dgShoppingCar.AllowUserToDeleteRows = false;
            this.dgShoppingCar.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgShoppingCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgShoppingCar.Location = new System.Drawing.Point(509, 67);
            this.dgShoppingCar.Name = "dgShoppingCar";
            this.dgShoppingCar.ReadOnly = true;
            this.dgShoppingCar.Size = new System.Drawing.Size(526, 305);
            this.dgShoppingCar.TabIndex = 35;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 590);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1143, 100);
            this.panel2.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnCancel);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(784, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(359, 100);
            this.panel5.TabIndex = 4;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.Red;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.Location = new System.Drawing.Point(239, 24);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 47);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Controls.Add(this.btnUpdate);
            this.panel4.Controls.Add(this.btnDelete);
            this.panel4.Controls.Add(this.btnNew);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(389, 100);
            this.panel4.TabIndex = 0;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.Location = new System.Drawing.Point(249, 24);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 50);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Editar";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.Location = new System.Drawing.Point(136, 24);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 50);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Excluir";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.Location = new System.Drawing.Point(20, 24);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(100, 50);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "Novo";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1143, 100);
            this.panel1.TabIndex = 3;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.Location = new System.Drawing.Point(1026, 28);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(83, 47);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Sair";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSearch);
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(22, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1121, 100);
            this.panel3.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.Location = new System.Drawing.Point(622, 28);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(121, 47);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Pesquisar";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(222, 42);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(356, 21);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // frmSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 690);
            this.Controls.Add(this.tabSale);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmSale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venda";
            this.Load += new System.EventHandler(this.frmSale_Load);
            this.tabSale.ResumeLayout(false);
            this.tpConsult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgSale)).EndInit();
            this.tpDetails.ResumeLayout(false);
            this.tpDetails.PerformLayout();
            this.gbProduto.ResumeLayout(false);
            this.gbProduto.PerformLayout();
            this.gbClient.ResumeLayout(false);
            this.gbClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgShoppingCar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabSale;
        private System.Windows.Forms.TabPage tpConsult;
        public System.Windows.Forms.DataGridView dgSale;
        private System.Windows.Forms.TabPage tpDetails;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.RadioButton rbtnTerm;
        private System.Windows.Forms.RadioButton rbtnSport;
        public System.Windows.Forms.MaskedTextBox mtbAdditionCash;
        public System.Windows.Forms.Label lblAteracaoReal;
        public System.Windows.Forms.MaskedTextBox mtbAdditionPorcentage;
        public System.Windows.Forms.Label lblAteracoes;
        private System.Windows.Forms.Label lblVendedor;
        public System.Windows.Forms.ComboBox cbUsers;
        private System.Windows.Forms.Label lblQuantidadePrutudoQ;
        private System.Windows.Forms.Label lbTotalPodutos;
        public System.Windows.Forms.MaskedTextBox mtbCashDiscount;
        private System.Windows.Forms.Label lblDescontoReal;
        public System.Windows.Forms.MaskedTextBox mtbPorcentageDiscount;
        private System.Windows.Forms.Label lblDescontoPor100;
        public System.Windows.Forms.MaskedTextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        public System.Windows.Forms.MaskedTextBox mtbDate;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.GroupBox gbProduto;
        public System.Windows.Forms.TextBox txtSpotPrice;
        private System.Windows.Forms.Label lblPrecoVista;
        public System.Windows.Forms.TextBox txtTermPrice;
        private System.Windows.Forms.Label lblPrecoPrazo;
        public System.Windows.Forms.TextBox txtAmount;
        public System.Windows.Forms.TextBox txtShortDescription;
        public System.Windows.Forms.TextBox txtStock;
        public System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.Button btnSearchProduct;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblEstoque;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblDescriçãoResumida;
        private System.Windows.Forms.Label lblCodigoProduto;
        private System.Windows.Forms.GroupBox gbClient;
        public System.Windows.Forms.MaskedTextBox mtbPhone;
        public System.Windows.Forms.TextBox txtClientId;
        private System.Windows.Forms.Button btnPesquisarCliente;
        public System.Windows.Forms.Button btnSearchName;
        private System.Windows.Forms.Label lblFone;
        public System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblEndereco;
        public System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblNomeCon;
        public System.Windows.Forms.MaskedTextBox mtbCPF;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblID;
        public System.Windows.Forms.Button btnPagar;
        public System.Windows.Forms.DataGridView dgShoppingCar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
    }
}