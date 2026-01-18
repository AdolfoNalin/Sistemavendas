namespace SistemaVenda.View
{
    partial class frmAccountWriteOff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccountWriteOff));
            this.lblClient = new System.Windows.Forms.Label();
            this.txtClient = new System.Windows.Forms.TextBox();
            this.dgAccountOff = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPayOff = new System.Windows.Forms.Button();
            this.txtSelect = new System.Windows.Forms.TextBox();
            this.lblSelect = new System.Windows.Forms.Label();
            this.txtOpen = new System.Windows.Forms.TextBox();
            this.lblOpen = new System.Windows.Forms.Label();
            this.btnSearchClient = new System.Windows.Forms.Button();
            this.btnUploadInstallment = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgAccountOff)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClient.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblClient.Location = new System.Drawing.Point(31, 25);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(50, 13);
            this.lblClient.TabIndex = 0;
            this.lblClient.Text = "Cliente:";
            // 
            // txtClient
            // 
            this.txtClient.Location = new System.Drawing.Point(83, 22);
            this.txtClient.Name = "txtClient";
            this.txtClient.Size = new System.Drawing.Size(350, 20);
            this.txtClient.TabIndex = 1;
            this.txtClient.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtClient_KeyDown);
            // 
            // dgAccountOff
            // 
            this.dgAccountOff.AllowUserToAddRows = false;
            this.dgAccountOff.AllowUserToDeleteRows = false;
            this.dgAccountOff.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgAccountOff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAccountOff.Location = new System.Drawing.Point(80, 79);
            this.dgAccountOff.Name = "dgAccountOff";
            this.dgAccountOff.ReadOnly = true;
            this.dgAccountOff.Size = new System.Drawing.Size(621, 264);
            this.dgAccountOff.TabIndex = 2;
            this.dgAccountOff.DoubleClick += new System.EventHandler(this.dgAccountOff_DoubleClick);
            this.dgAccountOff.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgAccountOff_KeyDown);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnCancel.Location = new System.Drawing.Point(80, 365);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(93, 42);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnPayOff
            // 
            this.btnPayOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayOff.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnPayOff.Location = new System.Drawing.Point(608, 365);
            this.btnPayOff.Name = "btnPayOff";
            this.btnPayOff.Size = new System.Drawing.Size(93, 42);
            this.btnPayOff.TabIndex = 4;
            this.btnPayOff.Text = "Quitar";
            this.btnPayOff.UseVisualStyleBackColor = true;
            this.btnPayOff.Click += new System.EventHandler(this.btnPayOff_Click);
            // 
            // txtSelect
            // 
            this.txtSelect.Location = new System.Drawing.Point(517, 378);
            this.txtSelect.Name = "txtSelect";
            this.txtSelect.Size = new System.Drawing.Size(59, 20);
            this.txtSelect.TabIndex = 8;
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelect.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblSelect.Location = new System.Drawing.Point(441, 381);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(81, 13);
            this.lblSelect.TabIndex = 7;
            this.lblSelect.Text = "Selecionado:";
            // 
            // txtOpen
            // 
            this.txtOpen.Location = new System.Drawing.Point(346, 378);
            this.txtOpen.Name = "txtOpen";
            this.txtOpen.Size = new System.Drawing.Size(59, 20);
            this.txtOpen.TabIndex = 10;
            // 
            // lblOpen
            // 
            this.lblOpen.AutoSize = true;
            this.lblOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpen.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblOpen.Location = new System.Drawing.Point(283, 381);
            this.lblOpen.Name = "lblOpen";
            this.lblOpen.Size = new System.Drawing.Size(61, 13);
            this.lblOpen.TabIndex = 9;
            this.lblOpen.Text = "EmAberto";
            // 
            // btnSearchClient
            // 
            this.btnSearchClient.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchClient.Image")));
            this.btnSearchClient.Location = new System.Drawing.Point(444, 14);
            this.btnSearchClient.Name = "btnSearchClient";
            this.btnSearchClient.Size = new System.Drawing.Size(34, 34);
            this.btnSearchClient.TabIndex = 11;
            this.btnSearchClient.UseVisualStyleBackColor = true;
            this.btnSearchClient.Click += new System.EventHandler(this.btnSearchClient_Click);
            // 
            // btnUploadInstallment
            // 
            this.btnUploadInstallment.Image = ((System.Drawing.Image)(resources.GetObject("btnUploadInstallment.Image")));
            this.btnUploadInstallment.Location = new System.Drawing.Point(608, 21);
            this.btnUploadInstallment.Name = "btnUploadInstallment";
            this.btnUploadInstallment.Size = new System.Drawing.Size(69, 28);
            this.btnUploadInstallment.TabIndex = 12;
            this.btnUploadInstallment.UseVisualStyleBackColor = true;
            this.btnUploadInstallment.Click += new System.EventHandler(this.btnUploadInstallment_Click);
            // 
            // frmAccountWriteOff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUploadInstallment);
            this.Controls.Add(this.btnSearchClient);
            this.Controls.Add(this.txtOpen);
            this.Controls.Add(this.lblOpen);
            this.Controls.Add(this.txtSelect);
            this.Controls.Add(this.lblSelect);
            this.Controls.Add(this.btnPayOff);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dgAccountOff);
            this.Controls.Add(this.txtClient);
            this.Controls.Add(this.lblClient);
            this.Name = "frmAccountWriteOff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Baixa Em Conta";
            this.Load += new System.EventHandler(this.frmAccountWriteOff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAccountOff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.TextBox txtClient;
        private System.Windows.Forms.DataGridView dgAccountOff;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPayOff;
        private System.Windows.Forms.TextBox txtSelect;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.TextBox txtOpen;
        private System.Windows.Forms.Label lblOpen;
        private System.Windows.Forms.Button btnSearchClient;
        private System.Windows.Forms.Button btnUploadInstallment;
    }
}