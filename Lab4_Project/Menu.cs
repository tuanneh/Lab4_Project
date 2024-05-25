using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_Project
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void NguoiDung_Click(object sender, EventArgs e)
        {
            // Ẩn form Menu
            this.Hide();
            formNguoiDung formNguoiDung = new formNguoiDung();
            formNguoiDung.FormClosed += (s, args) => this.Show();
            formNguoiDung.Show();
        }

        private void TTMay_Click(object sender, EventArgs e)
        {
            // Ẩn form Menu
            this.Hide();

            formThongTinMay formThongTinMay = new formThongTinMay();
            formThongTinMay.FormClosed += (s, args) => this.Show(); 
            formThongTinMay.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát khỏi ứng dụng không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Nếu người dùng chọn "Đồng ý"
            if (result == DialogResult.Yes)
            {
                // Đóng ứng dụng
                Application.Exit();
            }
        }
    }
}
