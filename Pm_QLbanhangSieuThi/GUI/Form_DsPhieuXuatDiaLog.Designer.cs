namespace GUI
{
    partial class Form_DsPhieuXuatDiaLog
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
            this.dtgvDsPhieuXuat = new System.Windows.Forms.DataGridView();
            this.btnToLastItem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDsPhieuXuat)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvDsPhieuXuat
            // 
            this.dtgvDsPhieuXuat.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgvDsPhieuXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDsPhieuXuat.Location = new System.Drawing.Point(2, 48);
            this.dtgvDsPhieuXuat.Name = "dtgvDsPhieuXuat";
            this.dtgvDsPhieuXuat.Size = new System.Drawing.Size(388, 201);
            this.dtgvDsPhieuXuat.TabIndex = 0;
            // 
            // btnToLastItem
            // 
            this.btnToLastItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToLastItem.Location = new System.Drawing.Point(275, 12);
            this.btnToLastItem.Name = "btnToLastItem";
            this.btnToLastItem.Size = new System.Drawing.Size(104, 30);
            this.btnToLastItem.TabIndex = 1;
            this.btnToLastItem.Text = "Phiếu cuối cùng";
            this.btnToLastItem.UseVisualStyleBackColor = true;
            this.btnToLastItem.Click += new System.EventHandler(this.btnToLastItem_Click);
            // 
            // Form_DsPhieuXuatDiaLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 243);
            this.Controls.Add(this.btnToLastItem);
            this.Controls.Add(this.dtgvDsPhieuXuat);
            this.Name = "Form_DsPhieuXuatDiaLog";
            this.Text = "Form_DsPhieuNhapDiaLog";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDsPhieuXuat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvDsPhieuXuat;
        private System.Windows.Forms.Button btnToLastItem;
    }
}