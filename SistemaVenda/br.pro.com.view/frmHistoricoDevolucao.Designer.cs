namespace SistemaVenda.br.pro.com.view
{
    partial class frmHistoricoDevolucao
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblObs = new System.Windows.Forms.Label();
            this.dgConsutarOrcamento = new System.Windows.Forms.DataGridView();
            this.cbPesquisarData = new System.Windows.Forms.CheckBox();
            this.lblDataInicio = new System.Windows.Forms.Label();
            this.lblDataFim = new System.Windows.Forms.Label();
            this.txtCodigoDevolucao = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.lblCodigoDevolução = new System.Windows.Forms.Label();
            this.dtpDataFim = new System.Windows.Forms.DateTimePicker();
            this.dtpDataInicio = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgConsutarOrcamento)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(489, 312);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(293, 113);
            this.textBox2.TabIndex = 21;
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Location = new System.Drawing.Point(457, 316);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(29, 13);
            this.lblObs.TabIndex = 20;
            this.lblObs.Text = "Obs:";
            // 
            // dgConsutarOrcamento
            // 
            this.dgConsutarOrcamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgConsutarOrcamento.Location = new System.Drawing.Point(245, 28);
            this.dgConsutarOrcamento.Name = "dgConsutarOrcamento";
            this.dgConsutarOrcamento.Size = new System.Drawing.Size(537, 266);
            this.dgConsutarOrcamento.TabIndex = 19;
            // 
            // cbPesquisarData
            // 
            this.cbPesquisarData.AutoSize = true;
            this.cbPesquisarData.Location = new System.Drawing.Point(141, 28);
            this.cbPesquisarData.Name = "cbPesquisarData";
            this.cbPesquisarData.Size = new System.Drawing.Size(98, 17);
            this.cbPesquisarData.TabIndex = 18;
            this.cbPesquisarData.Text = "Pesquisar Data";
            this.cbPesquisarData.UseVisualStyleBackColor = true;
            // 
            // lblDataInicio
            // 
            this.lblDataInicio.AutoSize = true;
            this.lblDataInicio.Location = new System.Drawing.Point(21, 65);
            this.lblDataInicio.Name = "lblDataInicio";
            this.lblDataInicio.Size = new System.Drawing.Size(63, 13);
            this.lblDataInicio.TabIndex = 17;
            this.lblDataInicio.Text = "Data Início:";
            // 
            // lblDataFim
            // 
            this.lblDataFim.AutoSize = true;
            this.lblDataFim.Location = new System.Drawing.Point(32, 90);
            this.lblDataFim.Name = "lblDataFim";
            this.lblDataFim.Size = new System.Drawing.Size(52, 13);
            this.lblDataFim.TabIndex = 16;
            this.lblDataFim.Text = "Data Fim:";
            // 
            // txtCodigoDevolucao
            // 
            this.txtCodigoDevolucao.Location = new System.Drawing.Point(64, 26);
            this.txtCodigoDevolucao.Name = "txtCodigoDevolucao";
            this.txtCodigoDevolucao.Size = new System.Drawing.Size(59, 20);
            this.txtCodigoDevolucao.TabIndex = 15;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(48, 122);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 14;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // lblCodigoDevolução
            // 
            this.lblCodigoDevolução.AutoSize = true;
            this.lblCodigoDevolução.Location = new System.Drawing.Point(19, 27);
            this.lblCodigoDevolução.Name = "lblCodigoDevolução";
            this.lblCodigoDevolução.Size = new System.Drawing.Size(43, 13);
            this.lblCodigoDevolução.TabIndex = 13;
            this.lblCodigoDevolução.Text = "Código:";
            // 
            // dtpDataFim
            // 
            this.dtpDataFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFim.Location = new System.Drawing.Point(85, 87);
            this.dtpDataFim.Name = "dtpDataFim";
            this.dtpDataFim.Size = new System.Drawing.Size(96, 20);
            this.dtpDataFim.TabIndex = 12;
            // 
            // dtpDataInicio
            // 
            this.dtpDataInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInicio.Location = new System.Drawing.Point(85, 61);
            this.dtpDataInicio.Name = "dtpDataInicio";
            this.dtpDataInicio.Size = new System.Drawing.Size(96, 20);
            this.dtpDataInicio.TabIndex = 11;
            // 
            // frmConsultarDevolucaoProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblObs);
            this.Controls.Add(this.dgConsutarOrcamento);
            this.Controls.Add(this.cbPesquisarData);
            this.Controls.Add(this.lblDataInicio);
            this.Controls.Add(this.lblDataFim);
            this.Controls.Add(this.txtCodigoDevolucao);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.lblCodigoDevolução);
            this.Controls.Add(this.dtpDataFim);
            this.Controls.Add(this.dtpDataInicio);
            this.Name = "frmConsultarDevolucaoProduto";
            this.Text = "Consultar Devolução Produto";
            this.Load += new System.EventHandler(this.frmConsultarDevolucaoProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgConsutarOrcamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.DataGridView dgConsutarOrcamento;
        private System.Windows.Forms.CheckBox cbPesquisarData;
        private System.Windows.Forms.Label lblDataInicio;
        private System.Windows.Forms.Label lblDataFim;
        private System.Windows.Forms.TextBox txtCodigoDevolucao;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label lblCodigoDevolução;
        private System.Windows.Forms.DateTimePicker dtpDataFim;
        private System.Windows.Forms.DateTimePicker dtpDataInicio;
    }
}