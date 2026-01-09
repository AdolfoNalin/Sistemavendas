namespace SistemaVenda.br.pro.com.view
{
    partial class frmBudget
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBudget));
            this.tabBudget = new System.Windows.Forms.TabControl();
            this.tpConsult = new System.Windows.Forms.TabPage();
            this.dgBudget = new System.Windows.Forms.DataGridView();
            this.tpDetails = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnConsultClient = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.rbTerm = new System.Windows.Forms.RadioButton();
            this.rbCash = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.txtClientId = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.mtbDate = new System.Windows.Forms.MaskedTextBox();
            this.gbDetalhesPagamento = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.MaskedTextBox();
            this.mtbAdditionPorcentage = new System.Windows.Forms.MaskedTextBox();
            this.lblAgressimo = new System.Windows.Forms.Label();
            this.mtbAdditionCash = new System.Windows.Forms.MaskedTextBox();
            this.mtbPercentageDiscount = new System.Windows.Forms.MaskedTextBox();
            this.lblDesconto = new System.Windows.Forms.Label();
            this.mtbCashDiscount = new System.Windows.Forms.MaskedTextBox();
            this.dgShoppingCar = new System.Windows.Forms.DataGridView();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.lblObs = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbEndDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.btnSearchDate = new System.Windows.Forms.Button();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
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
            this.tabBudget.SuspendLayout();
            this.tpConsult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBudget)).BeginInit();
            this.tpDetails.SuspendLayout();
            this.gbDetalhesPagamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgShoppingCar)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.gbProduto.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabBudget
            // 
            this.tabBudget.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabBudget.Controls.Add(this.tpConsult);
            this.tabBudget.Controls.Add(this.tpDetails);
            this.tabBudget.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabBudget.Location = new System.Drawing.Point(0, 100);
            this.tabBudget.Multiline = true;
            this.tabBudget.Name = "tabBudget";
            this.tabBudget.SelectedIndex = 0;
            this.tabBudget.Size = new System.Drawing.Size(1170, 480);
            this.tabBudget.TabIndex = 8;
            // 
            // tpConsult
            // 
            this.tpConsult.Controls.Add(this.dgBudget);
            this.tpConsult.Location = new System.Drawing.Point(23, 4);
            this.tpConsult.Name = "tpConsult";
            this.tpConsult.Padding = new System.Windows.Forms.Padding(3);
            this.tpConsult.Size = new System.Drawing.Size(1143, 472);
            this.tpConsult.TabIndex = 0;
            this.tpConsult.Text = "Consulta";
            this.tpConsult.UseVisualStyleBackColor = true;
            // 
            // dgBudget
            // 
            this.dgBudget.AllowUserToAddRows = false;
            this.dgBudget.AllowUserToDeleteRows = false;
            this.dgBudget.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgBudget.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBudget.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgBudget.Location = new System.Drawing.Point(3, 3);
            this.dgBudget.Name = "dgBudget";
            this.dgBudget.ReadOnly = true;
            this.dgBudget.Size = new System.Drawing.Size(1137, 466);
            this.dgBudget.TabIndex = 0;
            this.dgBudget.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgBudget_KeyDown);
            // 
            // tpDetails
            // 
            this.tpDetails.Controls.Add(this.gbProduto);
            this.tpDetails.Controls.Add(this.label5);
            this.tpDetails.Controls.Add(this.txtId);
            this.tpDetails.Controls.Add(this.btnConsultClient);
            this.tpDetails.Controls.Add(this.txtName);
            this.tpDetails.Controls.Add(this.rbTerm);
            this.tpDetails.Controls.Add(this.rbCash);
            this.tpDetails.Controls.Add(this.label9);
            this.tpDetails.Controls.Add(this.txtClientId);
            this.tpDetails.Controls.Add(this.lblData);
            this.tpDetails.Controls.Add(this.mtbDate);
            this.tpDetails.Controls.Add(this.gbDetalhesPagamento);
            this.tpDetails.Controls.Add(this.dgShoppingCar);
            this.tpDetails.Controls.Add(this.txtObs);
            this.tpDetails.Controls.Add(this.lblObs);
            this.tpDetails.Controls.Add(this.lblCliente);
            this.tpDetails.Location = new System.Drawing.Point(23, 4);
            this.tpDetails.Name = "tpDetails";
            this.tpDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tpDetails.Size = new System.Drawing.Size(1143, 472);
            this.tpDetails.TabIndex = 1;
            this.tpDetails.Text = "Detalhes";
            this.tpDetails.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 73;
            this.label5.Text = "Código:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(78, 17);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(47, 20);
            this.txtId.TabIndex = 72;
            // 
            // btnConsultClient
            // 
            this.btnConsultClient.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnConsultClient.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultClient.Image")));
            this.btnConsultClient.Location = new System.Drawing.Point(467, 16);
            this.btnConsultClient.Name = "btnConsultClient";
            this.btnConsultClient.Size = new System.Drawing.Size(36, 32);
            this.btnConsultClient.TabIndex = 6;
            this.btnConsultClient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultClient.UseVisualStyleBackColor = true;
            this.btnConsultClient.Click += new System.EventHandler(this.btnConsultClient_Click);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtName.Location = new System.Drawing.Point(230, 22);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(231, 20);
            this.txtName.TabIndex = 71;
            // 
            // rbTerm
            // 
            this.rbTerm.AutoSize = true;
            this.rbTerm.Location = new System.Drawing.Point(768, 46);
            this.rbTerm.Name = "rbTerm";
            this.rbTerm.Size = new System.Drawing.Size(61, 17);
            this.rbTerm.TabIndex = 70;
            this.rbTerm.TabStop = true;
            this.rbTerm.Text = "Á prazo";
            this.rbTerm.UseVisualStyleBackColor = true;
            this.rbTerm.CheckedChanged += new System.EventHandler(this.rbTerm_CheckedChanged);
            // 
            // rbCash
            // 
            this.rbCash.AutoSize = true;
            this.rbCash.Location = new System.Drawing.Point(768, 21);
            this.rbCash.Name = "rbCash";
            this.rbCash.Size = new System.Drawing.Size(57, 17);
            this.rbCash.TabIndex = 69;
            this.rbCash.TabStop = true;
            this.rbCash.Text = "Á vista";
            this.rbCash.UseVisualStyleBackColor = true;
            this.rbCash.CheckedChanged += new System.EventHandler(this.rbCash_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(541, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 68;
            this.label9.Text = "Código:";
            // 
            // txtClientId
            // 
            this.txtClientId.Location = new System.Drawing.Point(593, 20);
            this.txtClientId.Name = "txtClientId";
            this.txtClientId.Size = new System.Drawing.Size(47, 20);
            this.txtClientId.TabIndex = 67;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(879, 27);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(33, 13);
            this.lblData.TabIndex = 57;
            this.lblData.Text = "Data:";
            // 
            // mtbDate
            // 
            this.mtbDate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mtbDate.Location = new System.Drawing.Point(911, 23);
            this.mtbDate.Mask = "99/99/9999";
            this.mtbDate.Name = "mtbDate";
            this.mtbDate.Size = new System.Drawing.Size(69, 20);
            this.mtbDate.TabIndex = 56;
            // 
            // gbDetalhesPagamento
            // 
            this.gbDetalhesPagamento.Controls.Add(this.label4);
            this.gbDetalhesPagamento.Controls.Add(this.label3);
            this.gbDetalhesPagamento.Controls.Add(this.label2);
            this.gbDetalhesPagamento.Controls.Add(this.label1);
            this.gbDetalhesPagamento.Controls.Add(this.lblTotal);
            this.gbDetalhesPagamento.Controls.Add(this.txtTotal);
            this.gbDetalhesPagamento.Controls.Add(this.mtbAdditionPorcentage);
            this.gbDetalhesPagamento.Controls.Add(this.lblAgressimo);
            this.gbDetalhesPagamento.Controls.Add(this.mtbAdditionCash);
            this.gbDetalhesPagamento.Controls.Add(this.mtbPercentageDiscount);
            this.gbDetalhesPagamento.Controls.Add(this.lblDesconto);
            this.gbDetalhesPagamento.Controls.Add(this.mtbCashDiscount);
            this.gbDetalhesPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetalhesPagamento.ForeColor = System.Drawing.SystemColors.Highlight;
            this.gbDetalhesPagamento.Location = new System.Drawing.Point(215, 325);
            this.gbDetalhesPagamento.Name = "gbDetalhesPagamento";
            this.gbDetalhesPagamento.Size = new System.Drawing.Size(208, 124);
            this.gbDetalhesPagamento.TabIndex = 50;
            this.gbDetalhesPagamento.TabStop = false;
            this.gbDetalhesPagamento.Text = "Detalhes Pagamento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(133, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(132, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "R$";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "R$";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(92, 89);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(40, 13);
            this.lblTotal.TabIndex = 21;
            this.lblTotal.Text = "Total:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(133, 86);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(57, 20);
            this.txtTotal.TabIndex = 20;
            // 
            // mtbAdditionPorcentage
            // 
            this.mtbAdditionPorcentage.Location = new System.Drawing.Point(150, 49);
            this.mtbAdditionPorcentage.Name = "mtbAdditionPorcentage";
            this.mtbAdditionPorcentage.Size = new System.Drawing.Size(40, 20);
            this.mtbAdditionPorcentage.TabIndex = 15;
            this.mtbAdditionPorcentage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtbAP_KeyDown);
            // 
            // lblAgressimo
            // 
            this.lblAgressimo.AutoSize = true;
            this.lblAgressimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgressimo.Location = new System.Drawing.Point(18, 52);
            this.lblAgressimo.Name = "lblAgressimo";
            this.lblAgressimo.Size = new System.Drawing.Size(40, 13);
            this.lblAgressimo.TabIndex = 14;
            this.lblAgressimo.Text = "Frete:";
            // 
            // mtbAdditionCash
            // 
            this.mtbAdditionCash.Location = new System.Drawing.Point(86, 49);
            this.mtbAdditionCash.Name = "mtbAdditionCash";
            this.mtbAdditionCash.Size = new System.Drawing.Size(40, 20);
            this.mtbAdditionCash.TabIndex = 13;
            this.mtbAdditionCash.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtbAD_KeyDown);
            // 
            // mtbPercentageDiscount
            // 
            this.mtbPercentageDiscount.Location = new System.Drawing.Point(150, 20);
            this.mtbPercentageDiscount.Name = "mtbPercentageDiscount";
            this.mtbPercentageDiscount.Size = new System.Drawing.Size(40, 20);
            this.mtbPercentageDiscount.TabIndex = 12;
            this.mtbPercentageDiscount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtbDP_KeyDown);
            // 
            // lblDesconto
            // 
            this.lblDesconto.AutoSize = true;
            this.lblDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesconto.Location = new System.Drawing.Point(6, 23);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(65, 13);
            this.lblDesconto.TabIndex = 11;
            this.lblDesconto.Text = "Desconto:";
            // 
            // mtbCashDiscount
            // 
            this.mtbCashDiscount.Location = new System.Drawing.Point(86, 19);
            this.mtbCashDiscount.Name = "mtbCashDiscount";
            this.mtbCashDiscount.Size = new System.Drawing.Size(40, 20);
            this.mtbCashDiscount.TabIndex = 0;
            this.mtbCashDiscount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtbDD_KeyDown);
            // 
            // dgShoppingCar
            // 
            this.dgShoppingCar.AllowUserToAddRows = false;
            this.dgShoppingCar.AllowUserToDeleteRows = false;
            this.dgShoppingCar.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgShoppingCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgShoppingCar.Location = new System.Drawing.Point(429, 107);
            this.dgShoppingCar.Name = "dgShoppingCar";
            this.dgShoppingCar.ReadOnly = true;
            this.dgShoppingCar.Size = new System.Drawing.Size(551, 195);
            this.dgShoppingCar.TabIndex = 49;
            this.dgShoppingCar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgShoppingCar_KeyDown);
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(619, 342);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(361, 88);
            this.txtObs.TabIndex = 48;
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObs.Location = new System.Drawing.Point(587, 342);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(33, 13);
            this.lblObs.TabIndex = 47;
            this.lblObs.Text = "Obs:";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(181, 23);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(50, 13);
            this.lblCliente.TabIndex = 45;
            this.lblCliente.Text = "Cliente:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 580);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1170, 100);
            this.panel2.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnCancel);
            this.panel5.Controls.Add(this.btnSave);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(811, 0);
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
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Location = new System.Drawing.Point(20, 24);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 50);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Salvar";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.btnDelete.Location = new System.Drawing.Point(135, 22);
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
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1170, 100);
            this.panel1.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbEndDate);
            this.panel3.Controls.Add(this.lblStartDate);
            this.panel3.Controls.Add(this.btnSearchDate);
            this.panel3.Controls.Add(this.dtpEndDate);
            this.panel3.Controls.Add(this.dtpStartDate);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.btnExit);
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(49, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1121, 100);
            this.panel3.TabIndex = 4;
            // 
            // lbEndDate
            // 
            this.lbEndDate.AutoSize = true;
            this.lbEndDate.Location = new System.Drawing.Point(737, 60);
            this.lbEndDate.Name = "lbEndDate";
            this.lbEndDate.Size = new System.Drawing.Size(26, 13);
            this.lbEndDate.TabIndex = 81;
            this.lbEndDate.Text = "Fim:";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(728, 30);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(35, 13);
            this.lblStartDate.TabIndex = 80;
            this.lblStartDate.Text = "Inicio:";
            // 
            // btnSearchDate
            // 
            this.btnSearchDate.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchDate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearchDate.Location = new System.Drawing.Point(881, 32);
            this.btnSearchDate.Name = "btnSearchDate";
            this.btnSearchDate.Size = new System.Drawing.Size(71, 40);
            this.btnSearchDate.TabIndex = 79;
            this.btnSearchDate.Text = "Pesquisar";
            this.btnSearchDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchDate.UseVisualStyleBackColor = true;
            this.btnSearchDate.Click += new System.EventHandler(this.btnSearchDate_Click);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CustomFormat = "yyyy/MM/dd";
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(766, 56);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(97, 20);
            this.dtpEndDate.TabIndex = 78;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CustomFormat = "yyyy/MM/dd";
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(766, 26);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(97, 20);
            this.dtpStartDate.TabIndex = 77;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(281, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 76;
            this.label6.Text = "Pesquisa:";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.Location = new System.Drawing.Point(977, 28);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(83, 47);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Sair";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(357, 40);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(356, 21);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
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
            this.gbProduto.Location = new System.Drawing.Point(51, 107);
            this.gbProduto.Name = "gbProduto";
            this.gbProduto.Size = new System.Drawing.Size(372, 157);
            this.gbProduto.TabIndex = 74;
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
            // 
            // txtShortDescription
            // 
            this.txtShortDescription.Location = new System.Drawing.Point(49, 43);
            this.txtShortDescription.Name = "txtShortDescription";
            this.txtShortDescription.Size = new System.Drawing.Size(240, 20);
            this.txtShortDescription.TabIndex = 33;
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
            this.btnSearchProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchProduct.Image")));
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
            // frmBudget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 680);
            this.Controls.Add(this.tabBudget);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmBudget";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orçamento";
            this.Load += new System.EventHandler(this.frmBudget_Load);
            this.tabBudget.ResumeLayout(false);
            this.tpConsult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgBudget)).EndInit();
            this.tpDetails.ResumeLayout(false);
            this.tpDetails.PerformLayout();
            this.gbDetalhesPagamento.ResumeLayout(false);
            this.gbDetalhesPagamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgShoppingCar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.gbProduto.ResumeLayout(false);
            this.gbProduto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabBudget;
        private System.Windows.Forms.TabPage tpConsult;
        private System.Windows.Forms.DataGridView dgBudget;
        private System.Windows.Forms.TabPage tpDetails;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.RadioButton rbTerm;
        private System.Windows.Forms.RadioButton rbCash;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtClientId;
        private System.Windows.Forms.Label lblData;
        public System.Windows.Forms.MaskedTextBox mtbDate;
        public System.Windows.Forms.GroupBox gbDetalhesPagamento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotal;
        public System.Windows.Forms.MaskedTextBox txtTotal;
        public System.Windows.Forms.MaskedTextBox mtbAdditionPorcentage;
        private System.Windows.Forms.Label lblAgressimo;
        public System.Windows.Forms.MaskedTextBox mtbAdditionCash;
        public System.Windows.Forms.MaskedTextBox mtbPercentageDiscount;
        private System.Windows.Forms.Label lblDesconto;
        public System.Windows.Forms.MaskedTextBox mtbCashDiscount;
        public System.Windows.Forms.DataGridView dgShoppingCar;
        public System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Button btnConsultClient;
        public System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Button btnSearchDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
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
    }
}