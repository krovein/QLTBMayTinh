namespace QuanLyThietBiMayTinh
{
    partial class NhomHangManagerForm
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
            this.pnChucNang = new System.Windows.Forms.Panel();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.txtTenNhomHang = new System.Windows.Forms.TextBox();
            this.txtMaNhomHang = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbMaNhomHang = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSearchNhomHang = new System.Windows.Forms.Button();
            this.btnDeleteNV = new System.Windows.Forms.Button();
            this.btnEditNhomHang = new System.Windows.Forms.Button();
            this.btnAddNhomHang = new System.Windows.Forms.Button();
            this.grNhomHang = new System.Windows.Forms.DataGridView();
            this.sMaNhomHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTenNhomsHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sMoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnChucNang.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grNhomHang)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(350, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(446, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ NHÓM HÀNG";
            // 
            // pnChucNang
            // 
            this.pnChucNang.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pnChucNang.Controls.Add(this.btnOK);
            this.pnChucNang.Controls.Add(this.txtMoTa);
            this.pnChucNang.Controls.Add(this.txtTenNhomHang);
            this.pnChucNang.Controls.Add(this.txtMaNhomHang);
            this.pnChucNang.Controls.Add(this.label5);
            this.pnChucNang.Controls.Add(this.label4);
            this.pnChucNang.Controls.Add(this.lbMaNhomHang);
            this.pnChucNang.Controls.Add(this.lbTitle);
            this.pnChucNang.Location = new System.Drawing.Point(198, 419);
            this.pnChucNang.Name = "pnChucNang";
            this.pnChucNang.Size = new System.Drawing.Size(1049, 242);
            this.pnChucNang.TabIndex = 5;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.SystemColors.Info;
            this.btnOK.Location = new System.Drawing.Point(587, 94);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(329, 51);
            this.btnOK.TabIndex = 15;
            this.btnOK.Text = "Chức năng";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(229, 162);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(273, 22);
            this.txtMoTa.TabIndex = 7;
            // 
            // txtTenNhomHang
            // 
            this.txtTenNhomHang.Location = new System.Drawing.Point(229, 108);
            this.txtTenNhomHang.Name = "txtTenNhomHang";
            this.txtTenNhomHang.Size = new System.Drawing.Size(273, 22);
            this.txtTenNhomHang.TabIndex = 6;
            // 
            // txtMaNhomHang
            // 
            this.txtMaNhomHang.Location = new System.Drawing.Point(229, 49);
            this.txtMaNhomHang.Name = "txtMaNhomHang";
            this.txtMaNhomHang.Size = new System.Drawing.Size(273, 22);
            this.txtMaNhomHang.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(103, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Mô Tả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tên Nhóm Hàng";
            // 
            // lbMaNhomHang
            // 
            this.lbMaNhomHang.AutoSize = true;
            this.lbMaNhomHang.Location = new System.Drawing.Point(103, 54);
            this.lbMaNhomHang.Name = "lbMaNhomHang";
            this.lbMaNhomHang.Size = new System.Drawing.Size(102, 17);
            this.lbMaNhomHang.TabIndex = 1;
            this.lbMaNhomHang.Text = "Mã nhóm hàng";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(3, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(152, 32);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Chức năng";
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel.Controls.Add(this.btnBack);
            this.panel.Controls.Add(this.btnSearchNhomHang);
            this.panel.Controls.Add(this.btnDeleteNV);
            this.panel.Controls.Add(this.btnEditNhomHang);
            this.panel.Controls.Add(this.btnAddNhomHang);
            this.panel.Location = new System.Drawing.Point(12, 82);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(180, 579);
            this.panel.TabIndex = 6;
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold);
            this.btnBack.Image = global::QuanLyThietBiMayTinh.Properties.Resources.action_export;
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.Location = new System.Drawing.Point(0, 386);
            this.btnBack.Name = "btnBack";
            this.btnBack.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnBack.Size = new System.Drawing.Size(180, 100);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSearchNhomHang
            // 
            this.btnSearchNhomHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchNhomHang.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSearchNhomHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchNhomHang.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold);
            this.btnSearchNhomHang.Image = global::QuanLyThietBiMayTinh.Properties.Resources.search;
            this.btnSearchNhomHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchNhomHang.Location = new System.Drawing.Point(0, 192);
            this.btnSearchNhomHang.Name = "btnSearchNhomHang";
            this.btnSearchNhomHang.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnSearchNhomHang.Size = new System.Drawing.Size(180, 100);
            this.btnSearchNhomHang.TabIndex = 3;
            this.btnSearchNhomHang.Text = "Search";
            this.btnSearchNhomHang.UseVisualStyleBackColor = true;
            this.btnSearchNhomHang.Click += new System.EventHandler(this.btnSearchNhomHang_Click);
            // 
            // btnDeleteNV
            // 
            this.btnDeleteNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteNV.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDeleteNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteNV.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold);
            this.btnDeleteNV.Image = global::QuanLyThietBiMayTinh.Properties.Resources.delete2;
            this.btnDeleteNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteNV.Location = new System.Drawing.Point(0, 288);
            this.btnDeleteNV.Name = "btnDeleteNV";
            this.btnDeleteNV.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnDeleteNV.Size = new System.Drawing.Size(180, 100);
            this.btnDeleteNV.TabIndex = 2;
            this.btnDeleteNV.Text = "Delete";
            this.btnDeleteNV.UseVisualStyleBackColor = true;
            this.btnDeleteNV.Click += new System.EventHandler(this.btnDeleteNV_Click);
            // 
            // btnEditNhomHang
            // 
            this.btnEditNhomHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditNhomHang.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEditNhomHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditNhomHang.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold);
            this.btnEditNhomHang.Image = global::QuanLyThietBiMayTinh.Properties.Resources.edit;
            this.btnEditNhomHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditNhomHang.Location = new System.Drawing.Point(0, 95);
            this.btnEditNhomHang.Name = "btnEditNhomHang";
            this.btnEditNhomHang.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnEditNhomHang.Size = new System.Drawing.Size(180, 100);
            this.btnEditNhomHang.TabIndex = 1;
            this.btnEditNhomHang.Text = "Edit";
            this.btnEditNhomHang.UseVisualStyleBackColor = true;
            this.btnEditNhomHang.Click += new System.EventHandler(this.btnEditNhomHang_Click);
            // 
            // btnAddNhomHang
            // 
            this.btnAddNhomHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNhomHang.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddNhomHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNhomHang.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNhomHang.Image = global::QuanLyThietBiMayTinh.Properties.Resources.add_icon;
            this.btnAddNhomHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNhomHang.Location = new System.Drawing.Point(0, 0);
            this.btnAddNhomHang.Name = "btnAddNhomHang";
            this.btnAddNhomHang.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnAddNhomHang.Size = new System.Drawing.Size(180, 100);
            this.btnAddNhomHang.TabIndex = 0;
            this.btnAddNhomHang.Text = "Add";
            this.btnAddNhomHang.UseVisualStyleBackColor = true;
            this.btnAddNhomHang.Click += new System.EventHandler(this.btnAddNhomHang_Click);
            // 
            // grNhomHang
            // 
            this.grNhomHang.BackgroundColor = System.Drawing.Color.White;
            this.grNhomHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grNhomHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sMaNhomHang,
            this.sTenNhomsHang,
            this.sMoTa});
            this.grNhomHang.Location = new System.Drawing.Point(3, 3);
            this.grNhomHang.Name = "grNhomHang";
            this.grNhomHang.RowTemplate.Height = 24;
            this.grNhomHang.Size = new System.Drawing.Size(1046, 325);
            this.grNhomHang.TabIndex = 7;
            // 
            // sMaNhomHang
            // 
            this.sMaNhomHang.DataPropertyName = "sMaNhomHang";
            this.sMaNhomHang.HeaderText = "Mã nhóm hàng";
            this.sMaNhomHang.Name = "sMaNhomHang";
            // 
            // sTenNhomsHang
            // 
            this.sTenNhomsHang.DataPropertyName = "sTenNhomHang";
            this.sTenNhomsHang.HeaderText = "Tên Nhóm Hàng";
            this.sTenNhomsHang.Name = "sTenNhomsHang";
            // 
            // sMoTa
            // 
            this.sMoTa.DataPropertyName = "sMoTa";
            this.sMoTa.HeaderText = "Mô tả";
            this.sMoTa.Name = "sMoTa";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1238, 64);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.grNhomHang);
            this.panel2.Location = new System.Drawing.Point(198, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1052, 331);
            this.panel2.TabIndex = 9;
            // 
            // NhomHangManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.pnChucNang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "NhomHangManagerForm";
            this.Text = "NhomHang";
            this.Load += new System.EventHandler(this.NhomHangManagerForm_Load);
            this.pnChucNang.ResumeLayout(false);
            this.pnChucNang.PerformLayout();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grNhomHang)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnChucNang;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.TextBox txtTenNhomHang;
        private System.Windows.Forms.TextBox txtMaNhomHang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbMaNhomHang;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSearchNhomHang;
        private System.Windows.Forms.Button btnDeleteNV;
        private System.Windows.Forms.Button btnEditNhomHang;
        private System.Windows.Forms.Button btnAddNhomHang;
        private System.Windows.Forms.DataGridView grNhomHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaNhomHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTenNhomsHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMoTa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}