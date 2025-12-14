namespace SistemaVenda.View
{
    partial class frmCashSession
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCashSession));
            this.tabCashDesck = new System.Windows.Forms.TabControl();
            this.tpConsult = new System.Windows.Forms.TabPage();
            this.dgCashSession = new System.Windows.Forms.DataGridView();
            this.tpDetails = new System.Windows.Forms.TabPage();
            this.cbEnabel = new System.Windows.Forms.ComboBox();
            this.lblEnabel = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblEntryValue = new System.Windows.Forms.Label();
            this.txtEntryValue = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.mtbDate = new System.Windows.Forms.MaskedTextBox();
            this.cbUser = new System.Windows.Forms.ComboBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dgSale = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnDetails = new System.Windows.Forms.Button();
            this.btnEnable = new System.Windows.Forms.Button();
            this.btnAddCash = new System.Windows.Forms.Button();
            this.btnCashout = new System.Windows.Forms.Button();
            this.btnCloseCash = new System.Windows.Forms.Button();
            this.btnOpenCashSession = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbEndDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.btnSearchDate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.rbDisabel = new System.Windows.Forms.RadioButton();
            this.rbEnable = new System.Windows.Forms.RadioButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.tabCashDesck.SuspendLayout();
            this.tpConsult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCashSession)).BeginInit();
            this.tpDetails.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSale)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCashDesck
            // 
            this.tabCashDesck.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabCashDesck.Controls.Add(this.tpConsult);
            this.tabCashDesck.Controls.Add(this.tpDetails);
            this.tabCashDesck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCashDesck.Location = new System.Drawing.Point(0, 100);
            this.tabCashDesck.Multiline = true;
            this.tabCashDesck.Name = "tabCashDesck";
            this.tabCashDesck.SelectedIndex = 0;
            this.tabCashDesck.Size = new System.Drawing.Size(1191, 412);
            this.tabCashDesck.TabIndex = 5;
            // 
            // tpConsult
            // 
            this.tpConsult.Controls.Add(this.dgCashSession);
            this.tpConsult.Location = new System.Drawing.Point(23, 4);
            this.tpConsult.Name = "tpConsult";
            this.tpConsult.Padding = new System.Windows.Forms.Padding(3);
            this.tpConsult.Size = new System.Drawing.Size(1164, 404);
            this.tpConsult.TabIndex = 0;
            this.tpConsult.Text = "Consulta";
            this.tpConsult.UseVisualStyleBackColor = true;
            // 
            // dgCashSession
            // 
            this.dgCashSession.AllowUserToAddRows = false;
            this.dgCashSession.AllowUserToDeleteRows = false;
            this.dgCashSession.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgCashSession.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCashSession.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgCashSession.Location = new System.Drawing.Point(3, 3);
            this.dgCashSession.Name = "dgCashSession";
            this.dgCashSession.ReadOnly = true;
            this.dgCashSession.Size = new System.Drawing.Size(1158, 398);
            this.dgCashSession.TabIndex = 0;
            this.dgCashSession.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgCashSession_KeyDown);
            // 
            // tpDetails
            // 
            this.tpDetails.Controls.Add(this.cbEnabel);
            this.tpDetails.Controls.Add(this.lblEnabel);
            this.tpDetails.Controls.Add(this.lblId);
            this.tpDetails.Controls.Add(this.txtId);
            this.tpDetails.Controls.Add(this.cbStatus);
            this.tpDetails.Controls.Add(this.lblStatus);
            this.tpDetails.Controls.Add(this.lblEntryValue);
            this.tpDetails.Controls.Add(this.txtEntryValue);
            this.tpDetails.Controls.Add(this.lblDate);
            this.tpDetails.Controls.Add(this.mtbDate);
            this.tpDetails.Controls.Add(this.cbUser);
            this.tpDetails.Controls.Add(this.lblUser);
            this.tpDetails.Controls.Add(this.lblTotal);
            this.tpDetails.Controls.Add(this.txtTotal);
            this.tpDetails.Controls.Add(this.panel6);
            this.tpDetails.Location = new System.Drawing.Point(23, 4);
            this.tpDetails.Name = "tpDetails";
            this.tpDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tpDetails.Size = new System.Drawing.Size(1164, 404);
            this.tpDetails.TabIndex = 1;
            this.tpDetails.Text = "Detalhes";
            this.tpDetails.UseVisualStyleBackColor = true;
            // 
            // cbEnabel
            // 
            this.cbEnabel.FormattingEnabled = true;
            this.cbEnabel.Items.AddRange(new object[] {
            "Habilitado",
            "Desabilitado"});
            this.cbEnabel.Location = new System.Drawing.Point(92, 247);
            this.cbEnabel.Name = "cbEnabel";
            this.cbEnabel.Size = new System.Drawing.Size(104, 21);
            this.cbEnabel.TabIndex = 15;
            // 
            // lblEnabel
            // 
            this.lblEnabel.AutoSize = true;
            this.lblEnabel.Location = new System.Drawing.Point(35, 250);
            this.lblEnabel.Name = "lblEnabel";
            this.lblEnabel.Size = new System.Drawing.Size(57, 13);
            this.lblEnabel.TabIndex = 14;
            this.lblEnabel.Text = "Habilitado:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(52, 38);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(43, 13);
            this.lblId.TabIndex = 13;
            this.lblId.Text = "Código:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(96, 35);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 12;
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Aberto",
            "Fechado"});
            this.cbStatus.Location = new System.Drawing.Point(92, 209);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(104, 21);
            this.cbStatus.TabIndex = 11;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(49, 212);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "Status:";
            // 
            // lblEntryValue
            // 
            this.lblEntryValue.AutoSize = true;
            this.lblEntryValue.Location = new System.Drawing.Point(21, 148);
            this.lblEntryValue.Name = "lblEntryValue";
            this.lblEntryValue.Size = new System.Drawing.Size(74, 13);
            this.lblEntryValue.TabIndex = 9;
            this.lblEntryValue.Text = "Valor Entrada:";
            // 
            // txtEntryValue
            // 
            this.txtEntryValue.Location = new System.Drawing.Point(96, 144);
            this.txtEntryValue.Name = "txtEntryValue";
            this.txtEntryValue.Size = new System.Drawing.Size(100, 20);
            this.txtEntryValue.TabIndex = 8;
            this.txtEntryValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEntryValue_KeyDown);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(347, 35);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(33, 13);
            this.lblDate.TabIndex = 7;
            this.lblDate.Text = "Data:";
            // 
            // mtbDate
            // 
            this.mtbDate.Location = new System.Drawing.Point(382, 32);
            this.mtbDate.Mask = "00/00/0000";
            this.mtbDate.Name = "mtbDate";
            this.mtbDate.Size = new System.Drawing.Size(66, 20);
            this.mtbDate.TabIndex = 6;
            this.mtbDate.ValidatingType = typeof(System.DateTime);
            // 
            // cbUser
            // 
            this.cbUser.FormattingEnabled = true;
            this.cbUser.Location = new System.Drawing.Point(96, 88);
            this.cbUser.Name = "cbUser";
            this.cbUser.Size = new System.Drawing.Size(176, 21);
            this.cbUser.TabIndex = 5;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(49, 91);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(46, 13);
            this.lblUser.TabIndex = 4;
            this.lblUser.Text = "Usuário:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(433, 340);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Total:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(472, 336);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dgSale);
            this.panel6.Location = new System.Drawing.Point(472, 32);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(614, 287);
            this.panel6.TabIndex = 0;
            // 
            // dgSale
            // 
            this.dgSale.AllowUserToAddRows = false;
            this.dgSale.AllowUserToDeleteRows = false;
            this.dgSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgSale.Location = new System.Drawing.Point(0, 0);
            this.dgSale.Name = "dgSale";
            this.dgSale.ReadOnly = true;
            this.dgSale.Size = new System.Drawing.Size(614, 287);
            this.dgSale.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 512);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1191, 100);
            this.panel2.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnCancel);
            this.panel5.Controls.Add(this.btnSave);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(832, 0);
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
            this.panel4.Controls.Add(this.btnDetails);
            this.panel4.Controls.Add(this.btnEnable);
            this.panel4.Controls.Add(this.btnAddCash);
            this.panel4.Controls.Add(this.btnCashout);
            this.panel4.Controls.Add(this.btnCloseCash);
            this.panel4.Controls.Add(this.btnOpenCashSession);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(704, 100);
            this.panel4.TabIndex = 0;
            // 
            // btnDetails
            // 
            this.btnDetails.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnDetails.Image = ((System.Drawing.Image)(resources.GetObject("btnDetails.Image")));
            this.btnDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDetails.Location = new System.Drawing.Point(365, 24);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(115, 50);
            this.btnDetails.TabIndex = 6;
            this.btnDetails.Text = "Detalhes";
            this.btnDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // btnEnable
            // 
            this.btnEnable.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnEnable.Image = ((System.Drawing.Image)(resources.GetObject("btnEnable.Image")));
            this.btnEnable.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEnable.Location = new System.Drawing.Point(242, 24);
            this.btnEnable.Name = "btnEnable";
            this.btnEnable.Size = new System.Drawing.Size(115, 50);
            this.btnEnable.TabIndex = 5;
            this.btnEnable.Text = "Desativar";
            this.btnEnable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnable.UseVisualStyleBackColor = true;
            this.btnEnable.Click += new System.EventHandler(this.btnEnable_Click);
            // 
            // btnAddCash
            // 
            this.btnAddCash.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAddCash.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCash.Image")));
            this.btnAddCash.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddCash.Location = new System.Drawing.Point(576, 24);
            this.btnAddCash.Name = "btnAddCash";
            this.btnAddCash.Size = new System.Drawing.Size(100, 50);
            this.btnAddCash.TabIndex = 4;
            this.btnAddCash.Text = "Add ao Caixa";
            this.btnAddCash.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCash.UseVisualStyleBackColor = true;
            this.btnAddCash.Click += new System.EventHandler(this.btnAddCash_Click);
            // 
            // btnCashout
            // 
            this.btnCashout.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCashout.Image = ((System.Drawing.Image)(resources.GetObject("btnCashout.Image")));
            this.btnCashout.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCashout.Location = new System.Drawing.Point(487, 24);
            this.btnCashout.Name = "btnCashout";
            this.btnCashout.Size = new System.Drawing.Size(83, 50);
            this.btnCashout.TabIndex = 3;
            this.btnCashout.Text = "Saque";
            this.btnCashout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCashout.UseVisualStyleBackColor = true;
            this.btnCashout.Click += new System.EventHandler(this.btnCashout_Click);
            // 
            // btnCloseCash
            // 
            this.btnCloseCash.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCloseCash.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseCash.Image")));
            this.btnCloseCash.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCloseCash.Location = new System.Drawing.Point(136, 24);
            this.btnCloseCash.Name = "btnCloseCash";
            this.btnCloseCash.Size = new System.Drawing.Size(100, 50);
            this.btnCloseCash.TabIndex = 2;
            this.btnCloseCash.Text = "Fechar Caixa";
            this.btnCloseCash.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloseCash.UseVisualStyleBackColor = true;
            this.btnCloseCash.Click += new System.EventHandler(this.btnCloseCash_Click);
            // 
            // btnOpenCashSession
            // 
            this.btnOpenCashSession.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnOpenCashSession.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenCashSession.Image")));
            this.btnOpenCashSession.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOpenCashSession.Location = new System.Drawing.Point(20, 24);
            this.btnOpenCashSession.Name = "btnOpenCashSession";
            this.btnOpenCashSession.Size = new System.Drawing.Size(100, 50);
            this.btnOpenCashSession.TabIndex = 1;
            this.btnOpenCashSession.Text = "Abrir";
            this.btnOpenCashSession.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenCashSession.UseVisualStyleBackColor = true;
            this.btnOpenCashSession.Click += new System.EventHandler(this.btnOpenCashSession_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1191, 100);
            this.panel1.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbEndDate);
            this.panel3.Controls.Add(this.lblStartDate);
            this.panel3.Controls.Add(this.btnSearchDate);
            this.panel3.Controls.Add(this.btnExit);
            this.panel3.Controls.Add(this.dtpEndDate);
            this.panel3.Controls.Add(this.dtpStartDate);
            this.panel3.Controls.Add(this.rbAll);
            this.panel3.Controls.Add(this.rbDisabel);
            this.panel3.Controls.Add(this.rbEnable);
            this.panel3.Controls.Add(this.btnSearch);
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(70, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1121, 100);
            this.panel3.TabIndex = 4;
            // 
            // lbEndDate
            // 
            this.lbEndDate.AutoSize = true;
            this.lbEndDate.Location = new System.Drawing.Point(778, 58);
            this.lbEndDate.Name = "lbEndDate";
            this.lbEndDate.Size = new System.Drawing.Size(26, 13);
            this.lbEndDate.TabIndex = 12;
            this.lbEndDate.Text = "Fim:";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(769, 28);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(35, 13);
            this.lblStartDate.TabIndex = 11;
            this.lblStartDate.Text = "Inicio:";
            // 
            // btnSearchDate
            // 
            this.btnSearchDate.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchDate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearchDate.Location = new System.Drawing.Point(922, 30);
            this.btnSearchDate.Name = "btnSearchDate";
            this.btnSearchDate.Size = new System.Drawing.Size(71, 40);
            this.btnSearchDate.TabIndex = 10;
            this.btnSearchDate.Text = "Pesquisar";
            this.btnSearchDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchDate.UseVisualStyleBackColor = true;
            this.btnSearchDate.Click += new System.EventHandler(this.btnSearchDate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.Location = new System.Drawing.Point(1017, 28);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(83, 47);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Sair";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CustomFormat = "yyyy/MM/dd";
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(807, 54);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(97, 20);
            this.dtpEndDate.TabIndex = 9;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CustomFormat = "yyyy/MM/dd";
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(807, 24);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(97, 20);
            this.dtpStartDate.TabIndex = 8;
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Location = new System.Drawing.Point(88, 58);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(55, 17);
            this.rbAll.TabIndex = 7;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "Todos";
            this.rbAll.UseVisualStyleBackColor = true;
            this.rbAll.CheckedChanged += new System.EventHandler(this.rbAll_CheckedChanged);
            // 
            // rbDisabel
            // 
            this.rbDisabel.AutoSize = true;
            this.rbDisabel.Location = new System.Drawing.Point(88, 35);
            this.rbDisabel.Name = "rbDisabel";
            this.rbDisabel.Size = new System.Drawing.Size(84, 17);
            this.rbDisabel.TabIndex = 6;
            this.rbDisabel.TabStop = true;
            this.rbDisabel.Text = "Desativados";
            this.rbDisabel.UseVisualStyleBackColor = true;
            this.rbDisabel.CheckedChanged += new System.EventHandler(this.rbDisabel_CheckedChanged);
            // 
            // rbEnable
            // 
            this.rbEnable.AutoSize = true;
            this.rbEnable.Location = new System.Drawing.Point(88, 12);
            this.rbEnable.Name = "rbEnable";
            this.rbEnable.Size = new System.Drawing.Size(54, 17);
            this.rbEnable.TabIndex = 5;
            this.rbEnable.TabStop = true;
            this.rbEnable.Text = "Ativos";
            this.rbEnable.UseVisualStyleBackColor = true;
            this.rbEnable.CheckedChanged += new System.EventHandler(this.rbEnable_CheckedChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.Location = new System.Drawing.Point(610, 30);
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
            this.txtSearch.Size = new System.Drawing.Size(366, 21);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // frmCashSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 612);
            this.Controls.Add(this.tabCashDesck);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmCashSession";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caixa";
            this.Load += new System.EventHandler(this.frmCashSession_Load);
            this.tabCashDesck.ResumeLayout(false);
            this.tpConsult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgCashSession)).EndInit();
            this.tpDetails.ResumeLayout(false);
            this.tpDetails.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgSale)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCashDesck;
        private System.Windows.Forms.TabPage tpConsult;
        public System.Windows.Forms.DataGridView dgCashSession;
        private System.Windows.Forms.TabPage tpDetails;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnCashout;
        private System.Windows.Forms.Button btnCloseCash;
        private System.Windows.Forms.Button btnOpenCashSession;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnAddCash;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dgSale;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.MaskedTextBox mtbDate;
        private System.Windows.Forms.ComboBox cbUser;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblEntryValue;
        private System.Windows.Forms.TextBox txtEntryValue;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.RadioButton rbDisabel;
        private System.Windows.Forms.RadioButton rbEnable;
        private System.Windows.Forms.ComboBox cbEnabel;
        private System.Windows.Forms.Label lblEnabel;
        private System.Windows.Forms.Button btnEnable;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.Button btnSearchDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lbEndDate;
        private System.Windows.Forms.Label lblStartDate;
    }
}