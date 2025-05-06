namespace SistemaVenda.br.pro.com.view
{
    partial class frmEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployee));
            this.tabEmployee = new System.Windows.Forms.TabControl();
            this.tpConsult = new System.Windows.Forms.TabPage();
            this.dgEmployee = new System.Windows.Forms.DataGridView();
            this.tpDetails = new System.Windows.Forms.TabPage();
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
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.cbCargo = new System.Windows.Forms.ComboBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.txtApelido = new System.Windows.Forms.TextBox();
            this.lblApelido = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
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
            this.tabEmployee.SuspendLayout();
            this.tpConsult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployee)).BeginInit();
            this.tpDetails.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabEmployee
            // 
            this.tabEmployee.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabEmployee.Controls.Add(this.tpConsult);
            this.tabEmployee.Controls.Add(this.tpDetails);
            this.tabEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabEmployee.Location = new System.Drawing.Point(0, 100);
            this.tabEmployee.Multiline = true;
            this.tabEmployee.Name = "tabEmployee";
            this.tabEmployee.SelectedIndex = 0;
            this.tabEmployee.Size = new System.Drawing.Size(1121, 342);
            this.tabEmployee.TabIndex = 5;
            // 
            // tpConsult
            // 
            this.tpConsult.Controls.Add(this.dgEmployee);
            this.tpConsult.Location = new System.Drawing.Point(23, 4);
            this.tpConsult.Name = "tpConsult";
            this.tpConsult.Padding = new System.Windows.Forms.Padding(3);
            this.tpConsult.Size = new System.Drawing.Size(1094, 334);
            this.tpConsult.TabIndex = 0;
            this.tpConsult.Text = "Consulta";
            this.tpConsult.UseVisualStyleBackColor = true;
            // 
            // dgEmployee
            // 
            this.dgEmployee.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgEmployee.Location = new System.Drawing.Point(3, 3);
            this.dgEmployee.Name = "dgEmployee";
            this.dgEmployee.Size = new System.Drawing.Size(1088, 328);
            this.dgEmployee.TabIndex = 0;
            this.dgEmployee.SelectionChanged += new System.EventHandler(this.dgEmployee_SelectionChanged);
            // 
            // tpDetails
            // 
            this.tpDetails.Controls.Add(this.txtPassword);
            this.tpDetails.Controls.Add(this.lblPassword);
            this.tpDetails.Controls.Add(this.lblCargo);
            this.tpDetails.Controls.Add(this.cbCargo);
            this.tpDetails.Controls.Add(this.txtComplemento);
            this.tpDetails.Controls.Add(this.lblComplemento);
            this.tpDetails.Controls.Add(this.txtApelido);
            this.tpDetails.Controls.Add(this.lblApelido);
            this.tpDetails.Controls.Add(this.txtCodigo);
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 442);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1121, 100);
            this.panel2.TabIndex = 4;
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
            this.panel1.Size = new System.Drawing.Size(1121, 100);
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
            this.panel3.Location = new System.Drawing.Point(0, 0);
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
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtPassword.Location = new System.Drawing.Point(824, 158);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 110;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(779, 161);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(47, 13);
            this.lblPassword.TabIndex = 109;
            this.lblPassword.Text = "Senha:";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.Location = new System.Drawing.Point(938, 162);
            this.lblCargo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(44, 13);
            this.lblCargo.TabIndex = 108;
            this.lblCargo.Text = "Cargo:";
            // 
            // cbCargo
            // 
            this.cbCargo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cbCargo.FormattingEnabled = true;
            this.cbCargo.Items.AddRange(new object[] {
            "Casado",
            "Solteiro",
            "Viúvo",
            "Separado",
            "Divorciado",
            "Empresa"});
            this.cbCargo.Location = new System.Drawing.Point(984, 158);
            this.cbCargo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbCargo.Name = "cbCargo";
            this.cbCargo.Size = new System.Drawing.Size(81, 21);
            this.cbCargo.TabIndex = 107;
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(119, 262);
            this.txtComplemento.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtComplemento.Multiline = true;
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(586, 47);
            this.txtComplemento.TabIndex = 106;
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComplemento.Location = new System.Drawing.Point(29, 258);
            this.lblComplemento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(86, 13);
            this.lblComplemento.TabIndex = 105;
            this.lblComplemento.Text = "Complemento:";
            // 
            // txtApelido
            // 
            this.txtApelido.Location = new System.Drawing.Point(635, 25);
            this.txtApelido.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtApelido.Name = "txtApelido";
            this.txtApelido.Size = new System.Drawing.Size(277, 20);
            this.txtApelido.TabIndex = 104;
            // 
            // lblApelido
            // 
            this.lblApelido.AutoSize = true;
            this.lblApelido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApelido.Location = new System.Drawing.Point(584, 28);
            this.lblApelido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApelido.Name = "lblApelido";
            this.lblApelido.Size = new System.Drawing.Size(53, 13);
            this.lblApelido.TabIndex = 103;
            this.lblApelido.Text = "Apelido:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(119, 25);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(63, 20);
            this.txtCodigo.TabIndex = 102;
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
            // txtCidade
            // 
            this.txtCidade.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtCidade.Location = new System.Drawing.Point(115, 208);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(261, 20);
            this.txtCidade.TabIndex = 100;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.Location = new System.Drawing.Point(65, 212);
            this.lblCidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(50, 13);
            this.lblCidade.TabIndex = 99;
            this.lblCidade.Text = "Cidade:";
            // 
            // txtBairro
            // 
            this.txtBairro.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtBairro.Location = new System.Drawing.Point(459, 159);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(167, 20);
            this.txtBairro.TabIndex = 98;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.Location = new System.Drawing.Point(414, 162);
            this.lblBairro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(44, 13);
            this.lblBairro.TabIndex = 97;
            this.lblBairro.Text = "Bairro:";
            // 
            // mtbCEP
            // 
            this.mtbCEP.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mtbCEP.Location = new System.Drawing.Point(609, 210);
            this.mtbCEP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mtbCEP.Mask = "99999-999";
            this.mtbCEP.Name = "mtbCEP";
            this.mtbCEP.Size = new System.Drawing.Size(63, 20);
            this.mtbCEP.TabIndex = 96;
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCEP.Location = new System.Drawing.Point(571, 213);
            this.lblCEP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(35, 13);
            this.lblCEP.TabIndex = 95;
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
            this.cbUF.Location = new System.Drawing.Point(435, 211);
            this.cbUF.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbUF.Name = "cbUF";
            this.cbUF.Size = new System.Drawing.Size(81, 21);
            this.cbUF.TabIndex = 94;
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUF.Location = new System.Drawing.Point(407, 215);
            this.lblUF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(27, 13);
            this.lblUF.TabIndex = 93;
            this.lblUF.Text = "UF:";
            // 
            // txtNumero
            // 
            this.txtNumero.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtNumero.Location = new System.Drawing.Point(702, 159);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(63, 20);
            this.txtNumero.TabIndex = 92;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(651, 162);
            this.lblNumero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(54, 13);
            this.lblNumero.TabIndex = 91;
            this.lblNumero.Text = "Número:";
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtLogradouro.Location = new System.Drawing.Point(115, 159);
            this.txtLogradouro.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(277, 20);
            this.txtLogradouro.TabIndex = 90;
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.AutoSize = true;
            this.lblLogradouro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogradouro.Location = new System.Drawing.Point(36, 162);
            this.lblLogradouro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(75, 13);
            this.lblLogradouro.TabIndex = 89;
            this.lblLogradouro.Text = "Logradouro:";
            // 
            // lblEstadoCivil
            // 
            this.lblEstadoCivil.AutoSize = true;
            this.lblEstadoCivil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoCivil.Location = new System.Drawing.Point(771, 66);
            this.lblEstadoCivil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstadoCivil.Name = "lblEstadoCivil";
            this.lblEstadoCivil.Size = new System.Drawing.Size(78, 13);
            this.lblEstadoCivil.TabIndex = 88;
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
            this.cbEstadoCivil.Location = new System.Drawing.Point(851, 62);
            this.cbEstadoCivil.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbEstadoCivil.Name = "cbEstadoCivil";
            this.cbEstadoCivil.Size = new System.Drawing.Size(81, 21);
            this.cbEstadoCivil.TabIndex = 87;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(119, 104);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(277, 20);
            this.txtEmail.TabIndex = 86;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(71, 107);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 13);
            this.lblEmail.TabIndex = 85;
            this.lblEmail.Text = "Email:";
            // 
            // mtbCelular
            // 
            this.mtbCelular.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mtbCelular.Location = new System.Drawing.Point(648, 63);
            this.mtbCelular.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mtbCelular.Mask = "(99) 9999-99999";
            this.mtbCelular.Name = "mtbCelular";
            this.mtbCelular.Size = new System.Drawing.Size(98, 20);
            this.mtbCelular.TabIndex = 84;
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelular.Location = new System.Drawing.Point(599, 66);
            this.lblCelular.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(50, 13);
            this.lblCelular.TabIndex = 83;
            this.lblCelular.Text = "Celular:";
            // 
            // mtbTelefone
            // 
            this.mtbTelefone.Location = new System.Drawing.Point(476, 63);
            this.mtbTelefone.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mtbTelefone.Mask = "(99) 9999-9999";
            this.mtbTelefone.Name = "mtbTelefone";
            this.mtbTelefone.Size = new System.Drawing.Size(98, 20);
            this.mtbTelefone.TabIndex = 82;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(408, 66);
            this.lblTelefone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(61, 13);
            this.lblTelefone.TabIndex = 81;
            this.lblTelefone.Text = "Telefone:";
            // 
            // mtbRG
            // 
            this.mtbRG.Location = new System.Drawing.Point(277, 63);
            this.mtbRG.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mtbRG.Mask = "99.999.999-9";
            this.mtbRG.Name = "mtbRG";
            this.mtbRG.Size = new System.Drawing.Size(87, 20);
            this.mtbRG.TabIndex = 80;
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRG.Location = new System.Drawing.Point(247, 66);
            this.lblRG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(29, 13);
            this.lblRG.TabIndex = 79;
            this.lblRG.Text = "RG:";
            // 
            // mtbCPF
            // 
            this.mtbCPF.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mtbCPF.Location = new System.Drawing.Point(119, 63);
            this.mtbCPF.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mtbCPF.Mask = "999.999.999-99";
            this.mtbCPF.Name = "mtbCPF";
            this.mtbCPF.Size = new System.Drawing.Size(98, 20);
            this.mtbCPF.TabIndex = 78;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtNome.Location = new System.Drawing.Point(268, 25);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(277, 20);
            this.txtNome.TabIndex = 77;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.Location = new System.Drawing.Point(85, 66);
            this.lblCPF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(34, 13);
            this.lblCPF.TabIndex = 76;
            this.lblCPF.Text = "CPF:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(217, 28);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(43, 13);
            this.lblNome.TabIndex = 75;
            this.lblNome.Text = "Nome:";
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 542);
            this.Controls.Add(this.tabEmployee);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmEmployee";
            this.Text = "Forncedor";
            this.tabEmployee.ResumeLayout(false);
            this.tpConsult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployee)).EndInit();
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

        private System.Windows.Forms.TabControl tabEmployee;
        private System.Windows.Forms.TabPage tpConsult;
        private System.Windows.Forms.DataGridView dgEmployee;
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
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        public System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblCargo;
        public System.Windows.Forms.ComboBox cbCargo;
        public System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label lblComplemento;
        public System.Windows.Forms.TextBox txtApelido;
        private System.Windows.Forms.Label lblApelido;
        public System.Windows.Forms.TextBox txtCodigo;
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
    }
}