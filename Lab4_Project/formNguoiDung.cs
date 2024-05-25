using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_Project
{
    public partial class formNguoiDung : Form
    {
        private string connectionString = "Data Source=MSI;Initial Catalog=DB.Lab4;Integrated Security=True";

        public formNguoiDung()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void formNguoiDung_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=MSI;Initial Catalog=DB.Lab4;Integrated Security=True"))
            {
                // Mở kết nối
                connection.Open();

                // Tạo truy vấn SQL để lấy dữ liệu từ bảng TaiKhoan
                string query = "SELECT * FROM TaiKhoan";

                // Tạo một đối tượng SqlDataAdapter để lấy dữ liệu từ cơ sở dữ liệu và điền vào DataTable
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();

                // Đổ dữ liệu từ SqlDataAdapter vào DataTable
                adapter.Fill(dataTable);

                // Thiết lập DataGridView là nguồn dữ liệu của DataTable
                data_TaiKhoan.DataSource = dataTable;
            }


        }

        private void BTN_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void data_TaiKhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.data_TaiKhoan.Rows[e.RowIndex];
                string maTaiKhoan = row.Cells["MaTaiKhoan"].Value.ToString();

                // Lưu mã tài khoản vào Tag của nút BTN_XoaDuLieu để sử dụng sau này
                BTN_XoaDuLieu.Tag = maTaiKhoan;
            }


            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.data_TaiKhoan.Rows[e.RowIndex];
                txtMaTaiKhoan.Text = row.Cells["MaTaiKhoan"].Value.ToString();
                txtTenDangNhap.Text = row.Cells["TenDangNhap"].Value.ToString();
                txtMatKhau.Text = row.Cells["MatKhau"].Value.ToString();
                txtTenKhachHang.Text = row.Cells["TenKhachHang"].Value.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                txtSoDienThoai.Text = row.Cells["SoDienThoai"].Value.ToString();
                txtSoTienDaNap.Text = row.Cells["SoTienDaNap"].Value.ToString();
            }

        }

        private void BTN_ThemTK_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand cmd = connection.CreateCommand())
                    {
                        // Truy vấn SQL để chèn dữ liệu vào bảng TaiKhoan
                        cmd.CommandText = @"INSERT INTO TaiKhoan (MaTaiKhoan, TenDangNhap, MatKhau, TenKhachHang, DiaChi, SoDienThoai, SoTienDaNap) 
                                            VALUES (@MaTaiKhoan, @TenDangNhap, @MatKhau, @TenKhachHang, @DiaChi, @SoDienThoai, @SoTienDaNap)";

                        // Thay thế các tham số trong truy vấn bằng giá trị từ các TextBox
                        cmd.Parameters.AddWithValue("@MaTaiKhoan", txtMaTaiKhoan.Text);
                        cmd.Parameters.AddWithValue("@TenDangNhap", txtTenDangNhap.Text);
                        cmd.Parameters.AddWithValue("@MatKhau", txtMatKhau.Text);
                        cmd.Parameters.AddWithValue("@TenKhachHang", txtTenKhachHang.Text);
                        cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
                        cmd.Parameters.AddWithValue("@SoDienThoai", txtSoDienThoai.Text);
                        cmd.Parameters.AddWithValue("@SoTienDaNap", decimal.Parse(txtSoTienDaNap.Text));

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Thêm dữ liệu thành công!");
                            // Clear các TextBox sau khi thêm dữ liệu thành công
                        }
                        else
                        {
                            MessageBox.Show("Thêm dữ liệu không thành công!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }

            }
        }

        private void BTN_XoaDuLieu_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem Tag có giá trị không
            if (BTN_XoaDuLieu.Tag != null)
            {
                // Lấy mã tài khoản từ Tag của nút BTN_XoaDuLieu
                string maTaiKhoan = BTN_XoaDuLieu.Tag.ToString();

                // Gọi hàm xóa dữ liệu
                XoaDuLieu(maTaiKhoan);
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để xóa.");
            }
        }

        private void XoaDuLieu(string maTaiKhoan)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand cmd = connection.CreateCommand())
                    {
                        // Truy vấn SQL để xóa dữ liệu từ bảng TaiKhoan dựa trên MaTaiKhoan
                        cmd.CommandText = @"DELETE FROM TaiKhoan WHERE MaTaiKhoan = @MaTaiKhoan";
                        cmd.Parameters.AddWithValue("@MaTaiKhoan", maTaiKhoan);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Xóa dữ liệu thành công!");
                            // Refresh DataGridView sau khi xóa dữ liệu thành công
                            formNguoiDung_Load(null, null);
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy tài khoản cần xóa hoặc xóa không thành công!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void BTN_SuaTaiKhoan_Click(object sender, EventArgs e)
        {
            string maTaiKhoan = txtMaTaiKhoan.Text;
            string tenDangNhap = txtTenDangNhap.Text;
            string matKhau = txtMatKhau.Text;
            string tenKhachHang = txtTenKhachHang.Text;
            string diaChi = txtDiaChi.Text;
            string soDienThoai = txtSoDienThoai.Text;
            decimal soTienDaNap = decimal.Parse(txtSoTienDaNap.Text);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand cmd = connection.CreateCommand())
                    {
                        // Truy vấn SQL để cập nhật thông tin tài khoản
                        cmd.CommandText = @"UPDATE TaiKhoan 
                                    SET TenDangNhap = @TenDangNhap, MatKhau = @MatKhau, TenKhachHang = @TenKhachHang, DiaChi = @DiaChi, SoDienThoai = @SoDienThoai, SoTienDaNap = @SoTienDaNap 
                                    WHERE MaTaiKhoan = @MaTaiKhoan";

                        // Thay thế các tham số trong truy vấn bằng giá trị từ các TextBox
                        cmd.Parameters.AddWithValue("@MaTaiKhoan", maTaiKhoan);
                        cmd.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                        cmd.Parameters.AddWithValue("@MatKhau", matKhau);
                        cmd.Parameters.AddWithValue("@TenKhachHang", tenKhachHang);
                        cmd.Parameters.AddWithValue("@DiaChi", diaChi);
                        cmd.Parameters.AddWithValue("@SoDienThoai", soDienThoai);
                        cmd.Parameters.AddWithValue("@SoTienDaNap", soTienDaNap);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cập nhật thông tin tài khoản thành công!");
                            // Refresh DataGridView sau khi cập nhật thành công
                            formNguoiDung_Load(null, null);
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy tài khoản cần cập nhật hoặc cập nhật không thành công!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }
    }
}
