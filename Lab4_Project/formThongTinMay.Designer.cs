namespace Lab4_Project
{
    partial class formThongTinMay
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTrangThaiHoatDong = new System.Windows.Forms.TextBox();
            this.txtLoaiMay = new System.Windows.Forms.TextBox();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.txtMaMayTinh = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_SuaMay = new System.Windows.Forms.Button();
            this.BTN_ThemMay = new System.Windows.Forms.Button();
            this.BTN_XoaMay = new System.Windows.Forms.Button();
            this.data_May = new System.Windows.Forms.DataGridView();
            this.BTN_Thoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_May)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.txtTrangThaiHoatDong);
            this.groupBox1.Controls.Add(this.txtLoaiMay);
            this.groupBox1.Controls.Add(this.txtTenDangNhap);
            this.groupBox1.Controls.Add(this.txtMaMayTinh);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 308);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "NHẬP THÔNG TIN MÁY";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtTrangThaiHoatDong
            // 
            this.txtTrangThaiHoatDong.Location = new System.Drawing.Point(218, 216);
            this.txtTrangThaiHoatDong.Name = "txtTrangThaiHoatDong";
            this.txtTrangThaiHoatDong.Size = new System.Drawing.Size(191, 30);
            this.txtTrangThaiHoatDong.TabIndex = 11;
            // 
            // txtLoaiMay
            // 
            this.txtLoaiMay.Location = new System.Drawing.Point(218, 180);
            this.txtLoaiMay.Name = "txtLoaiMay";
            this.txtLoaiMay.Size = new System.Drawing.Size(191, 30);
            this.txtLoaiMay.TabIndex = 10;
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Location = new System.Drawing.Point(218, 143);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(191, 30);
            this.txtTenDangNhap.TabIndex = 9;
            // 
            // txtMaMayTinh
            // 
            this.txtMaMayTinh.Location = new System.Drawing.Point(218, 105);
            this.txtMaMayTinh.Name = "txtMaMayTinh";
            this.txtMaMayTinh.Size = new System.Drawing.Size(191, 30);
            this.txtMaMayTinh.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "TRẠNG THÁI:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "LOẠI MÁY:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "TÊN ĐĂNG NHẬP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "MÃ MÁY:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(284, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "THÊM MÁY TÍNH";
            // 
            // BTN_SuaMay
            // 
            this.BTN_SuaMay.Location = new System.Drawing.Point(318, 380);
            this.BTN_SuaMay.Name = "BTN_SuaMay";
            this.BTN_SuaMay.Size = new System.Drawing.Size(127, 55);
            this.BTN_SuaMay.TabIndex = 14;
            this.BTN_SuaMay.Text = "SỬA DỮ LIỆU";
            this.BTN_SuaMay.UseVisualStyleBackColor = true;
            this.BTN_SuaMay.Click += new System.EventHandler(this.BTN_SuaMay_Click);
            // 
            // BTN_ThemMay
            // 
            this.BTN_ThemMay.Location = new System.Drawing.Point(13, 380);
            this.BTN_ThemMay.Name = "BTN_ThemMay";
            this.BTN_ThemMay.Size = new System.Drawing.Size(127, 55);
            this.BTN_ThemMay.TabIndex = 12;
            this.BTN_ThemMay.Text = "THÊM MÁY";
            this.BTN_ThemMay.UseVisualStyleBackColor = true;
            this.BTN_ThemMay.Click += new System.EventHandler(this.BTN_ThemMay_Click);
            // 
            // BTN_XoaMay
            // 
            this.BTN_XoaMay.Location = new System.Drawing.Point(165, 380);
            this.BTN_XoaMay.Name = "BTN_XoaMay";
            this.BTN_XoaMay.Size = new System.Drawing.Size(127, 55);
            this.BTN_XoaMay.TabIndex = 13;
            this.BTN_XoaMay.Text = "XÓA MÁY";
            this.BTN_XoaMay.UseVisualStyleBackColor = true;
            this.BTN_XoaMay.Click += new System.EventHandler(this.BTN_XoaMay_Click);
            // 
            // data_May
            // 
            this.data_May.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_May.Location = new System.Drawing.Point(472, 64);
            this.data_May.Name = "data_May";
            this.data_May.RowHeadersWidth = 51;
            this.data_May.RowTemplate.Height = 24;
            this.data_May.Size = new System.Drawing.Size(509, 308);
            this.data_May.TabIndex = 15;
            this.data_May.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_May_CellContentClick);
            // 
            // BTN_Thoat
            // 
            this.BTN_Thoat.BackColor = System.Drawing.Color.Red;
            this.BTN_Thoat.Location = new System.Drawing.Point(674, 380);
            this.BTN_Thoat.Name = "BTN_Thoat";
            this.BTN_Thoat.Size = new System.Drawing.Size(127, 55);
            this.BTN_Thoat.TabIndex = 16;
            this.BTN_Thoat.Text = "THOÁT";
            this.BTN_Thoat.UseVisualStyleBackColor = false;
            this.BTN_Thoat.Click += new System.EventHandler(this.BTN_Thoat_Click);
            // 
            // formThongTinMay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 450);
            this.Controls.Add(this.BTN_Thoat);
            this.Controls.Add(this.data_May);
            this.Controls.Add(this.BTN_SuaMay);
            this.Controls.Add(this.BTN_ThemMay);
            this.Controls.Add(this.BTN_XoaMay);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "formThongTinMay";
            this.Text = "formThongTinMay";
            this.Load += new System.EventHandler(this.formThongTinMay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_May)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTrangThaiHoatDong;
        private System.Windows.Forms.TextBox txtLoaiMay;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.TextBox txtMaMayTinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_SuaMay;
        private System.Windows.Forms.Button BTN_ThemMay;
        private System.Windows.Forms.Button BTN_XoaMay;
        private System.Windows.Forms.DataGridView data_May;
        private System.Windows.Forms.Button BTN_Thoat;
    }
}