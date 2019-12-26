namespace GUI
{
    partial class Form_DetailNSX
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbMaNSX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbTenNSX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbDiaChi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.txbSDT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtgvDsHangHoa = new System.Windows.Forms.DataGridView();
            this.txbKeyword = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDsHangHoa)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã NSX";
            // 
            // txbMaNSX
            // 
            this.txbMaNSX.Location = new System.Drawing.Point(65, 15);
            this.txbMaNSX.Name = "txbMaNSX";
            this.txbMaNSX.ReadOnly = true;
            this.txbMaNSX.Size = new System.Drawing.Size(126, 20);
            this.txbMaNSX.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên NSX";
            // 
            // txbTenNSX
            // 
            this.txbTenNSX.Location = new System.Drawing.Point(65, 42);
            this.txbTenNSX.Name = "txbTenNSX";
            this.txbTenNSX.ReadOnly = true;
            this.txbTenNSX.Size = new System.Drawing.Size(182, 20);
            this.txbTenNSX.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Địa chỉ";
            // 
            // txbDiaChi
            // 
            this.txbDiaChi.Location = new System.Drawing.Point(65, 71);
            this.txbDiaChi.Name = "txbDiaChi";
            this.txbDiaChi.ReadOnly = true;
            this.txbDiaChi.Size = new System.Drawing.Size(182, 20);
            this.txbDiaChi.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(259, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email";
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(297, 19);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.ReadOnly = true;
            this.txbEmail.Size = new System.Drawing.Size(158, 20);
            this.txbEmail.TabIndex = 7;
            // 
            // txbSDT
            // 
            this.txbSDT.Location = new System.Drawing.Point(297, 46);
            this.txbSDT.Name = "txbSDT";
            this.txbSDT.ReadOnly = true;
            this.txbSDT.Size = new System.Drawing.Size(158, 20);
            this.txbSDT.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(259, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "SĐT";
            // 
            // dtgvDsHangHoa
            // 
            this.dtgvDsHangHoa.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgvDsHangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDsHangHoa.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dtgvDsHangHoa.Location = new System.Drawing.Point(3, 134);
            this.dtgvDsHangHoa.Name = "dtgvDsHangHoa";
            this.dtgvDsHangHoa.Size = new System.Drawing.Size(461, 193);
            this.dtgvDsHangHoa.TabIndex = 10;
            // 
            // txbKeyword
            // 
            this.txbKeyword.Location = new System.Drawing.Point(220, 108);
            this.txbKeyword.Name = "txbKeyword";
            this.txbKeyword.Size = new System.Drawing.Size(209, 20);
            this.txbKeyword.TabIndex = 12;
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = global::GUI.Properties.Resources.search_icon;
            this.btnSearch.Location = new System.Drawing.Point(430, 108);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(20, 20);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Form_DetailNSX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(467, 329);
            this.Controls.Add(this.txbKeyword);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dtgvDsHangHoa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbSDT);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbDiaChi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbTenNSX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbMaNSX);
            this.Controls.Add(this.label1);
            this.Name = "Form_DetailNSX";
            this.Text = "Form_DetailNSX";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDsHangHoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbMaNSX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbTenNSX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbDiaChi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.TextBox txbSDT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtgvDsHangHoa;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txbKeyword;
    }
}