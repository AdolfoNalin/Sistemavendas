namespace SistemaVenda.View
{
    partial class frmProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProduct));
            this.tabProduct = new System.Windows.Forms.TabControl();
            this.tpConsult = new System.Windows.Forms.TabPage();
            this.dgProduct = new System.Windows.Forms.DataGridView();
            this.tpDetails = new System.Windows.Forms.TabPage();
            this.lblUniMeasure = new System.Windows.Forms.Label();
            this.cbUniMeasure = new System.Windows.Forms.ComboBox();
            this.lblSuppliers = new System.Windows.Forms.Label();
            this.cbSuppliers = new System.Windows.Forms.ComboBox();
            this.mtbDate = new System.Windows.Forms.MaskedTextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtFullDescription = new System.Windows.Forms.TextBox();
            this.lblApelido = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.mtbTotalPrice = new System.Windows.Forms.MaskedTextBox();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.mtbEntryPrice = new System.Windows.Forms.MaskedTextBox();
            this.lblEntryPrice = new System.Windows.Forms.Label();
            this.mtbTermPrice = new System.Windows.Forms.MaskedTextBox();
            this.lblTermPrice = new System.Windows.Forms.Label();
            this.mtbCashPrice = new System.Windows.Forms.MaskedTextBox();
            this.txtShortDescription = new System.Windows.Forms.TextBox();
            this.lblCashPrice = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.tabProduct.SuspendLayout();
            this.tpConsult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProduct)).BeginInit();
            this.tpDetails.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabProduct
            // 
            this.tabProduct.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabProduct.Controls.Add(this.tpConsult);
            this.tabProduct.Controls.Add(this.tpDetails);
            this.tabProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabProduct.Location = new System.Drawing.Point(0, 100);
            this.tabProduct.Multiline = true;
            this.tabProduct.Name = "tabProduct";
            this.tabProduct.SelectedIndex = 0;
            this.tabProduct.Size = new System.Drawing.Size(1039, 278);
            this.tabProduct.TabIndex = 8;
            // 
            // tpConsult
            // 
            this.tpConsult.Controls.Add(this.dgProduct);
            this.tpConsult.Location = new System.Drawing.Point(23, 4);
            this.tpConsult.Name = "tpConsult";
            this.tpConsult.Padding = new System.Windows.Forms.Padding(3);
            this.tpConsult.Size = new System.Drawing.Size(1012, 270);
            this.tpConsult.TabIndex = 0;
            this.tpConsult.Text = "Consulta";
            this.tpConsult.UseVisualStyleBackColor = true;
            // 
            // dgProduct
            // 
            this.dgProduct.AllowUserToAddRows = false;
            this.dgProduct.AllowUserToDeleteRows = false;
            this.dgProduct.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgProduct.Location = new System.Drawing.Point(3, 3);
            this.dgProduct.Name = "dgProduct";
            this.dgProduct.ReadOnly = true;
            this.dgProduct.Size = new System.Drawing.Size(1006, 264);
            this.dgProduct.TabIndex = 0;
            this.dgProduct.SelectionChanged += new System.EventHandler(this.dgProduct_SelectionChanged);
            this.dgProduct.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgProduct_KeyDown);
            // 
            // tpDetails
            // 
            this.tpDetails.Controls.Add(this.lblUniMeasure);
            this.tpDetails.Controls.Add(this.cbUniMeasure);
            this.tpDetails.Controls.Add(this.lblSuppliers);
            this.tpDetails.Controls.Add(this.cbSuppliers);
            this.tpDetails.Controls.Add(this.mtbDate);
            this.tpDetails.Controls.Add(this.lblDate);
            this.tpDetails.Controls.Add(this.txtAmount);
            this.tpDetails.Controls.Add(this.lblAmount);
            this.tpDetails.Controls.Add(this.txtFullDescription);
            this.tpDetails.Controls.Add(this.lblApelido);
            this.tpDetails.Controls.Add(this.txtId);
            this.tpDetails.Controls.Add(this.lblCodigo);
            this.tpDetails.Controls.Add(this.mtbTotalPrice);
            this.tpDetails.Controls.Add(this.lblTotalPrice);
            this.tpDetails.Controls.Add(this.mtbEntryPrice);
            this.tpDetails.Controls.Add(this.lblEntryPrice);
            this.tpDetails.Controls.Add(this.mtbTermPrice);
            this.tpDetails.Controls.Add(this.lblTermPrice);
            this.tpDetails.Controls.Add(this.mtbCashPrice);
            this.tpDetails.Controls.Add(this.txtShortDescription);
            this.tpDetails.Controls.Add(this.lblCashPrice);
            this.tpDetails.Controls.Add(this.lblNome);
            this.tpDetails.Location = new System.Drawing.Point(23, 4);
            this.tpDetails.Name = "tpDetails";
            this.tpDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tpDetails.Size = new System.Drawing.Size(1012, 270);
            this.tpDetails.TabIndex = 1;
            this.tpDetails.Text = "Detalhes";
            this.tpDetails.UseVisualStyleBackColor = true;
            // 
            // lblUniMeasure
            // 
            this.lblUniMeasure.AutoSize = true;
            this.lblUniMeasure.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUniMeasure.Location = new System.Drawing.Point(704, 28);
            this.lblUniMeasure.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUniMeasure.Name = "lblUniMeasure";
            this.lblUniMeasure.Size = new System.Drawing.Size(84, 13);
            this.lblUniMeasure.TabIndex = 112;
            this.lblUniMeasure.Text = "Unidade Ven:";
            // 
            // cbUniMeasure
            // 
            this.cbUniMeasure.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cbUniMeasure.FormattingEnabled = true;
            this.cbUniMeasure.Items.AddRange(new object[] {
            "M³",
            "M²",
            "Linear",
            "Unidade",
            "Proção"});
            this.cbUniMeasure.Location = new System.Drawing.Point(789, 24);
            this.cbUniMeasure.Name = "cbUniMeasure";
            this.cbUniMeasure.Size = new System.Drawing.Size(107, 21);
            this.cbUniMeasure.TabIndex = 111;
            // 
            // lblSuppliers
            // 
            this.lblSuppliers.AutoSize = true;
            this.lblSuppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuppliers.Location = new System.Drawing.Point(405, 30);
            this.lblSuppliers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSuppliers.Name = "lblSuppliers";
            this.lblSuppliers.Size = new System.Drawing.Size(75, 13);
            this.lblSuppliers.TabIndex = 110;
            this.lblSuppliers.Text = "Fornecedor:";
            // 
            // cbSuppliers
            // 
            this.cbSuppliers.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cbSuppliers.FormattingEnabled = true;
            this.cbSuppliers.Location = new System.Drawing.Point(481, 26);
            this.cbSuppliers.Name = "cbSuppliers";
            this.cbSuppliers.Size = new System.Drawing.Size(193, 21);
            this.cbSuppliers.TabIndex = 109;
            // 
            // mtbDate
            // 
            this.mtbDate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mtbDate.Location = new System.Drawing.Point(295, 25);
            this.mtbDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mtbDate.Mask = "00/00/0000";
            this.mtbDate.Name = "mtbDate";
            this.mtbDate.Size = new System.Drawing.Size(71, 20);
            this.mtbDate.TabIndex = 108;
            this.mtbDate.ValidatingType = typeof(System.DateTime);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(255, 29);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(38, 13);
            this.lblDate.TabIndex = 107;
            this.lblDate.Text = "Data:";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(117, 160);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(50, 20);
            this.txtAmount.TabIndex = 106;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(41, 163);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(76, 13);
            this.lblAmount.TabIndex = 105;
            this.lblAmount.Text = "Quantidade:";
            // 
            // txtFullDescription
            // 
            this.txtFullDescription.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtFullDescription.Location = new System.Drawing.Point(536, 73);
            this.txtFullDescription.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFullDescription.Name = "txtFullDescription";
            this.txtFullDescription.Size = new System.Drawing.Size(277, 20);
            this.txtFullDescription.TabIndex = 104;
            // 
            // lblApelido
            // 
            this.lblApelido.AutoSize = true;
            this.lblApelido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApelido.Location = new System.Drawing.Point(432, 76);
            this.lblApelido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApelido.Name = "lblApelido";
            this.lblApelido.Size = new System.Drawing.Size(103, 13);
            this.lblApelido.TabIndex = 103;
            this.lblApelido.Text = "Descrição Comp:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(119, 25);
            this.txtId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(63, 20);
            this.txtId.TabIndex = 102;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(66, 28);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(50, 13);
            this.lblCodigo.TabIndex = 101;
            this.lblCodigo.Text = "Código:";
            // 
            // mtbTotalPrice
            // 
            this.mtbTotalPrice.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mtbTotalPrice.Location = new System.Drawing.Point(751, 116);
            this.mtbTotalPrice.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mtbTotalPrice.Name = "mtbTotalPrice";
            this.mtbTotalPrice.Size = new System.Drawing.Size(98, 20);
            this.mtbTotalPrice.TabIndex = 84;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(673, 119);
            this.lblTotalPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(77, 13);
            this.lblTotalPrice.TabIndex = 83;
            this.lblTotalPrice.Text = "Preço Total:";
            // 
            // mtbEntryPrice
            // 
            this.mtbEntryPrice.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mtbEntryPrice.Location = new System.Drawing.Point(551, 115);
            this.mtbEntryPrice.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mtbEntryPrice.Name = "mtbEntryPrice";
            this.mtbEntryPrice.Size = new System.Drawing.Size(98, 20);
            this.mtbEntryPrice.TabIndex = 82;
            // 
            // lblEntryPrice
            // 
            this.lblEntryPrice.AutoSize = true;
            this.lblEntryPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntryPrice.Location = new System.Drawing.Point(442, 118);
            this.lblEntryPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEntryPrice.Name = "lblEntryPrice";
            this.lblEntryPrice.Size = new System.Drawing.Size(110, 13);
            this.lblEntryPrice.TabIndex = 81;
            this.lblEntryPrice.Text = "Preço de Entrada:";
            // 
            // mtbTermPrice
            // 
            this.mtbTermPrice.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mtbTermPrice.Location = new System.Drawing.Point(332, 113);
            this.mtbTermPrice.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mtbTermPrice.Name = "mtbTermPrice";
            this.mtbTermPrice.Size = new System.Drawing.Size(87, 20);
            this.mtbTermPrice.TabIndex = 80;
            // 
            // lblTermPrice
            // 
            this.lblTermPrice.AutoSize = true;
            this.lblTermPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTermPrice.Location = new System.Drawing.Point(238, 116);
            this.lblTermPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTermPrice.Name = "lblTermPrice";
            this.lblTermPrice.Size = new System.Drawing.Size(91, 13);
            this.lblTermPrice.TabIndex = 79;
            this.lblTermPrice.Text = "Preço á Prazo:";
            // 
            // mtbCashPrice
            // 
            this.mtbCashPrice.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mtbCashPrice.Location = new System.Drawing.Point(117, 113);
            this.mtbCashPrice.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mtbCashPrice.Name = "mtbCashPrice";
            this.mtbCashPrice.Size = new System.Drawing.Size(98, 20);
            this.mtbCashPrice.TabIndex = 78;
            // 
            // txtShortDescription
            // 
            this.txtShortDescription.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtShortDescription.Location = new System.Drawing.Point(116, 72);
            this.txtShortDescription.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtShortDescription.Name = "txtShortDescription";
            this.txtShortDescription.Size = new System.Drawing.Size(277, 20);
            this.txtShortDescription.TabIndex = 77;
            this.txtShortDescription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtShortDescription_KeyPress);
            // 
            // lblCashPrice
            // 
            this.lblCashPrice.AutoSize = true;
            this.lblCashPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCashPrice.Location = new System.Drawing.Point(33, 116);
            this.lblCashPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCashPrice.Name = "lblCashPrice";
            this.lblCashPrice.Size = new System.Drawing.Size(86, 13);
            this.lblCashPrice.TabIndex = 76;
            this.lblCashPrice.Text = "Preço á vista:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(15, 73);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(101, 13);
            this.lblNome.TabIndex = 75;
            this.lblNome.Text = "Descrição Resu:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 378);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1039, 107);
            this.panel2.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnCancel);
            this.panel5.Controls.Add(this.btnSave);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(508, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(531, 107);
            this.panel5.TabIndex = 4;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.Red;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.Location = new System.Drawing.Point(355, 24);
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
            this.btnSave.Location = new System.Drawing.Point(106, 22);
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
            this.panel4.Size = new System.Drawing.Size(389, 107);
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
            this.panel1.Size = new System.Drawing.Size(1039, 100);
            this.panel1.TabIndex = 6;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.Location = new System.Drawing.Point(890, 28);
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
            this.panel3.Location = new System.Drawing.Point(-82, 0);
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
            // 
            // txtSearch
            // 
            this.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(222, 42);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(356, 21);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 485);
            this.Controls.Add(this.tabProduct);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produto";
            this.Load += new System.EventHandler(this.frmProduct_Load);
            this.tabProduct.ResumeLayout(false);
            this.tpConsult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgProduct)).EndInit();
            this.tpDetails.ResumeLayout(false);
            this.tpDetails.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabProduct;
        private System.Windows.Forms.TabPage tpConsult;
        public System.Windows.Forms.DataGridView dgProduct;
        private System.Windows.Forms.TabPage tpDetails;
        public System.Windows.Forms.TextBox txtFullDescription;
        private System.Windows.Forms.Label lblApelido;
        public System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblCodigo;
        public System.Windows.Forms.MaskedTextBox mtbTotalPrice;
        private System.Windows.Forms.Label lblTotalPrice;
        public System.Windows.Forms.MaskedTextBox mtbEntryPrice;
        private System.Windows.Forms.Label lblEntryPrice;
        public System.Windows.Forms.MaskedTextBox mtbTermPrice;
        private System.Windows.Forms.Label lblTermPrice;
        public System.Windows.Forms.MaskedTextBox mtbCashPrice;
        public System.Windows.Forms.TextBox txtShortDescription;
        private System.Windows.Forms.Label lblCashPrice;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        public System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblAmount;
        public System.Windows.Forms.MaskedTextBox mtbDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblSuppliers;
        private System.Windows.Forms.ComboBox cbSuppliers;
        private System.Windows.Forms.Label lblUniMeasure;
        private System.Windows.Forms.ComboBox cbUniMeasure;
        public System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.Button btnNew;
    }
}