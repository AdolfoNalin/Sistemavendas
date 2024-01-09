namespace SistemaVenda.br.pro.com.view
{
    partial class frmCadastrarOrcamento
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
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.lblObs = new System.Windows.Forms.Label();
            this.dgOrcamento = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorPrazo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorVista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.btnEmitir = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.cbVendedor = new System.Windows.Forms.ComboBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.mtbHora = new System.Windows.Forms.MaskedTextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.mtbData = new System.Windows.Forms.MaskedTextBox();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.cbDescricao = new System.Windows.Forms.ComboBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrcamento)).BeginInit();
            this.gbDetalhesPagamento.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(36, 10);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(42, 13);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Cliente:";
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Location = new System.Drawing.Point(19, 40);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(56, 13);
            this.lblVendedor.TabIndex = 4;
            this.lblVendedor.Text = "Vendedor:";
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(441, 314);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(258, 137);
            this.txtObs.TabIndex = 8;
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Location = new System.Drawing.Point(415, 317);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(29, 13);
            this.lblObs.TabIndex = 7;
            this.lblObs.Text = "Obs:";
            // 
            // dgOrcamento
            // 
            this.dgOrcamento.AllowUserToAddRows = false;
            this.dgOrcamento.AllowUserToDeleteRows = false;
            this.dgOrcamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOrcamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.descricao,
            this.quantidade,
            this.valorPrazo,
            this.valorVista,
            this.subtotal});
            this.dgOrcamento.Location = new System.Drawing.Point(225, 93);
            this.dgOrcamento.Name = "dgOrcamento";
            this.dgOrcamento.ReadOnly = true;
            this.dgOrcamento.Size = new System.Drawing.Size(609, 195);
            this.dgOrcamento.TabIndex = 9;
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
            this.valorPrazo.HeaderText = "Valor Á Prazo";
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
            this.gbDetalhesPagamento.Location = new System.Drawing.Point(46, 317);
            this.gbDetalhesPagamento.Name = "gbDetalhesPagamento";
            this.gbDetalhesPagamento.Size = new System.Drawing.Size(363, 95);
            this.gbDetalhesPagamento.TabIndex = 10;
            this.gbDetalhesPagamento.TabStop = false;
            this.gbDetalhesPagamento.Text = "Detalhes Pagamento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(133, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "R$";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "R$";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(258, 71);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
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
            this.lblAlteracao.Location = new System.Drawing.Point(238, 45);
            this.lblAlteracao.Name = "lblAlteracao";
            this.lblAlteracao.Size = new System.Drawing.Size(55, 13);
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
            this.lblSubTotal.Location = new System.Drawing.Point(238, 19);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(59, 13);
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
            this.mtbAP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbAP_KeyPress);
            // 
            // lblAgressimo
            // 
            this.lblAgressimo.AutoSize = true;
            this.lblAgressimo.Location = new System.Drawing.Point(5, 52);
            this.lblAgressimo.Name = "lblAgressimo";
            this.lblAgressimo.Size = new System.Drawing.Size(58, 13);
            this.lblAgressimo.TabIndex = 14;
            this.lblAgressimo.Text = "Agressimo:";
            // 
            // mtbAD
            // 
            this.mtbAD.Location = new System.Drawing.Point(86, 49);
            this.mtbAD.Name = "mtbAD";
            this.mtbAD.Size = new System.Drawing.Size(40, 20);
            this.mtbAD.TabIndex = 13;
            this.mtbAD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbAD_KeyPress);
            // 
            // mtbDP
            // 
            this.mtbDP.Location = new System.Drawing.Point(150, 20);
            this.mtbDP.Name = "mtbDP";
            this.mtbDP.Size = new System.Drawing.Size(40, 20);
            this.mtbDP.TabIndex = 12;
            this.mtbDP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbDP_KeyPress);
            // 
            // lblDesconto
            // 
            this.lblDesconto.AutoSize = true;
            this.lblDesconto.Location = new System.Drawing.Point(6, 23);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(56, 13);
            this.lblDesconto.TabIndex = 11;
            this.lblDesconto.Text = "Desconto:";
            // 
            // mtbDD
            // 
            this.mtbDD.Location = new System.Drawing.Point(86, 20);
            this.mtbDD.Name = "mtbDD";
            this.mtbDD.Size = new System.Drawing.Size(40, 20);
            this.mtbDD.TabIndex = 0;
            this.mtbDD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbDD_KeyPress);
            // 
            // btnEmitir
            // 
            this.btnEmitir.Location = new System.Drawing.Point(736, 322);
            this.btnEmitir.Name = "btnEmitir";
            this.btnEmitir.Size = new System.Drawing.Size(75, 23);
            this.btnEmitir.TabIndex = 13;
            this.btnEmitir.Text = "Emitir";
            this.btnEmitir.UseVisualStyleBackColor = true;
            this.btnEmitir.Click += new System.EventHandler(this.btnEmitir_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(736, 351);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 14;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(736, 380);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 15;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(736, 409);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 16;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // cbVendedor
            // 
            this.cbVendedor.FormattingEnabled = true;
            this.cbVendedor.Location = new System.Drawing.Point(75, 35);
            this.cbVendedor.Name = "cbVendedor";
            this.cbVendedor.Size = new System.Drawing.Size(232, 21);
            this.cbVendedor.TabIndex = 17;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(736, 47);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(33, 13);
            this.lblHora.TabIndex = 25;
            this.lblHora.Text = "Hora:";
            // 
            // mtbHora
            // 
            this.mtbHora.Location = new System.Drawing.Point(772, 44);
            this.mtbHora.Mask = "99:99";
            this.mtbHora.Name = "mtbHora";
            this.mtbHora.Size = new System.Drawing.Size(36, 20);
            this.mtbHora.TabIndex = 24;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(707, 22);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(33, 13);
            this.lblData.TabIndex = 23;
            this.lblData.Text = "Data:";
            // 
            // mtbData
            // 
            this.mtbData.Location = new System.Drawing.Point(739, 18);
            this.mtbData.Mask = "99/99/9999";
            this.mtbData.Name = "mtbData";
            this.mtbData.Size = new System.Drawing.Size(69, 20);
            this.mtbData.TabIndex = 22;
            // 
            // cbCliente
            // 
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(75, 6);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(232, 21);
            this.cbCliente.TabIndex = 27;
            // 
            // cbDescricao
            // 
            this.cbDescricao.FormattingEnabled = true;
            this.cbDescricao.Location = new System.Drawing.Point(73, 93);
            this.cbDescricao.Name = "cbDescricao";
            this.cbDescricao.Size = new System.Drawing.Size(110, 21);
            this.cbDescricao.TabIndex = 29;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(17, 98);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(58, 13);
            this.lblDescricao.TabIndex = 28;
            this.lblDescricao.Text = "Descrição:";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(74, 120);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(70, 20);
            this.txtQuantidade.TabIndex = 30;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(11, 124);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(65, 13);
            this.lblQuantidade.TabIndex = 31;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(14, 178);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 23);
            this.btnRemover.TabIndex = 32;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(108, 178);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 33;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(312, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(227, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Quantidade Item:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(318, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "Quantidade Item:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(321, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 42;
            this.label9.Text = "Código:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(362, 7);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(47, 20);
            this.txtCodigo.TabIndex = 41;
            // 
            // frmCadastrarOrcamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 484);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.cbDescricao);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.cbCliente);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.mtbHora);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.mtbData);
            this.Controls.Add(this.cbVendedor);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnEmitir);
            this.Controls.Add(this.gbDetalhesPagamento);
            this.Controls.Add(this.dgOrcamento);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(this.lblObs);
            this.Controls.Add(this.lblVendedor);
            this.Controls.Add(this.lblCliente);
            this.Name = "frmCadastrarOrcamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Orçamento";
            this.Load += new System.EventHandler(this.frmCadastrarOrcamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgOrcamento)).EndInit();
            this.gbDetalhesPagamento.ResumeLayout(false);
            this.gbDetalhesPagamento.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.GroupBox gbDetalhesPagamento;
        private System.Windows.Forms.Label lblAgressimo;
        private System.Windows.Forms.Label lblDesconto;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblAlteracao;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Button btnEmitir;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblData;
        public System.Windows.Forms.DataGridView dgOrcamento;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtObs;
        public System.Windows.Forms.MaskedTextBox mtbAP;
        public System.Windows.Forms.MaskedTextBox mtbAD;
        public System.Windows.Forms.MaskedTextBox mtbDP;
        public System.Windows.Forms.MaskedTextBox mtbDD;
        public System.Windows.Forms.MaskedTextBox mtbTotal;
        public System.Windows.Forms.MaskedTextBox mtbAteracoes;
        public System.Windows.Forms.MaskedTextBox mtbSubTotal;
        public System.Windows.Forms.ComboBox cbVendedor;
        public System.Windows.Forms.MaskedTextBox mtbHora;
        public System.Windows.Forms.MaskedTextBox mtbData;
        public System.Windows.Forms.ComboBox cbCliente;
        public System.Windows.Forms.ComboBox cbDescricao;
        public System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorPrazo;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorVista;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtCodigo;
    }
}