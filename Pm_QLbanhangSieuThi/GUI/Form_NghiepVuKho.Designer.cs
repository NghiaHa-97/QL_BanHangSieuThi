namespace GUI
{
    partial class Form_NghiepVuKho
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
            this.toolStripKiemKeKho = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnNhapKho = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnXuatKho = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnExit = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaThuKho = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerNLP = new System.Windows.Forms.DateTimePicker();
            this.cbKho = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbDiaDiem = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtgvXuatNhapTon = new System.Windows.Forms.DataGridView();
            this.txbTenKho = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbTuNgay = new System.Windows.Forms.TextBox();
            this.toolStripKiemKeKho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvXuatNhapTon)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripKiemKeKho
            // 
            this.toolStripKiemKeKho.AutoSize = false;
            this.toolStripKiemKeKho.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnPrint,
            this.toolStripBtnNhapKho,
            this.toolStripBtnXuatKho,
            this.toolStripBtnExit});
            this.toolStripKiemKeKho.Location = new System.Drawing.Point(0, 0);
            this.toolStripKiemKeKho.Name = "toolStripKiemKeKho";
            this.toolStripKiemKeKho.Size = new System.Drawing.Size(800, 40);
            this.toolStripKiemKeKho.TabIndex = 0;
            // 
            // toolStripBtnPrint
            // 
            this.toolStripBtnPrint.AutoSize = false;
            this.toolStripBtnPrint.Image = global::GUI.Properties.Resources.print_icon1;
            this.toolStripBtnPrint.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnPrint.Name = "toolStripBtnPrint";
            this.toolStripBtnPrint.Size = new System.Drawing.Size(180, 40);
            this.toolStripBtnPrint.Text = "In báo cáo xuất nhập tồn";
            // 
            // toolStripBtnNhapKho
            // 
            this.toolStripBtnNhapKho.AutoSize = false;
            this.toolStripBtnNhapKho.DoubleClickEnabled = true;
            this.toolStripBtnNhapKho.Image = global::GUI.Properties.Resources.import_icon;
            this.toolStripBtnNhapKho.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnNhapKho.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnNhapKho.Name = "toolStripBtnNhapKho";
            this.toolStripBtnNhapKho.Size = new System.Drawing.Size(100, 40);
            this.toolStripBtnNhapKho.Text = "Nhập kho";
            this.toolStripBtnNhapKho.Click += new System.EventHandler(this.toolStripBtnNhapKho_Click);
            // 
            // toolStripBtnXuatKho
            // 
            this.toolStripBtnXuatKho.AutoSize = false;
            this.toolStripBtnXuatKho.Image = global::GUI.Properties.Resources.export_icon;
            this.toolStripBtnXuatKho.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnXuatKho.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnXuatKho.Name = "toolStripBtnXuatKho";
            this.toolStripBtnXuatKho.Size = new System.Drawing.Size(100, 40);
            this.toolStripBtnXuatKho.Text = "Xuất kho";
            this.toolStripBtnXuatKho.Click += new System.EventHandler(this.toolStripBtnXuatKho_Click);
            // 
            // toolStripBtnExit
            // 
            this.toolStripBtnExit.AutoSize = false;
            this.toolStripBtnExit.Image = global::GUI.Properties.Resources.Bookmark_delete_icon1;
            this.toolStripBtnExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnExit.Name = "toolStripBtnExit";
            this.toolStripBtnExit.Size = new System.Drawing.Size(80, 40);
            this.toolStripBtnExit.Text = "Thoát";
            this.toolStripBtnExit.Click += new System.EventHandler(this.toolStripBtnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã thủ kho:";
            // 
            // txtMaThuKho
            // 
            this.txtMaThuKho.Location = new System.Drawing.Point(92, 43);
            this.txtMaThuKho.Name = "txtMaThuKho";
            this.txtMaThuKho.ReadOnly = true;
            this.txtMaThuKho.Size = new System.Drawing.Size(153, 20);
            this.txtMaThuKho.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên thủ kho:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(353, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ngày lập phiếu:";
            // 
            // dateTimePickerNLP
            // 
            this.dateTimePickerNLP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerNLP.Location = new System.Drawing.Point(440, 72);
            this.dateTimePickerNLP.Name = "dateTimePickerNLP";
            this.dateTimePickerNLP.Size = new System.Drawing.Size(108, 20);
            this.dateTimePickerNLP.TabIndex = 6;
            this.dateTimePickerNLP.ValueChanged += new System.EventHandler(this.dateTimePickerNLP_ValueChanged);
            // 
            // cbKho
            // 
            this.cbKho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKho.FormattingEnabled = true;
            this.cbKho.Location = new System.Drawing.Point(92, 117);
            this.cbKho.Name = "cbKho";
            this.cbKho.Size = new System.Drawing.Size(209, 21);
            this.cbKho.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kho:";
            // 
            // txbDiaDiem
            // 
            this.txbDiaDiem.Location = new System.Drawing.Point(440, 118);
            this.txbDiaDiem.Name = "txbDiaDiem";
            this.txbDiaDiem.ReadOnly = true;
            this.txbDiaDiem.Size = new System.Drawing.Size(209, 20);
            this.txbDiaDiem.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(353, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Địa điểm:";
            // 
            // dtgvXuatNhapTon
            // 
            this.dtgvXuatNhapTon.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgvXuatNhapTon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvXuatNhapTon.Location = new System.Drawing.Point(25, 153);
            this.dtgvXuatNhapTon.Name = "dtgvXuatNhapTon";
            this.dtgvXuatNhapTon.Size = new System.Drawing.Size(763, 293);
            this.dtgvXuatNhapTon.TabIndex = 11;
            // 
            // txbTenKho
            // 
            this.txbTenKho.Location = new System.Drawing.Point(92, 71);
            this.txbTenKho.Name = "txbTenKho";
            this.txbTenKho.ReadOnly = true;
            this.txbTenKho.Size = new System.Drawing.Size(209, 20);
            this.txbTenKho.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(353, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Từ Ngày:";
            // 
            // txbTuNgay
            // 
            this.txbTuNgay.Location = new System.Drawing.Point(440, 39);
            this.txbTuNgay.Name = "txbTuNgay";
            this.txbTuNgay.ReadOnly = true;
            this.txbTuNgay.Size = new System.Drawing.Size(108, 20);
            this.txbTuNgay.TabIndex = 15;
            // 
            // Form_NghiepVuKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txbTuNgay);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbTenKho);
            this.Controls.Add(this.dtgvXuatNhapTon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbDiaDiem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbKho);
            this.Controls.Add(this.dateTimePickerNLP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaThuKho);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStripKiemKeKho);
            this.Name = "Form_NghiepVuKho";
            this.Text = "FormQL_XuatNhapTon";
            this.toolStripKiemKeKho.ResumeLayout(false);
            this.toolStripKiemKeKho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvXuatNhapTon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripKiemKeKho;
        private System.Windows.Forms.ToolStripButton toolStripBtnPrint;
        private System.Windows.Forms.ToolStripButton toolStripBtnNhapKho;
        private System.Windows.Forms.ToolStripButton toolStripBtnXuatKho;
        private System.Windows.Forms.ToolStripButton toolStripBtnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaThuKho;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerNLP;
        private System.Windows.Forms.ComboBox cbKho;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbDiaDiem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtgvXuatNhapTon;
        private System.Windows.Forms.TextBox txbTenKho;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbTuNgay;
    }
}