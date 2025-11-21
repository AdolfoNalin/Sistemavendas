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
            this.txtFunction = new System.Windows.Forms.TextBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.txtComplement = new System.Windows.Forms.TextBox();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.txtShortName = new System.Windows.Forms.TextBox();
            this.lblApelido = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtNeighborhood = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.mtbCEP = new System.Windows.Forms.MaskedTextBox();
            this.lblCEP = new System.Windows.Forms.Label();
            this.cbUF = new System.Windows.Forms.ComboBox();
            this.lblUF = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.lblLogradouro = new System.Windows.Forms.Label();
            this.lblEstadoCivil = new System.Windows.Forms.Label();
            this.cbMaritalStatus = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.mtbPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.lblCelular = new System.Windows.Forms.Label();
            this.mtbTelephoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.mtbRG = new System.Windows.Forms.MaskedTextBox();
            this.lblRG = new System.Windows.Forms.Label();
            this.mtbCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblCPF = new System.Windows.Forms.Label();
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
            this.dgEmployee.AllowUserToAddRows = false;
            this.dgEmployee.AllowUserToDeleteRows = false;
            this.dgEmployee.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgEmployee.Location = new System.Drawing.Point(3, 3);
            this.dgEmployee.Name = "dgEmployee";
            this.dgEmployee.ReadOnly = true;
            this.dgEmployee.Size = new System.Drawing.Size(1088, 328);
            this.dgEmployee.TabIndex = 0;
            this.dgEmployee.SelectionChanged += new System.EventHandler(this.dgEmployee_SelectionChanged);
            // 
            // tpDetails
            // 
            this.tpDetails.Controls.Add(this.txtFunction);
            this.tpDetails.Controls.Add(this.lblCargo);
            this.tpDetails.Controls.Add(this.txtComplement);
            this.tpDetails.Controls.Add(this.lblComplemento);
            this.tpDetails.Controls.Add(this.txtShortName);
            this.tpDetails.Controls.Add(this.lblApelido);
            this.tpDetails.Controls.Add(this.txtId);
            this.tpDetails.Controls.Add(this.lblCodigo);
            this.tpDetails.Controls.Add(this.txtCity);
            this.tpDetails.Controls.Add(this.lblCidade);
            this.tpDetails.Controls.Add(this.txtNeighborhood);
            this.tpDetails.Controls.Add(this.lblBairro);
            this.tpDetails.Controls.Add(this.mtbCEP);
            this.tpDetails.Controls.Add(this.lblCEP);
            this.tpDetails.Controls.Add(this.cbUF);
            this.tpDetails.Controls.Add(this.lblUF);
            this.tpDetails.Controls.Add(this.txtNumber);
            this.tpDetails.Controls.Add(this.lblNumero);
            this.tpDetails.Controls.Add(this.txtStreet);
            this.tpDetails.Controls.Add(this.lblLogradouro);
            this.tpDetails.Controls.Add(this.lblEstadoCivil);
            this.tpDetails.Controls.Add(this.cbMaritalStatus);
            this.tpDetails.Controls.Add(this.txtEmail);
            this.tpDetails.Controls.Add(this.lblEmail);
            this.tpDetails.Controls.Add(this.mtbPhoneNumber);
            this.tpDetails.Controls.Add(this.lblCelular);
            this.tpDetails.Controls.Add(this.mtbTelephoneNumber);
            this.tpDetails.Controls.Add(this.lblTelefone);
            this.tpDetails.Controls.Add(this.mtbRG);
            this.tpDetails.Controls.Add(this.lblRG);
            this.tpDetails.Controls.Add(this.mtbCPF);
            this.tpDetails.Controls.Add(this.txtName);
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
            // txtFunction
            // 
            this.txtFunction.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtFunction.Location = new System.Drawing.Point(851, 159);
            this.txtFunction.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFunction.Name = "txtFunction";
            this.txtFunction.Size = new System.Drawing.Size(107, 20);
            this.txtFunction.TabIndex = 110;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.Location = new System.Drawing.Point(805, 163);
            this.lblCargo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(44, 13);
            this.lblCargo.TabIndex = 108;
            this.lblCargo.Text = "Cargo:";
            // 
            // txtComplement
            // 
            this.txtComplement.Location = new System.Drawing.Point(119, 262);
            this.txtComplement.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtComplement.Multiline = true;
            this.txtComplement.Name = "txtComplement";
            this.txtComplement.Size = new System.Drawing.Size(586, 47);
            this.txtComplement.TabIndex = 106;
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
            // txtShortName
            // 
            this.txtShortName.Location = new System.Drawing.Point(635, 25);
            this.txtShortName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtShortName.Name = "txtShortName";
            this.txtShortName.Size = new System.Drawing.Size(277, 20);
            this.txtShortName.TabIndex = 104;
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
            // txtCity
            // 
            this.txtCity.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtCity.Location = new System.Drawing.Point(115, 208);
            this.txtCity.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(261, 20);
            this.txtCity.TabIndex = 100;
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
            // txtNeighborhood
            // 
            this.txtNeighborhood.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtNeighborhood.Location = new System.Drawing.Point(459, 159);
            this.txtNeighborhood.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNeighborhood.Name = "txtNeighborhood";
            this.txtNeighborhood.Size = new System.Drawing.Size(167, 20);
            this.txtNeighborhood.TabIndex = 98;
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
            this.mtbCEP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbCEP_KeyPress);
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
            // txtNumber
            // 
            this.txtNumber.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtNumber.Location = new System.Drawing.Point(702, 159);
            this.txtNumber.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(63, 20);
            this.txtNumber.TabIndex = 92;
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
            // txtStreet
            // 
            this.txtStreet.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtStreet.Location = new System.Drawing.Point(115, 159);
            this.txtStreet.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(277, 20);
            this.txtStreet.TabIndex = 90;
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
            // cbMaritalStatus
            // 
            this.cbMaritalStatus.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cbMaritalStatus.FormattingEnabled = true;
            this.cbMaritalStatus.Items.AddRange(new object[] {
            "Casado",
            "Solteiro",
            "Viúvo",
            "Separado",
            "Divorciado",
            "Empresa"});
            this.cbMaritalStatus.Location = new System.Drawing.Point(851, 62);
            this.cbMaritalStatus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbMaritalStatus.Name = "cbMaritalStatus";
            this.cbMaritalStatus.Size = new System.Drawing.Size(81, 21);
            this.cbMaritalStatus.TabIndex = 87;
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
            // mtbPhoneNumber
            // 
            this.mtbPhoneNumber.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mtbPhoneNumber.Location = new System.Drawing.Point(648, 63);
            this.mtbPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mtbPhoneNumber.Mask = "(99) 9999-99999";
            this.mtbPhoneNumber.Name = "mtbPhoneNumber";
            this.mtbPhoneNumber.Size = new System.Drawing.Size(98, 20);
            this.mtbPhoneNumber.TabIndex = 84;
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
            // mtbTelephoneNumber
            // 
            this.mtbTelephoneNumber.Location = new System.Drawing.Point(476, 63);
            this.mtbTelephoneNumber.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mtbTelephoneNumber.Mask = "(99) 9999-9999";
            this.mtbTelephoneNumber.Name = "mtbTelephoneNumber";
            this.mtbTelephoneNumber.Size = new System.Drawing.Size(98, 20);
            this.mtbTelephoneNumber.TabIndex = 82;
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
            this.mtbCPF.Mask = "999,999,999-99";
            this.mtbCPF.Name = "mtbCPF";
            this.mtbCPF.Size = new System.Drawing.Size(98, 20);
            this.mtbCPF.TabIndex = 78;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtName.Location = new System.Drawing.Point(268, 25);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(277, 20);
            this.txtName.TabIndex = 77;
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
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forncedor";
            this.Load += new System.EventHandler(this.frmEmployee_Load);
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
        private System.Windows.Forms.Label lblCargo;
        public System.Windows.Forms.TextBox txtComplement;
        private System.Windows.Forms.Label lblComplemento;
        public System.Windows.Forms.TextBox txtShortName;
        private System.Windows.Forms.Label lblApelido;
        public System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblCodigo;
        public System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblCidade;
        public System.Windows.Forms.TextBox txtNeighborhood;
        private System.Windows.Forms.Label lblBairro;
        public System.Windows.Forms.MaskedTextBox mtbCEP;
        private System.Windows.Forms.Label lblCEP;
        public System.Windows.Forms.ComboBox cbUF;
        private System.Windows.Forms.Label lblUF;
        public System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label lblNumero;
        public System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label lblLogradouro;
        private System.Windows.Forms.Label lblEstadoCivil;
        public System.Windows.Forms.ComboBox cbMaritalStatus;
        public System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        public System.Windows.Forms.MaskedTextBox mtbPhoneNumber;
        private System.Windows.Forms.Label lblCelular;
        public System.Windows.Forms.MaskedTextBox mtbTelephoneNumber;
        private System.Windows.Forms.Label lblTelefone;
        public System.Windows.Forms.MaskedTextBox mtbRG;
        private System.Windows.Forms.Label lblRG;
        public System.Windows.Forms.MaskedTextBox mtbCPF;
        public System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblNome;
        public System.Windows.Forms.DataGridView dgEmployee;
        public System.Windows.Forms.TextBox txtFunction;
    }
}