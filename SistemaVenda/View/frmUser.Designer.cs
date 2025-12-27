namespace SistemaVenda.View
{
    partial class frmUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUser));
            this.tabUser = new System.Windows.Forms.TabControl();
            this.tpConsult = new System.Windows.Forms.TabPage();
            this.dgUser = new System.Windows.Forms.DataGridView();
            this.tpDetails = new System.Windows.Forms.TabPage();
            this.btnAuthorization = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtApelido = new System.Windows.Forms.TextBox();
            this.lblApelido = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblEmployees = new System.Windows.Forms.Label();
            this.cbEmployees = new System.Windows.Forms.ComboBox();
            this.txtNome = new System.Windows.Forms.TextBox();
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabUser.SuspendLayout();
            this.tpConsult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUser)).BeginInit();
            this.tpDetails.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabUser
            // 
            this.tabUser.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabUser.Controls.Add(this.tpConsult);
            this.tabUser.Controls.Add(this.tpDetails);
            this.tabUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabUser.Location = new System.Drawing.Point(0, 100);
            this.tabUser.Multiline = true;
            this.tabUser.Name = "tabUser";
            this.tabUser.SelectedIndex = 0;
            this.tabUser.Size = new System.Drawing.Size(1001, 347);
            this.tabUser.TabIndex = 5;
            // 
            // tpConsult
            // 
            this.tpConsult.Controls.Add(this.dgUser);
            this.tpConsult.Location = new System.Drawing.Point(23, 4);
            this.tpConsult.Name = "tpConsult";
            this.tpConsult.Padding = new System.Windows.Forms.Padding(3);
            this.tpConsult.Size = new System.Drawing.Size(974, 339);
            this.tpConsult.TabIndex = 0;
            this.tpConsult.Text = "Consulta";
            this.tpConsult.UseVisualStyleBackColor = true;
            // 
            // dgUser
            // 
            this.dgUser.AllowUserToAddRows = false;
            this.dgUser.AllowUserToDeleteRows = false;
            this.dgUser.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgUser.Location = new System.Drawing.Point(3, 3);
            this.dgUser.Name = "dgUser";
            this.dgUser.ReadOnly = true;
            this.dgUser.Size = new System.Drawing.Size(968, 333);
            this.dgUser.TabIndex = 0;
            this.dgUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgUser_KeyDown);
            // 
            // tpDetails
            // 
            this.tpDetails.Controls.Add(this.btnAuthorization);
            this.tpDetails.Controls.Add(this.txtPassword);
            this.tpDetails.Controls.Add(this.lblPassword);
            this.tpDetails.Controls.Add(this.txtApelido);
            this.tpDetails.Controls.Add(this.lblApelido);
            this.tpDetails.Controls.Add(this.txtId);
            this.tpDetails.Controls.Add(this.lblCodigo);
            this.tpDetails.Controls.Add(this.lblEmployees);
            this.tpDetails.Controls.Add(this.cbEmployees);
            this.tpDetails.Controls.Add(this.txtNome);
            this.tpDetails.Controls.Add(this.lblNome);
            this.tpDetails.Location = new System.Drawing.Point(23, 4);
            this.tpDetails.Name = "tpDetails";
            this.tpDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tpDetails.Size = new System.Drawing.Size(974, 339);
            this.tpDetails.TabIndex = 1;
            this.tpDetails.Text = "Detalhes";
            this.tpDetails.UseVisualStyleBackColor = true;
            // 
            // btnAuthorization
            // 
            this.btnAuthorization.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAuthorization.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuthorization.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnAuthorization.Image = ((System.Drawing.Image)(resources.GetObject("btnAuthorization.Image")));
            this.btnAuthorization.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAuthorization.Location = new System.Drawing.Point(758, 230);
            this.btnAuthorization.Name = "btnAuthorization";
            this.btnAuthorization.Size = new System.Drawing.Size(156, 53);
            this.btnAuthorization.TabIndex = 110;
            this.btnAuthorization.Text = "Autorização";
            this.btnAuthorization.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAuthorization.UseVisualStyleBackColor = true;
            this.btnAuthorization.Click += new System.EventHandler(this.btnAuthorization_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(113, 109);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(141, 20);
            this.txtPassword.TabIndex = 70;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(67, 112);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(47, 13);
            this.lblPassword.TabIndex = 69;
            this.lblPassword.Text = "Senha:";
            // 
            // txtApelido
            // 
            this.txtApelido.Location = new System.Drawing.Point(113, 69);
            this.txtApelido.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtApelido.Name = "txtApelido";
            this.txtApelido.Size = new System.Drawing.Size(277, 20);
            this.txtApelido.TabIndex = 68;
            // 
            // lblApelido
            // 
            this.lblApelido.AutoSize = true;
            this.lblApelido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApelido.Location = new System.Drawing.Point(70, 73);
            this.lblApelido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApelido.Name = "lblApelido";
            this.lblApelido.Size = new System.Drawing.Size(42, 13);
            this.lblApelido.TabIndex = 67;
            this.lblApelido.Text = "Login:";
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
            this.lblCodigo.Location = new System.Drawing.Point(62, 32);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(50, 13);
            this.lblCodigo.TabIndex = 65;
            this.lblCodigo.Text = "Código:";
            // 
            // lblEmployees
            // 
            this.lblEmployees.AutoSize = true;
            this.lblEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployees.Location = new System.Drawing.Point(484, 72);
            this.lblEmployees.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmployees.Name = "lblEmployees";
            this.lblEmployees.Size = new System.Drawing.Size(77, 13);
            this.lblEmployees.TabIndex = 52;
            this.lblEmployees.Text = "Funcionário:";
            // 
            // cbEmployees
            // 
            this.cbEmployees.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cbEmployees.FormattingEnabled = true;
            this.cbEmployees.Items.AddRange(new object[] {
            "Casado",
            "Solteiro",
            "Viúvo",
            "Separado",
            "Divorciado",
            "Empresa"});
            this.cbEmployees.Location = new System.Drawing.Point(564, 68);
            this.cbEmployees.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbEmployees.Name = "cbEmployees";
            this.cbEmployees.Size = new System.Drawing.Size(245, 21);
            this.cbEmployees.TabIndex = 51;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 447);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1001, 100);
            this.panel2.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnCancel);
            this.panel5.Controls.Add(this.btnSave);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(642, 0);
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
            this.panel1.Size = new System.Drawing.Size(1001, 100);
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
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(-120, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1121, 100);
            this.panel3.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold);
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(1015, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 47);
            this.button1.TabIndex = 6;
            this.button1.Text = "Sair";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(452, 40);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(356, 21);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(376, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 84;
            this.label6.Text = "Pesquisa:";
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 547);
            this.Controls.Add(this.tabUser);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuário";
            this.Load += new System.EventHandler(this.frmUser_Load);
            this.tabUser.ResumeLayout(false);
            this.tpConsult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgUser)).EndInit();
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

        private System.Windows.Forms.TabControl tabUser;
        private System.Windows.Forms.TabPage tpConsult;
        public System.Windows.Forms.DataGridView dgUser;
        private System.Windows.Forms.TabPage tpDetails;
        public System.Windows.Forms.TextBox txtApelido;
        private System.Windows.Forms.Label lblApelido;
        public System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblEmployees;
        public System.Windows.Forms.ComboBox cbEmployees;
        public System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
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
        public System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAuthorization;
        private System.Windows.Forms.Label label6;
    }
}