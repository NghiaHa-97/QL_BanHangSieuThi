namespace GUI
{
    partial class FormHangHoa
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxDM = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonXoaDM = new System.Windows.Forms.Button();
            this.buttonSuaDM = new System.Windows.Forms.Button();
            this.buttonThemDM = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBoxNhaSX = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBoxDM = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonTimKiem = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonXoaSP = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSuaSP = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonThemSP = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSoLuong = new System.Windows.Forms.TextBox();
            this.textBoxViTri = new System.Windows.Forms.TextBox();
            this.dateTimePickerHSD = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxGia = new System.Windows.Forms.TextBox();
            this.dateTimePickerNSX = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxMaHang = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxTenHang = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listViewDSHH = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(1593, 756);
            this.splitContainer1.SplitterDistance = 351;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxDM);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.toolStrip1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 756);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Mục Chủng Loại";
            // 
            // listBoxDM
            // 
            this.listBoxDM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxDM.FormattingEnabled = true;
            this.listBoxDM.ItemHeight = 25;
            this.listBoxDM.Location = new System.Drawing.Point(3, 51);
            this.listBoxDM.Name = "listBoxDM";
            this.listBoxDM.Size = new System.Drawing.Size(345, 551);
            this.listBoxDM.TabIndex = 2;
            this.listBoxDM.SelectedIndexChanged += new System.EventHandler(this.listBoxDM_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.buttonXoaDM);
            this.panel1.Controls.Add(this.buttonSuaDM);
            this.panel1.Controls.Add(this.buttonThemDM);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 602);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 151);
            this.panel1.TabIndex = 1;
            // 
            // buttonXoaDM
            // 
            this.buttonXoaDM.Location = new System.Drawing.Point(206, 84);
            this.buttonXoaDM.Name = "buttonXoaDM";
            this.buttonXoaDM.Size = new System.Drawing.Size(75, 45);
            this.buttonXoaDM.TabIndex = 2;
            this.buttonXoaDM.Text = "Xóa";
            this.buttonXoaDM.UseVisualStyleBackColor = true;
            this.buttonXoaDM.Click += new System.EventHandler(this.buttonXoaDM_Click);
            // 
            // buttonSuaDM
            // 
            this.buttonSuaDM.Location = new System.Drawing.Point(116, 84);
            this.buttonSuaDM.Name = "buttonSuaDM";
            this.buttonSuaDM.Size = new System.Drawing.Size(75, 45);
            this.buttonSuaDM.TabIndex = 1;
            this.buttonSuaDM.Text = "Sửa";
            this.buttonSuaDM.UseVisualStyleBackColor = true;
            this.buttonSuaDM.Click += new System.EventHandler(this.buttonSuaDM_Click);
            // 
            // buttonThemDM
            // 
            this.buttonThemDM.Location = new System.Drawing.Point(19, 84);
            this.buttonThemDM.Name = "buttonThemDM";
            this.buttonThemDM.Size = new System.Drawing.Size(75, 45);
            this.buttonThemDM.TabIndex = 0;
            this.buttonThemDM.Text = "Thêm";
            this.buttonThemDM.UseVisualStyleBackColor = true;
            this.buttonThemDM.Click += new System.EventHandler(this.buttonThemDM_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Location = new System.Drawing.Point(3, 26);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(345, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.comboBoxNhaSX);
            this.groupBox3.Controls.Add(this.comboBox2);
            this.groupBox3.Controls.Add(this.comboBoxDM);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.buttonTimKiem);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.buttonXoaSP);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.buttonSuaSP);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.buttonThemSP);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.textBoxSoLuong);
            this.groupBox3.Controls.Add(this.textBoxViTri);
            this.groupBox3.Controls.Add(this.dateTimePickerHSD);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.textBoxGia);
            this.groupBox3.Controls.Add(this.dateTimePickerNSX);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.textBoxMaHang);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.textBoxTenHang);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(0, 306);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1238, 450);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi Tiết Sản Phẩm";
            // 
            // comboBoxNhaSX
            // 
            this.comboBoxNhaSX.FormattingEnabled = true;
            this.comboBoxNhaSX.Location = new System.Drawing.Point(630, 167);
            this.comboBoxNhaSX.Name = "comboBoxNhaSX";
            this.comboBoxNhaSX.Size = new System.Drawing.Size(280, 33);
            this.comboBoxNhaSX.TabIndex = 7;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(630, 167);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(212, 33);
            this.comboBox2.TabIndex = 7;
            // 
            // comboBoxDM
            // 
            this.comboBoxDM.FormattingEnabled = true;
            this.comboBoxDM.Location = new System.Drawing.Point(149, 168);
            this.comboBoxDM.Name = "comboBoxDM";
            this.comboBoxDM.Size = new System.Drawing.Size(280, 33);
            this.comboBoxDM.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(149, 168);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(212, 33);
            this.comboBox1.TabIndex = 7;
            // 
            // buttonTimKiem
            // 
            this.buttonTimKiem.Location = new System.Drawing.Point(474, 341);
            this.buttonTimKiem.Name = "buttonTimKiem";
            this.buttonTimKiem.Size = new System.Drawing.Size(101, 65);
            this.buttonTimKiem.TabIndex = 6;
            this.buttonTimKiem.Text = "Tìm Kiếm";
            this.buttonTimKiem.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(952, 364);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(109, 50);
            this.button4.TabIndex = 5;
            this.button4.Text = "Thoát";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Hàng";
            // 
            // buttonXoaSP
            // 
            this.buttonXoaSP.Location = new System.Drawing.Point(354, 341);
            this.buttonXoaSP.Name = "buttonXoaSP";
            this.buttonXoaSP.Size = new System.Drawing.Size(75, 65);
            this.buttonXoaSP.TabIndex = 4;
            this.buttonXoaSP.Text = "Xóa";
            this.buttonXoaSP.UseVisualStyleBackColor = true;
            this.buttonXoaSP.Click += new System.EventHandler(this.buttonXoaSP_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Hàng";
            // 
            // buttonSuaSP
            // 
            this.buttonSuaSP.Location = new System.Drawing.Point(249, 341);
            this.buttonSuaSP.Name = "buttonSuaSP";
            this.buttonSuaSP.Size = new System.Drawing.Size(75, 65);
            this.buttonSuaSP.TabIndex = 4;
            this.buttonSuaSP.Text = "Sửa";
            this.buttonSuaSP.UseVisualStyleBackColor = true;
            this.buttonSuaSP.Click += new System.EventHandler(this.buttonSuaSP_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Danh Mục";
            // 
            // buttonThemSP
            // 
            this.buttonThemSP.Location = new System.Drawing.Point(140, 341);
            this.buttonThemSP.Name = "buttonThemSP";
            this.buttonThemSP.Size = new System.Drawing.Size(75, 65);
            this.buttonThemSP.TabIndex = 4;
            this.buttonThemSP.Text = "Thêm";
            this.buttonThemSP.UseVisualStyleBackColor = true;
            this.buttonThemSP.Click += new System.EventHandler(this.buttonThemSP_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "NSX";
            // 
            // textBoxSoLuong
            // 
            this.textBoxSoLuong.Location = new System.Drawing.Point(630, 68);
            this.textBoxSoLuong.Name = "textBoxSoLuong";
            this.textBoxSoLuong.Size = new System.Drawing.Size(280, 30);
            this.textBoxSoLuong.TabIndex = 1;
            // 
            // textBoxViTri
            // 
            this.textBoxViTri.Location = new System.Drawing.Point(630, 217);
            this.textBoxViTri.Name = "textBoxViTri";
            this.textBoxViTri.Size = new System.Drawing.Size(280, 30);
            this.textBoxViTri.TabIndex = 1;
            // 
            // dateTimePickerHSD
            // 
            this.dateTimePickerHSD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerHSD.Location = new System.Drawing.Point(149, 267);
            this.dateTimePickerHSD.Name = "dateTimePickerHSD";
            this.dateTimePickerHSD.Size = new System.Drawing.Size(280, 30);
            this.dateTimePickerHSD.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "HSD";
            // 
            // textBoxGia
            // 
            this.textBoxGia.Location = new System.Drawing.Point(630, 119);
            this.textBoxGia.Name = "textBoxGia";
            this.textBoxGia.Size = new System.Drawing.Size(280, 30);
            this.textBoxGia.TabIndex = 1;
            // 
            // dateTimePickerNSX
            // 
            this.dateTimePickerNSX.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerNSX.Location = new System.Drawing.Point(149, 219);
            this.dateTimePickerNSX.Name = "dateTimePickerNSX";
            this.dateTimePickerNSX.Size = new System.Drawing.Size(280, 30);
            this.dateTimePickerNSX.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(510, 218);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Vị trí";
            // 
            // textBoxMaHang
            // 
            this.textBoxMaHang.Location = new System.Drawing.Point(149, 74);
            this.textBoxMaHang.Name = "textBoxMaHang";
            this.textBoxMaHang.Size = new System.Drawing.Size(280, 30);
            this.textBoxMaHang.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(510, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Nhà SX";
            // 
            // textBoxTenHang
            // 
            this.textBoxTenHang.Location = new System.Drawing.Point(149, 122);
            this.textBoxTenHang.Name = "textBoxTenHang";
            this.textBoxTenHang.Size = new System.Drawing.Size(280, 30);
            this.textBoxTenHang.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(510, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Giá ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(510, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Số Luọng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listViewDSHH);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1238, 306);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách Hàng hóa";
            // 
            // listViewDSHH
            // 
            this.listViewDSHH.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.listViewDSHH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewDSHH.FullRowSelect = true;
            this.listViewDSHH.GridLines = true;
            this.listViewDSHH.HideSelection = false;
            this.listViewDSHH.Location = new System.Drawing.Point(3, 26);
            this.listViewDSHH.Name = "listViewDSHH";
            this.listViewDSHH.Size = new System.Drawing.Size(1232, 277);
            this.listViewDSHH.TabIndex = 0;
            this.listViewDSHH.UseCompatibleStateImageBehavior = false;
            this.listViewDSHH.View = System.Windows.Forms.View.Details;
            this.listViewDSHH.SelectedIndexChanged += new System.EventHandler(this.listViewDSHH_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã Hàng";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên Hàng";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Danh Mục";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "NSX";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "HSD";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Số Luọng";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Giá";
            this.columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Nhà SX";
            this.columnHeader8.Width = 150;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Vị trí";
            this.columnHeader9.Width = 200;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(952, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 45);
            this.button1.TabIndex = 8;
            this.button1.Text = "Làm Mới";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(235, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 45);
            this.button2.TabIndex = 3;
            this.button2.Text = "Làm Mới";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1593, 756);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormHangHoa";
            this.Text = "FormHangHoa";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePickerHSD;
        private System.Windows.Forms.DateTimePicker dateTimePickerNSX;
        private System.Windows.Forms.TextBox textBoxSoLuong;
        private System.Windows.Forms.TextBox textBoxViTri;
        private System.Windows.Forms.TextBox textBoxGia;
        private System.Windows.Forms.TextBox textBoxTenHang;
        private System.Windows.Forms.TextBox textBoxMaHang;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonXoaSP;
        private System.Windows.Forms.Button buttonSuaSP;
        private System.Windows.Forms.Button buttonThemSP;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView listViewDSHH;
        private System.Windows.Forms.ListBox listBoxDM;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonXoaDM;
        private System.Windows.Forms.Button buttonSuaDM;
        private System.Windows.Forms.Button buttonThemDM;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Button buttonTimKiem;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ComboBox comboBoxNhaSX;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBoxDM;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}