﻿namespace QuanLyThietBiMayTinh
{
    partial class HoaDonXuatManagerForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnFunction = new System.Windows.Forms.Panel();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rbChuaThanhToan = new System.Windows.Forms.RadioButton();
            this.rbDaThanhToan = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.dateNgayBan = new System.Windows.Forms.DateTimePicker();
            this.cboNhanVien = new System.Windows.Forms.ComboBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbMaHoaDon = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.grHoaDonNhap = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTinhTrangThanhToan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnFunction.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grHoaDonNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1238, 66);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(338, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(531, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ HÓA ĐƠN XUẤT";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.Controls.Add(this.btnBack);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Location = new System.Drawing.Point(12, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(178, 577);
            this.panel2.TabIndex = 4;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnBack.Image = global::QuanLyThietBiMayTinh.Properties.Resources.action_export;
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.Location = new System.Drawing.Point(0, 381);
            this.btnBack.Name = "btnBack";
            this.btnBack.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnBack.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnBack.Size = new System.Drawing.Size(179, 100);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnDelete.Image = global::QuanLyThietBiMayTinh.Properties.Resources.delete2;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(0, 192);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnDelete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDelete.Size = new System.Drawing.Size(179, 100);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnSearch.Image = global::QuanLyThietBiMayTinh.Properties.Resources.search;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(0, 287);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSearch.Size = new System.Drawing.Size(179, 100);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnEdit.Image = global::QuanLyThietBiMayTinh.Properties.Resources.edit;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(0, 96);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnEdit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnEdit.Size = new System.Drawing.Size(179, 100);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnAdd.Image = global::QuanLyThietBiMayTinh.Properties.Resources.add_icon;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(0, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnAdd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAdd.Size = new System.Drawing.Size(179, 100);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pnFunction
            // 
            this.pnFunction.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pnFunction.Controls.Add(this.txtTenKH);
            this.pnFunction.Controls.Add(this.panel3);
            this.pnFunction.Controls.Add(this.label2);
            this.pnFunction.Controls.Add(this.dateNgayBan);
            this.pnFunction.Controls.Add(this.cboNhanVien);
            this.pnFunction.Controls.Add(this.btnOK);
            this.pnFunction.Controls.Add(this.txtMaHD);
            this.pnFunction.Controls.Add(this.label6);
            this.pnFunction.Controls.Add(this.label5);
            this.pnFunction.Controls.Add(this.label4);
            this.pnFunction.Controls.Add(this.lbMaHoaDon);
            this.pnFunction.Controls.Add(this.lbTitle);
            this.pnFunction.Location = new System.Drawing.Point(197, 388);
            this.pnFunction.Name = "pnFunction";
            this.pnFunction.Size = new System.Drawing.Size(1053, 273);
            this.pnFunction.TabIndex = 7;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(404, 120);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(280, 22);
            this.txtTenKH.TabIndex = 17;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rbChuaThanhToan);
            this.panel3.Controls.Add(this.rbDaThanhToan);
            this.panel3.Location = new System.Drawing.Point(406, 183);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(278, 36);
            this.panel3.TabIndex = 16;
            // 
            // rbChuaThanhToan
            // 
            this.rbChuaThanhToan.AutoSize = true;
            this.rbChuaThanhToan.Location = new System.Drawing.Point(144, 5);
            this.rbChuaThanhToan.Name = "rbChuaThanhToan";
            this.rbChuaThanhToan.Size = new System.Drawing.Size(134, 21);
            this.rbChuaThanhToan.TabIndex = 1;
            this.rbChuaThanhToan.TabStop = true;
            this.rbChuaThanhToan.Text = "Chưa thanh toán";
            this.rbChuaThanhToan.UseVisualStyleBackColor = true;
            // 
            // rbDaThanhToan
            // 
            this.rbDaThanhToan.AutoSize = true;
            this.rbDaThanhToan.Location = new System.Drawing.Point(4, 4);
            this.rbDaThanhToan.Name = "rbDaThanhToan";
            this.rbDaThanhToan.Size = new System.Drawing.Size(119, 21);
            this.rbDaThanhToan.TabIndex = 0;
            this.rbDaThanhToan.TabStop = true;
            this.rbDaThanhToan.Text = "Đã thanh toán";
            this.rbDaThanhToan.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Tình trạng thanh toán";
            // 
            // dateNgayBan
            // 
            this.dateNgayBan.Location = new System.Drawing.Point(404, 155);
            this.dateNgayBan.Name = "dateNgayBan";
            this.dateNgayBan.Size = new System.Drawing.Size(280, 22);
            this.dateNgayBan.TabIndex = 14;
            // 
            // cboNhanVien
            // 
            this.cboNhanVien.FormattingEnabled = true;
            this.cboNhanVien.Location = new System.Drawing.Point(405, 82);
            this.cboNhanVien.Name = "cboNhanVien";
            this.cboNhanVien.Size = new System.Drawing.Size(279, 24);
            this.cboNhanVien.TabIndex = 12;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(553, 242);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(131, 28);
            this.btnOK.TabIndex = 11;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(405, 45);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(279, 22);
            this.txtMaHD.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(220, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ngày Xuất Hóa Đơn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(252, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Nhân Viên Lập";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(239, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tên Khách Hàng";
            // 
            // lbMaHoaDon
            // 
            this.lbMaHoaDon.AutoSize = true;
            this.lbMaHoaDon.Location = new System.Drawing.Point(234, 50);
            this.lbMaHoaDon.Name = "lbMaHoaDon";
            this.lbMaHoaDon.Size = new System.Drawing.Size(120, 17);
            this.lbMaHoaDon.TabIndex = 1;
            this.lbMaHoaDon.Text = "Mã Hóa Đơn Xuất";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(26, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(97, 25);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Function";
            // 
            // grHoaDonNhap
            // 
            this.grHoaDonNhap.BackgroundColor = System.Drawing.Color.White;
            this.grHoaDonNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grHoaDonNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.sTinhTrangThanhToan});
            this.grHoaDonNhap.Location = new System.Drawing.Point(197, 84);
            this.grHoaDonNhap.Name = "grHoaDonNhap";
            this.grHoaDonNhap.RowTemplate.Height = 24;
            this.grHoaDonNhap.Size = new System.Drawing.Size(1053, 292);
            this.grHoaDonNhap.TabIndex = 8;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "sMaHoaDonBan";
            this.Column1.HeaderText = "Mã Hóa Đơn";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "sTenNhanVien";
            this.Column2.HeaderText = "Nhân Viên";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "sTenKhachHang";
            this.Column3.HeaderText = "Tên Khách Hàng";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "dThoiGianBan";
            this.Column4.HeaderText = "Thời Gian Bán";
            this.Column4.Name = "Column4";
            // 
            // sTinhTrangThanhToan
            // 
            this.sTinhTrangThanhToan.DataPropertyName = "sTinhTrangThanhToan";
            this.sTinhTrangThanhToan.HeaderText = "Tình trạng thanh toán";
            this.sTinhTrangThanhToan.Name = "sTinhTrangThanhToan";
            // 
            // HoaDonXuatManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.grHoaDonNhap);
            this.Controls.Add(this.pnFunction);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.Name = "HoaDonXuatManagerForm";
            this.Text = "HoaDonXuatManagerForm";
            this.Load += new System.EventHandler(this.HoaDonXuatManagerForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pnFunction.ResumeLayout(false);
            this.pnFunction.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grHoaDonNhap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel pnFunction;
        private System.Windows.Forms.DateTimePicker dateNgayBan;
        private System.Windows.Forms.ComboBox cboNhanVien;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbMaHoaDon;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.DataGridView grHoaDonNhap;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rbChuaThanhToan;
        private System.Windows.Forms.RadioButton rbDaThanhToan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTinhTrangThanhToan;
    }
}