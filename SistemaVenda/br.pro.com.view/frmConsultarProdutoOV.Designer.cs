namespace SistemaVenda.br.pro.com.view
{
    partial class frmConsultarProdutoOV
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
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.dgCPOV = new System.Windows.Forms.DataGridView();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblPesquisar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgCPOV)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(362, 56);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 19;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // dgCPOV
            // 
            this.dgCPOV.AllowUserToAddRows = false;
            this.dgCPOV.AllowUserToDeleteRows = false;
            this.dgCPOV.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgCPOV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCPOV.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgCPOV.Location = new System.Drawing.Point(28, 122);
            this.dgCPOV.Name = "dgCPOV";
            this.dgCPOV.ReadOnly = true;
            this.dgCPOV.Size = new System.Drawing.Size(744, 273);
            this.dgCPOV.TabIndex = 18;
            this.dgCPOV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCPOV_CellClick);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(112, 58);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(229, 20);
            this.txtNome.TabIndex = 17;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Location = new System.Drawing.Point(50, 61);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(56, 13);
            this.lblPesquisar.TabIndex = 16;
            this.lblPesquisar.Text = "Pesquisar:";
            // 
            // frmConsultarProdutoOV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.dgCPOV);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblPesquisar);
            this.Name = "frmConsultarProdutoOV";
            this.Text = "Consultar Produto";
            this.Load += new System.EventHandler(this.frmConsultarProdutoOV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCPOV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnPesquisar;
        public System.Windows.Forms.DataGridView dgCPOV;
        public System.Windows.Forms.TextBox txtNome;
        public System.Windows.Forms.Label lblPesquisar;
    }
}