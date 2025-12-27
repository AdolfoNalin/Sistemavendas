namespace SistemaVenda.br.pro.com.view
{
    partial class frmClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClient));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.tabClient = new System.Windows.Forms.TabControl();
            this.tpConsult = new System.Windows.Forms.TabPage();
            this.dgClient = new System.Windows.Forms.DataGridView();
            this.tpDetails = new System.Windows.Forms.TabPage();
            this.mtbDueDate = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.txtApelido = new System.Windows.Forms.TextBox();
            this.lblApelido = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.mtbCEP = new System.Windows.Forms.MaskedTextBox();
            this.lblCEP = new System.Windows.Forms.Label();
            this.cbUF = new System.Windows.Forms.ComboBox();
            this.lblUF = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.lblLogradouro = new System.Windows.Forms.Label();
            this.lblEstadoCivil = new System.Windows.Forms.Label();
            this.cbEstadoCivil = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.mtbCelular = new System.Windows.Forms.MaskedTextBox();
            this.lblCelular = new System.Windows.Forms.Label();
            this.mtbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.mtbRG = new System.Windows.Forms.MaskedTextBox();
            this.lblRG = new System.Windows.Forms.Label();
            this.mtbCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tabClient.SuspendLayout();
            this.tpConsult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgClient)).BeginInit();
            this.tpDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1121, 100);
            this.panel1.TabIndex = 0;
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
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1121, 100);
            this.panel3.TabIndex = 4;
            // 
            // txtSearch
            // 
            this.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(379, 40);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(356, 21);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 442);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1121, 100);
            this.panel2.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnCancel);
            this.panel5.Controls.Add(this.btnSave);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(762, 0);
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
            // tabClient
            // 
            this.tabClient.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabClient.Controls.Add(this.tpConsult);
            this.tabClient.Controls.Add(this.tpDetails);
            this.tabClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabClient.Location = new System.Drawing.Point(0, 100);
            this.tabClient.Multiline = true;
            this.tabClient.Name = "tabClient";
            this.tabClient.SelectedIndex = 0;
            this.tabClient.Size = new System.Drawing.Size(1121, 342);
            this.tabClient.TabIndex = 2;
            // 
            // tpConsult
            // 
            this.tpConsult.Controls.Add(this.dgClient);
            this.tpConsult.Location = new System.Drawing.Point(23, 4);
            this.tpConsult.Name = "tpConsult";
            this.tpConsult.Padding = new System.Windows.Forms.Padding(3);
            this.tpConsult.Size = new System.Drawing.Size(1094, 334);
            this.tpConsult.TabIndex = 0;
            this.tpConsult.Text = "Consulta";
            this.tpConsult.UseVisualStyleBackColor = true;
            // 
            // dgClient
            // 
            this.dgClient.AllowUserToAddRows = false;
            this.dgClient.AllowUserToDeleteRows = false;
            this.dgClient.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgClient.Location = new System.Drawing.Point(3, 3);
            this.dgClient.Name = "dgClient";
            this.dgClient.ReadOnly = true;
            this.dgClient.Size = new System.Drawing.Size(1088, 328);
            this.dgClient.TabIndex = 0;
            this.dgClient.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgClient_KeyDown);
            // 
            // tpDetails
            // 
            this.tpDetails.Controls.Add(this.mtbDueDate);
            this.tpDetails.Controls.Add(this.label1);
            this.tpDetails.Controls.Add(this.txtComplemento);
            this.tpDetails.Controls.Add(this.lblComplemento);
            this.tpDetails.Controls.Add(this.txtApelido);
            this.tpDetails.Controls.Add(this.lblApelido);
            this.tpDetails.Controls.Add(this.txtId);
            this.tpDetails.Controls.Add(this.lblCodigo);
            this.tpDetails.Controls.Add(this.txtCidade);
            this.tpDetails.Controls.Add(this.lblCidade);
            this.tpDetails.Controls.Add(this.txtBairro);
            this.tpDetails.Controls.Add(this.lblBairro);
            this.tpDetails.Controls.Add(this.mtbCEP);
            this.tpDetails.Controls.Add(this.lblCEP);
            this.tpDetails.Controls.Add(this.cbUF);
            this.tpDetails.Controls.Add(this.lblUF);
            this.tpDetails.Controls.Add(this.txtNumero);
            this.tpDetails.Controls.Add(this.lblNumero);
            this.tpDetails.Controls.Add(this.txtLogradouro);
            this.tpDetails.Controls.Add(this.lblLogradouro);
            this.tpDetails.Controls.Add(this.lblEstadoCivil);
            this.tpDetails.Controls.Add(this.cbEstadoCivil);
            this.tpDetails.Controls.Add(this.txtEmail);
            this.tpDetails.Controls.Add(this.lblEmail);
            this.tpDetails.Controls.Add(this.mtbCelular);
            this.tpDetails.Controls.Add(this.lblCelular);
            this.tpDetails.Controls.Add(this.mtbTelefone);
            this.tpDetails.Controls.Add(this.lblTelefone);
            this.tpDetails.Controls.Add(this.mtbRG);
            this.tpDetails.Controls.Add(this.lblRG);
            this.tpDetails.Controls.Add(this.mtbCPF);
            this.tpDetails.Controls.Add(this.txtNome);
            this.tpDetails.Controls.Add(this.lblCPF);
            this.tpDetails.Controls.Add(this.lblNome);
            this.tpDetails.Location = new System.Drawing.Point(23, 4);
            this.tpDetails.Name = "tpDetails";
            this.tpDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tpDetails.Size = new System.Drawing.Size(1094, 334);
            this.tpDetails.TabIndex = 1;
            this.tpDetails.Text = "Detalhes";
            this.tpDetails.UseVisualStyleBackColor = true;
            // 
            // mtbDueDate
            // 
            this.mtbDueDate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mtbDueDate.Location = new System.Drawing.Point(500, 107);
            this.mtbDueDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mtbDueDate.Mask = "00/00/0000";
            this.mtbDueDate.Name = "mtbDueDate";
            this.mtbDueDate.Size = new System.Drawing.Size(74, 20);
            this.mtbDueDate.TabIndex = 72;
            this.mtbDueDate.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(432, 110);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 71;
            this.label1.Text = "Data Nasc:";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(113, 265);
            this.txtComplemento.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtComplemento.Multiline = true;
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(586, 47);
            this.txtComplemento.TabIndex = 70;
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComplemento.Location = new System.Drawing.Point(23, 261);
            this.lblComplemento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(86, 13);
            this.lblComplemento.TabIndex = 69;
            this.lblComplemento.Text = "Complemento:";
            // 
            // txtApelido
            // 
            this.txtApelido.Location = new System.Drawing.Point(629, 28);
            this.txtApelido.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtApelido.Name = "txtApelido";
            this.txtApelido.Size = new System.Drawing.Size(277, 20);
            this.txtApelido.TabIndex = 68;
            // 
            // lblApelido
            // 
            this.lblApelido.AutoSize = true;
            this.lblApelido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApelido.Location = new System.Drawing.Point(578, 31);
            this.lblApelido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApelido.Name = "lblApelido";
            this.lblApelido.Size = new System.Drawing.Size(53, 13);
            this.lblApelido.TabIndex = 67;
            this.lblApelido.Text = "Apelido:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(113, 28);
            this.txtId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(63, 20);
            this.txtId.TabIndex = 66;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(60, 31);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(50, 13);
            this.lblCodigo.TabIndex = 65;
            this.lblCodigo.Text = "Código:";
            // 
            // txtCidade
            // 
            this.txtCidade.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtCidade.Location = new System.Drawing.Point(109, 211);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(261, 20);
            this.txtCidade.TabIndex = 64;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.Location = new System.Drawing.Point(59, 215);
            this.lblCidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(50, 13);
            this.lblCidade.TabIndex = 63;
            this.lblCidade.Text = "Cidade:";
            // 
            // txtBairro
            // 
            this.txtBairro.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtBairro.Location = new System.Drawing.Point(453, 162);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(167, 20);
            this.txtBairro.TabIndex = 62;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.Location = new System.Drawing.Point(408, 165);
            this.lblBairro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(44, 13);
            this.lblBairro.TabIndex = 61;
            this.lblBairro.Text = "Bairro:";
            // 
            // mtbCEP
            // 
            this.mtbCEP.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mtbCEP.Location = new System.Drawing.Point(603, 213);
            this.mtbCEP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mtbCEP.Mask = "99999-999";
            this.mtbCEP.Name = "mtbCEP";
            this.mtbCEP.Size = new System.Drawing.Size(63, 20);
            this.mtbCEP.TabIndex = 60;
            this.mtbCEP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbCEP_KeyPress);
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCEP.Location = new System.Drawing.Point(565, 216);
            this.lblCEP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(35, 13);
            this.lblCEP.TabIndex = 59;
            this.lblCEP.Text = "CEP:";
            // 
            // cbUF
            // 
            this.cbUF.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cbUF.FormattingEnabled = true;
            this.cbUF.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cbUF.Location = new System.Drawing.Point(429, 214);
            this.cbUF.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbUF.Name = "cbUF";
            this.cbUF.Size = new System.Drawing.Size(81, 21);
            this.cbUF.TabIndex = 58;
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUF.Location = new System.Drawing.Point(401, 218);
            this.lblUF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(27, 13);
            this.lblUF.TabIndex = 57;
            this.lblUF.Text = "UF:";
            // 
            // txtNumero
            // 
            this.txtNumero.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtNumero.Location = new System.Drawing.Point(696, 162);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(63, 20);
            this.txtNumero.TabIndex = 56;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(645, 165);
            this.lblNumero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(54, 13);
            this.lblNumero.TabIndex = 55;
            this.lblNumero.Text = "Número:";
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtLogradouro.Location = new System.Drawing.Point(109, 162);
            this.txtLogradouro.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(277, 20);
            this.txtLogradouro.TabIndex = 54;
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.AutoSize = true;
            this.lblLogradouro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogradouro.Location = new System.Drawing.Point(30, 165);
            this.lblLogradouro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(75, 13);
            this.lblLogradouro.TabIndex = 53;
            this.lblLogradouro.Text = "Logradouro:";
            // 
            // lblEstadoCivil
            // 
            this.lblEstadoCivil.AutoSize = true;
            this.lblEstadoCivil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoCivil.Location = new System.Drawing.Point(765, 69);
            this.lblEstadoCivil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstadoCivil.Name = "lblEstadoCivil";
            this.lblEstadoCivil.Size = new System.Drawing.Size(78, 13);
            this.lblEstadoCivil.TabIndex = 52;
            this.lblEstadoCivil.Text = "Estado Civil:";
            // 
            // cbEstadoCivil
            // 
            this.cbEstadoCivil.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cbEstadoCivil.FormattingEnabled = true;
            this.cbEstadoCivil.Items.AddRange(new object[] {
            "Casado",
            "Solteiro",
            "Viúvo",
            "Separado",
            "Divorciado",
            "Empresa"});
            this.cbEstadoCivil.Location = new System.Drawing.Point(845, 65);
            this.cbEstadoCivil.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbEstadoCivil.Name = "cbEstadoCivil";
            this.cbEstadoCivil.Size = new System.Drawing.Size(81, 21);
            this.cbEstadoCivil.TabIndex = 51;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(113, 107);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(277, 20);
            this.txtEmail.TabIndex = 50;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(65, 110);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 13);
            this.lblEmail.TabIndex = 49;
            this.lblEmail.Text = "Email:";
            // 
            // mtbCelular
            // 
            this.mtbCelular.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mtbCelular.Location = new System.Drawing.Point(642, 66);
            this.mtbCelular.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mtbCelular.Mask = "(99) 9999-99999";
            this.mtbCelular.Name = "mtbCelular";
            this.mtbCelular.Size = new System.Drawing.Size(98, 20);
            this.mtbCelular.TabIndex = 48;
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelular.Location = new System.Drawing.Point(593, 69);
            this.lblCelular.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(50, 13);
            this.lblCelular.TabIndex = 47;
            this.lblCelular.Text = "Celular:";
            // 
            // mtbTelefone
            // 
            this.mtbTelefone.Location = new System.Drawing.Point(470, 66);
            this.mtbTelefone.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mtbTelefone.Mask = "(99) 9999-9999";
            this.mtbTelefone.Name = "mtbTelefone";
            this.mtbTelefone.Size = new System.Drawing.Size(98, 20);
            this.mtbTelefone.TabIndex = 46;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(402, 69);
            this.lblTelefone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(61, 13);
            this.lblTelefone.TabIndex = 45;
            this.lblTelefone.Text = "Telefone:";
            // 
            // mtbRG
            // 
            this.mtbRG.Location = new System.Drawing.Point(271, 66);
            this.mtbRG.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mtbRG.Mask = "99,999,999-a";
            this.mtbRG.Name = "mtbRG";
            this.mtbRG.Size = new System.Drawing.Size(87, 20);
            this.mtbRG.TabIndex = 44;
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRG.Location = new System.Drawing.Point(241, 69);
            this.lblRG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(29, 13);
            this.lblRG.TabIndex = 43;
            this.lblRG.Text = "RG:";
            // 
            // mtbCPF
            // 
            this.mtbCPF.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mtbCPF.Location = new System.Drawing.Point(113, 66);
            this.mtbCPF.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mtbCPF.Mask = "999,999,999-99";
            this.mtbCPF.Name = "mtbCPF";
            this.mtbCPF.Size = new System.Drawing.Size(98, 20);
            this.mtbCPF.TabIndex = 42;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtNome.Location = new System.Drawing.Point(262, 28);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(277, 20);
            this.txtNome.TabIndex = 41;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.Location = new System.Drawing.Point(79, 69);
            this.lblCPF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(34, 13);
            this.lblCPF.TabIndex = 40;
            this.lblCPF.Text = "CPF:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(211, 31);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(43, 13);
            this.lblNome.TabIndex = 39;
            this.lblNome.Text = "Nome:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(303, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 78;
            this.label6.Text = "Pesquisa:";
            // 
            // frmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 542);
            this.Controls.Add(this.tabClient);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.frmClient_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tabClient.ResumeLayout(false);
            this.tpConsult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgClient)).EndInit();
            this.tpDetails.ResumeLayout(false);
            this.tpDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TabControl tabClient;
        private System.Windows.Forms.TabPage tpConsult;
        private System.Windows.Forms.TabPage tpDetails;
        public System.Windows.Forms.TextBox txtApelido;
        private System.Windows.Forms.Label lblApelido;
        public System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblCodigo;
        public System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblCidade;
        public System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblBairro;
        public System.Windows.Forms.MaskedTextBox mtbCEP;
        private System.Windows.Forms.Label lblCEP;
        public System.Windows.Forms.ComboBox cbUF;
        private System.Windows.Forms.Label lblUF;
        public System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNumero;
        public System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.Label lblLogradouro;
        private System.Windows.Forms.Label lblEstadoCivil;
        public System.Windows.Forms.ComboBox cbEstadoCivil;
        public System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        public System.Windows.Forms.MaskedTextBox mtbCelular;
        private System.Windows.Forms.Label lblCelular;
        public System.Windows.Forms.MaskedTextBox mtbTelefone;
        private System.Windows.Forms.Label lblTelefone;
        public System.Windows.Forms.MaskedTextBox mtbRG;
        private System.Windows.Forms.Label lblRG;
        public System.Windows.Forms.MaskedTextBox mtbCPF;
        public System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblNome;
        public System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label lblComplemento;
        public System.Windows.Forms.DataGridView dgClient;
        public System.Windows.Forms.MaskedTextBox mtbDueDate;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label label6;
    }
}