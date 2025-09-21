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
            this.tabEmployee = new System.Windows.Forms.TabControl();
            this.tpConsult = new System.Windows.Forms.TabPage();
            this.dgBudget = new System.Windows.Forms.DataGridView();
            this.tpDetails = new System.Windows.Forms.TabPage();
            this.rbtnPrazo = new System.Windows.Forms.RadioButton();
            this.rbtnVista = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.cbDescricao = new System.Windows.Forms.ComboBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.mtbHora = new System.Windows.Forms.MaskedTextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.mtbData = new System.Windows.Forms.MaskedTextBox();
            this.gbDetalhesPagamento = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.mtbTotal = new System.Windows.Forms.MaskedTextBox();
            this.lblAlteracao = new System.Windows.Forms.Label();
            this.mtbAteracoes = new System.Windows.Forms.MaskedTextBox();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.mtbSubTotal = new System.Windows.Forms.MaskedTextBox();
            this.mtbAP = new System.Windows.Forms.MaskedTextBox();
            this.lblAgressimo = new System.Windows.Forms.Label();
            this.mtbAD = new System.Windows.Forms.MaskedTextBox();
            this.mtbDP = new System.Windows.Forms.MaskedTextBox();
            this.lblDesconto = new System.Windows.Forms.Label();
            this.mtbDD = new System.Windows.Forms.MaskedTextBox();
            this.dgOrcamento = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorPrazo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorVista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnConsultClient = new System.Windows.Forms.Button();
            this.tabEmployee.SuspendLayout();
            this.tpConsult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBudget)).BeginInit();
            this.tpDetails.SuspendLayout();
            this.gbDetalhesPagamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrcamento)).BeginInit();
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
            this.tabEmployee.Size = new System.Drawing.Size(943, 480);
            this.tabEmployee.TabIndex = 8;
            // 
            // tpConsult
            // 
            this.tpConsult.Controls.Add(this.dgBudget);
            this.tpConsult.Location = new System.Drawing.Point(23, 4);
            this.tpConsult.Name = "tpConsult";
            this.tpConsult.Padding = new System.Windows.Forms.Padding(3);
            this.tpConsult.Size = new System.Drawing.Size(916, 472);
            this.tpConsult.TabIndex = 0;
            this.tpConsult.Text = "Consulta";
            this.tpConsult.UseVisualStyleBackColor = true;
            // 
            // dgBudget
            // 
            this.dgBudget.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgBudget.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBudget.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgBudget.Location = new System.Drawing.Point(3, 3);
            this.dgBudget.Name = "dgBudget";
            this.dgBudget.Size = new System.Drawing.Size(910, 466);
            this.dgBudget.TabIndex = 0;
            // 
            // tpDetails
            // 
            this.tpDetails.Controls.Add(this.btnConsultClient);
            this.tpDetails.Controls.Add(this.txtNome);
            this.tpDetails.Controls.Add(this.rbtnPrazo);
            this.tpDetails.Controls.Add(this.rbtnVista);
            this.tpDetails.Controls.Add(this.label9);
            this.tpDetails.Controls.Add(this.txtCodigo);
            this.tpDetails.Controls.Add(this.btnAdicionar);
            this.tpDetails.Controls.Add(this.btnRemover);
            this.tpDetails.Controls.Add(this.lblQuantidade);
            this.tpDetails.Controls.Add(this.txtQuantidade);
            this.tpDetails.Controls.Add(this.cbDescricao);
            this.tpDetails.Controls.Add(this.lblDescricao);
            this.tpDetails.Controls.Add(this.lblHora);
            this.tpDetails.Controls.Add(this.mtbHora);
            this.tpDetails.Controls.Add(this.lblData);
            this.tpDetails.Controls.Add(this.mtbData);
            this.tpDetails.Controls.Add(this.gbDetalhesPagamento);
            this.tpDetails.Controls.Add(this.dgOrcamento);
            this.tpDetails.Controls.Add(this.txtObs);
            this.tpDetails.Controls.Add(this.lblObs);
            this.tpDetails.Controls.Add(this.lblCliente);
            this.tpDetails.Location = new System.Drawing.Point(23, 4);
            this.tpDetails.Name = "tpDetails";
            this.tpDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tpDetails.Size = new System.Drawing.Size(916, 472);
            this.tpDetails.TabIndex = 1;
            this.tpDetails.Text = "Detalhes";
            this.tpDetails.UseVisualStyleBackColor = true;
            // 
            // rbtnPrazo
            // 
            this.rbtnPrazo.AutoSize = true;
            this.rbtnPrazo.Location = new System.Drawing.Point(557, 35);
            this.rbtnPrazo.Name = "rbtnPrazo";
            this.rbtnPrazo.Size = new System.Drawing.Size(61, 17);
            this.rbtnPrazo.TabIndex = 70;
            this.rbtnPrazo.TabStop = true;
            this.rbtnPrazo.Text = "Á prazo";
            this.rbtnPrazo.UseVisualStyleBackColor = true;
            // 
            // rbtnVista
            // 
            this.rbtnVista.AutoSize = true;
            this.rbtnVista.Location = new System.Drawing.Point(557, 10);
            this.rbtnVista.Name = "rbtnVista";
            this.rbtnVista.Size = new System.Drawing.Size(57, 17);
            this.rbtnVista.TabIndex = 69;
            this.rbtnVista.TabStop = true;
            this.rbtnVista.Text = "Á vista";
            this.rbtnVista.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(436, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 68;
            this.label9.Text = "Código:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(488, 7);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(47, 20);
            this.txtCodigo.TabIndex = 67;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnAdicionar.Location = new System.Drawing.Point(163, 179);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 66;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // btnRemover
            // 
            this.btnRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnRemover.Location = new System.Drawing.Point(69, 179);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 23);
            this.btnRemover.TabIndex = 65;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.Location = new System.Drawing.Point(51, 124);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(76, 13);
            this.lblQuantidade.TabIndex = 64;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtQuantidade.Location = new System.Drawing.Point(127, 120);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(70, 20);
            this.txtQuantidade.TabIndex = 63;
            // 
            // cbDescricao
            // 
            this.cbDescricao.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cbDescricao.FormattingEnabled = true;
            this.cbDescricao.Location = new System.Drawing.Point(125, 93);
            this.cbDescricao.Name = "cbDescricao";
            this.cbDescricao.Size = new System.Drawing.Size(134, 21);
            this.cbDescricao.TabIndex = 62;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(57, 98);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(68, 13);
            this.lblDescricao.TabIndex = 61;
            this.lblDescricao.Text = "Descrição:";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(776, 47);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(33, 13);
            this.lblHora.TabIndex = 59;
            this.lblHora.Text = "Hora:";
            // 
            // mtbHora
            // 
            this.mtbHora.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mtbHora.Location = new System.Drawing.Point(812, 44);
            this.mtbHora.Mask = "99:99";
            this.mtbHora.Name = "mtbHora";
            this.mtbHora.Size = new System.Drawing.Size(36, 20);
            this.mtbHora.TabIndex = 58;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(747, 22);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(33, 13);
            this.lblData.TabIndex = 57;
            this.lblData.Text = "Data:";
            // 
            // mtbData
            // 
            this.mtbData.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mtbData.Location = new System.Drawing.Point(779, 18);
            this.mtbData.Mask = "99/99/9999";
            this.mtbData.Name = "mtbData";
            this.mtbData.Size = new System.Drawing.Size(69, 20);
            this.mtbData.TabIndex = 56;
            // 
            // gbDetalhesPagamento
            // 
            this.gbDetalhesPagamento.Controls.Add(this.label4);
            this.gbDetalhesPagamento.Controls.Add(this.label3);
            this.gbDetalhesPagamento.Controls.Add(this.label2);
            this.gbDetalhesPagamento.Controls.Add(this.label1);
            this.gbDetalhesPagamento.Controls.Add(this.lblTotal);
            this.gbDetalhesPagamento.Controls.Add(this.mtbTotal);
            this.gbDetalhesPagamento.Controls.Add(this.lblAlteracao);
            this.gbDetalhesPagamento.Controls.Add(this.mtbAteracoes);
            this.gbDetalhesPagamento.Controls.Add(this.lblSubTotal);
            this.gbDetalhesPagamento.Controls.Add(this.mtbSubTotal);
            this.gbDetalhesPagamento.Controls.Add(this.mtbAP);
            this.gbDetalhesPagamento.Controls.Add(this.lblAgressimo);
            this.gbDetalhesPagamento.Controls.Add(this.mtbAD);
            this.gbDetalhesPagamento.Controls.Add(this.mtbDP);
            this.gbDetalhesPagamento.Controls.Add(this.lblDesconto);
            this.gbDetalhesPagamento.Controls.Add(this.mtbDD);
            this.gbDetalhesPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetalhesPagamento.Location = new System.Drawing.Point(57, 340);
            this.gbDetalhesPagamento.Name = "gbDetalhesPagamento";
            this.gbDetalhesPagamento.Size = new System.Drawing.Size(363, 95);
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
            this.lblTotal.Location = new System.Drawing.Point(253, 71);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(40, 13);
            this.lblTotal.TabIndex = 21;
            this.lblTotal.Text = "Total:";
            // 
            // mtbTotal
            // 
            this.mtbTotal.Location = new System.Drawing.Point(294, 68);
            this.mtbTotal.Name = "mtbTotal";
            this.mtbTotal.Size = new System.Drawing.Size(57, 20);
            this.mtbTotal.TabIndex = 20;
            // 
            // lblAlteracao
            // 
            this.lblAlteracao.AutoSize = true;
            this.lblAlteracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlteracao.Location = new System.Drawing.Point(229, 45);
            this.lblAlteracao.Name = "lblAlteracao";
            this.lblAlteracao.Size = new System.Drawing.Size(65, 13);
            this.lblAlteracao.TabIndex = 19;
            this.lblAlteracao.Text = "Alteração:";
            // 
            // mtbAteracoes
            // 
            this.mtbAteracoes.Location = new System.Drawing.Point(294, 42);
            this.mtbAteracoes.Name = "mtbAteracoes";
            this.mtbAteracoes.Size = new System.Drawing.Size(57, 20);
            this.mtbAteracoes.TabIndex = 18;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(224, 19);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(70, 13);
            this.lblSubTotal.TabIndex = 17;
            this.lblSubTotal.Text = "Sub. Total:";
            // 
            // mtbSubTotal
            // 
            this.mtbSubTotal.Location = new System.Drawing.Point(294, 16);
            this.mtbSubTotal.Name = "mtbSubTotal";
            this.mtbSubTotal.Size = new System.Drawing.Size(57, 20);
            this.mtbSubTotal.TabIndex = 16;
            // 
            // mtbAP
            // 
            this.mtbAP.Location = new System.Drawing.Point(150, 49);
            this.mtbAP.Name = "mtbAP";
            this.mtbAP.Size = new System.Drawing.Size(40, 20);
            this.mtbAP.TabIndex = 15;
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
            // mtbAD
            // 
            this.mtbAD.Location = new System.Drawing.Point(86, 49);
            this.mtbAD.Name = "mtbAD";
            this.mtbAD.Size = new System.Drawing.Size(40, 20);
            this.mtbAD.TabIndex = 13;
            // 
            // mtbDP
            // 
            this.mtbDP.Location = new System.Drawing.Point(150, 20);
            this.mtbDP.Name = "mtbDP";
            this.mtbDP.Size = new System.Drawing.Size(40, 20);
            this.mtbDP.TabIndex = 12;
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
            // mtbDD
            // 
            this.mtbDD.Location = new System.Drawing.Point(86, 19);
            this.mtbDD.Name = "mtbDD";
            this.mtbDD.Size = new System.Drawing.Size(40, 20);
            this.mtbDD.TabIndex = 0;
            // 
            // dgOrcamento
            // 
            this.dgOrcamento.AllowUserToAddRows = false;
            this.dgOrcamento.AllowUserToDeleteRows = false;
            this.dgOrcamento.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgOrcamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOrcamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.descricao,
            this.quantidade,
            this.valorPrazo,
            this.valorVista,
            this.subtotal});
            this.dgOrcamento.Location = new System.Drawing.Point(266, 93);
            this.dgOrcamento.Name = "dgOrcamento";
            this.dgOrcamento.ReadOnly = true;
            this.dgOrcamento.Size = new System.Drawing.Size(609, 195);
            this.dgOrcamento.TabIndex = 49;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // descricao
            // 
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            // 
            // quantidade
            // 
            this.quantidade.HeaderText = "Quantidade";
            this.quantidade.Name = "quantidade";
            this.quantidade.ReadOnly = true;
            // 
            // valorPrazo
            // 
            this.valorPrazo.HeaderText = "Valor á Vista";
            this.valorPrazo.Name = "valorPrazo";
            this.valorPrazo.ReadOnly = true;
            // 
            // valorVista
            // 
            this.valorVista.HeaderText = "Valor á Prazo";
            this.valorVista.Name = "valorVista";
            this.valorVista.ReadOnly = true;
            // 
            // subtotal
            // 
            this.subtotal.HeaderText = "Subtotal";
            this.subtotal.Name = "subtotal";
            this.subtotal.ReadOnly = true;
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(487, 340);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(361, 40);
            this.txtObs.TabIndex = 48;
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObs.Location = new System.Drawing.Point(455, 340);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(33, 13);
            this.lblObs.TabIndex = 47;
            this.lblObs.Text = "Obs:";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(76, 10);
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
            this.panel2.Size = new System.Drawing.Size(943, 100);
            this.panel2.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnCancel);
            this.panel5.Controls.Add(this.btnSave);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(584, 0);
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
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(943, 100);
            this.panel1.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnExit);
            this.panel3.Controls.Add(this.btnSearch);
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(-178, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1121, 100);
            this.panel3.TabIndex = 4;
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
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.Location = new System.Drawing.Point(761, 30);
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
            this.txtSearch.Location = new System.Drawing.Point(364, 42);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(356, 21);
            this.txtSearch.TabIndex = 0;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtNome.Location = new System.Drawing.Point(125, 9);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(231, 20);
            this.txtNome.TabIndex = 71;
            // 
            // btnConsultClient
            // 
            this.btnConsultClient.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnConsultClient.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultClient.Image")));
            this.btnConsultClient.Location = new System.Drawing.Point(362, 3);
            this.btnConsultClient.Name = "btnConsultClient";
            this.btnConsultClient.Size = new System.Drawing.Size(36, 32);
            this.btnConsultClient.TabIndex = 6;
            this.btnConsultClient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultClient.UseVisualStyleBackColor = true;
            this.btnConsultClient.Click += new System.EventHandler(this.btnConsultClient_Click);
            // 
            // frmBudget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 680);
            this.Controls.Add(this.tabEmployee);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmBudget";
            this.Text = "Orçamento";
            this.Load += new System.EventHandler(this.frmBudget_Load);
            this.tabEmployee.ResumeLayout(false);
            this.tpConsult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgBudget)).EndInit();
            this.tpDetails.ResumeLayout(false);
            this.tpDetails.PerformLayout();
            this.gbDetalhesPagamento.ResumeLayout(false);
            this.gbDetalhesPagamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrcamento)).EndInit();
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
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.RadioButton rbtnPrazo;
        private System.Windows.Forms.RadioButton rbtnVista;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Label lblQuantidade;
        public System.Windows.Forms.TextBox txtQuantidade;
        public System.Windows.Forms.ComboBox cbDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblHora;
        public System.Windows.Forms.MaskedTextBox mtbHora;
        private System.Windows.Forms.Label lblData;
        public System.Windows.Forms.MaskedTextBox mtbData;
        public System.Windows.Forms.GroupBox gbDetalhesPagamento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotal;
        public System.Windows.Forms.MaskedTextBox mtbTotal;
        private System.Windows.Forms.Label lblAlteracao;
        public System.Windows.Forms.MaskedTextBox mtbAteracoes;
        private System.Windows.Forms.Label lblSubTotal;
        public System.Windows.Forms.MaskedTextBox mtbSubTotal;
        public System.Windows.Forms.MaskedTextBox mtbAP;
        private System.Windows.Forms.Label lblAgressimo;
        public System.Windows.Forms.MaskedTextBox mtbAD;
        public System.Windows.Forms.MaskedTextBox mtbDP;
        private System.Windows.Forms.Label lblDesconto;
        public System.Windows.Forms.MaskedTextBox mtbDD;
        public System.Windows.Forms.DataGridView dgOrcamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorPrazo;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorVista;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        public System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Button btnConsultClient;
        public System.Windows.Forms.TextBox txtNome;
    }
}