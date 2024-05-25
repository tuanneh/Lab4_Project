namespace Lab4_Project
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.TTMay = new System.Windows.Forms.Button();
            this.NguoiDung = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(43, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(252, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(505, 36);
            this.label1.TabIndex = 11;
            this.label1.Text = "PHẦN MỀM QUẢN LÝ QUÁN NET";
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Red;
            this.Exit.Location = new System.Drawing.Point(404, 298);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(202, 99);
            this.Exit.TabIndex = 10;
            this.Exit.Text = "Thoat";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // TTMay
            // 
            this.TTMay.BackColor = System.Drawing.SystemColors.ControlDark;
            this.TTMay.Location = new System.Drawing.Point(555, 134);
            this.TTMay.Name = "TTMay";
            this.TTMay.Size = new System.Drawing.Size(202, 99);
            this.TTMay.TabIndex = 9;
            this.TTMay.Text = "MÁY CHỦ";
            this.TTMay.UseVisualStyleBackColor = false;
            this.TTMay.Click += new System.EventHandler(this.TTMay_Click);
            // 
            // NguoiDung
            // 
            this.NguoiDung.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.NguoiDung.Location = new System.Drawing.Point(258, 134);
            this.NguoiDung.Name = "NguoiDung";
            this.NguoiDung.Size = new System.Drawing.Size(202, 99);
            this.NguoiDung.TabIndex = 8;
            this.NguoiDung.Text = "QUẢN LÝ NGƯỜI DÙNG";
            this.NguoiDung.UseVisualStyleBackColor = false;
            this.NguoiDung.Click += new System.EventHandler(this.NguoiDung_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.TTMay);
            this.Controls.Add(this.NguoiDung);
            this.Name = "Menu";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button TTMay;
        private System.Windows.Forms.Button NguoiDung;
    }
}

