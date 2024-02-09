namespace SistemaVenda.br.pro.com.view
{
    partial class frmHistoricoVenda
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
            this.gbConsulta = new System.Windows.Forms.GroupBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.lblFim = new System.Windows.Forms.Label();
            this.dtpFim = new System.Windows.Forms.DateTimePicker();
            this.lblInicio = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.dgHistorico = new System.Windows.Forms.DataGridView();
            this.gbConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgHistorico)).BeginInit();
            this.SuspendLayout();
            // 
            // gbConsulta
            // 
            this.gbConsulta.Controls.Add(this.btnPesquisar);
            this.gbConsulta.Controls.Add(this.lblFim);
            this.gbConsulta.Controls.Add(this.dtpFim);
            this.gbConsulta.Controls.Add(this.lblInicio);
            this.gbConsulta.Controls.Add(this.dtpInicio);
            this.gbConsulta.Location = new System.Drawing.Point(14, 12);
            this.gbConsulta.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbConsulta.Name = "gbConsulta";
            this.gbConsulta.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbConsulta.Size = new System.Drawing.Size(307, 122);
            this.gbConsulta.TabIndex = 0;
            this.gbConsulta.TabStop = false;
            this.gbConsulta.Text = "Consulta";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnPesquisar.Location = new System.Drawing.Point(93, 77);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(98, 33);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // lblFim
            // 
            this.lblFim.AutoSize = true;
            this.lblFim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFim.Location = new System.Drawing.Point(50, 48);
            this.lblFim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFim.Name = "lblFim";
            this.lblFim.Size = new System.Drawing.Size(61, 13);
            this.lblFim.TabIndex = 3;
            this.lblFim.Text = "Data Fim:";
            // 
            // dtpFim
            // 
            this.dtpFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFim.Location = new System.Drawing.Point(118, 45);
            this.dtpFim.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpFim.Name = "dtpFim";
            this.dtpFim.Size = new System.Drawing.Size(110, 20);
            this.dtpFim.TabIndex = 2;
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicio.Location = new System.Drawing.Point(40, 23);
            this.lblInicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(73, 13);
            this.lblInicio.TabIndex = 2;
            this.lblInicio.Text = "Data Inicio:";
            // 
            // dtpInicio
            // 
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(118, 19);
            this.dtpInicio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(110, 20);
            this.dtpInicio.TabIndex = 3;
            // 
            // dgHistorico
            // 
            this.dgHistorico.AllowUserToAddRows = false;
            this.dgHistorico.AllowUserToDeleteRows = false;
            this.dgHistorico.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHistorico.Location = new System.Drawing.Point(328, 12);
            this.dgHistorico.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgHistorico.Name = "dgHistorico";
            this.dgHistorico.ReadOnly = true;
            this.dgHistorico.Size = new System.Drawing.Size(592, 323);
            this.dgHistorico.TabIndex = 1;
            this.dgHistorico.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgHistorico_CellClick);
            // 
            // frmHistoricoVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.dgHistorico);
            this.Controls.Add(this.gbConsulta);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmHistoricoVenda";
            this.Text = "Historico de Venda";
            this.Load += new System.EventHandler(this.frmHistoricoVenda_Load);
            this.gbConsulta.ResumeLayout(false);
            this.gbConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgHistorico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbConsulta;
        private System.Windows.Forms.DataGridView dgHistorico;
        private System.Windows.Forms.DateTimePicker dtpFim;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label lblFim;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.DateTimePicker dtpInicio;
    }
}