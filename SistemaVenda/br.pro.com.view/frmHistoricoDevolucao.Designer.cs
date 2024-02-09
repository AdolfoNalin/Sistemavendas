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
            this.textBox2.Location = new System.Drawing.Point(570, 312);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(341, 113);
            this.textBox2.TabIndex = 21;
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObs.Location = new System.Drawing.Point(533, 316);
            this.lblObs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(33, 13);
            this.lblObs.TabIndex = 20;
            this.lblObs.Text = "Obs:";
            // 
            // dgConsutarOrcamento
            // 
            this.dgConsutarOrcamento.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgConsutarOrcamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgConsutarOrcamento.Location = new System.Drawing.Point(286, 28);
            this.dgConsutarOrcamento.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgConsutarOrcamento.Name = "dgConsutarOrcamento";
            this.dgConsutarOrcamento.Size = new System.Drawing.Size(626, 266);
            this.dgConsutarOrcamento.TabIndex = 19;
            // 
            // lblDataInicio
            // 
            this.lblDataInicio.AutoSize = true;
            this.lblDataInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataInicio.Location = new System.Drawing.Point(24, 65);
            this.lblDataInicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataInicio.Name = "lblDataInicio";
            this.lblDataInicio.Size = new System.Drawing.Size(75, 13);
            this.lblDataInicio.TabIndex = 17;
            this.lblDataInicio.Text = "Data Início:";
            // 
            // lblDataFim
            // 
            this.lblDataFim.AutoSize = true;
            this.lblDataFim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataFim.Location = new System.Drawing.Point(37, 90);
            this.lblDataFim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataFim.Name = "lblDataFim";
            this.lblDataFim.Size = new System.Drawing.Size(61, 13);
            this.lblDataFim.TabIndex = 16;
            this.lblDataFim.Text = "Data Fim:";
            // 
            // txtCodigoDevolucao
            // 
            this.txtCodigoDevolucao.Location = new System.Drawing.Point(75, 26);
            this.txtCodigoDevolucao.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCodigoDevolucao.Name = "txtCodigoDevolucao";
            this.txtCodigoDevolucao.Size = new System.Drawing.Size(68, 20);
            this.txtCodigoDevolucao.TabIndex = 15;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnPesquisar.Location = new System.Drawing.Point(56, 122);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(88, 23);
            this.btnPesquisar.TabIndex = 14;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // lblCodigoDevolução
            // 
            this.lblCodigoDevolução.AutoSize = true;
            this.lblCodigoDevolução.Location = new System.Drawing.Point(22, 27);
            this.lblCodigoDevolução.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoDevolução.Name = "lblCodigoDevolução";
            this.lblCodigoDevolução.Size = new System.Drawing.Size(50, 13);
            this.lblCodigoDevolução.TabIndex = 13;
            this.lblCodigoDevolução.Text = "Código:";
            // 
            // dtpDataFim
            // 
            this.dtpDataFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFim.Location = new System.Drawing.Point(99, 87);
            this.dtpDataFim.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpDataFim.Name = "dtpDataFim";
            this.dtpDataFim.Size = new System.Drawing.Size(111, 20);
            this.dtpDataFim.TabIndex = 12;
            // 
            // dtpDataInicio
            // 
            this.dtpDataInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInicio.Location = new System.Drawing.Point(99, 61);
            this.dtpDataInicio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpDataInicio.Name = "dtpDataInicio";
            this.dtpDataInicio.Size = new System.Drawing.Size(111, 20);
            this.dtpDataInicio.TabIndex = 11;
            // 
            // frmHistoricoDevolucao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblObs);
            this.Controls.Add(this.dgConsutarOrcamento);
            this.Controls.Add(this.lblDataInicio);
            this.Controls.Add(this.lblDataFim);
            this.Controls.Add(this.txtCodigoDevolucao);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.lblCodigoDevolução);
            this.Controls.Add(this.dtpDataFim);
            this.Controls.Add(this.dtpDataInicio);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmHistoricoDevolucao";
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
        private System.Windows.Forms.Label lblDataInicio;
        private System.Windows.Forms.Label lblDataFim;
        private System.Windows.Forms.TextBox txtCodigoDevolucao;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label lblCodigoDevolução;
        private System.Windows.Forms.DateTimePicker dtpDataFim;
        private System.Windows.Forms.DateTimePicker dtpDataInicio;
    }
}