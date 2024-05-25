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
    public partial class formThongTinMay : Form
    {

        private string connectionString = "Data Source=MSI;Initial Catalog=DB.Lab4;Integrated Security=True";


        public formThongTinMay()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BTN_ThemMay_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand cmd = connection.CreateCommand())
                    {
                        // Truy vấn SQL để chèn dữ liệu vào bảng TaiKhoan
                        cmd.CommandText = @"INSERT INTO MayTinh (MaMayTinh, TenDangNhap, LoaiMay, TrangThaiHoatDong) 
                                            VALUES (@MaMayTinh, @TenDangNhap, @LoaiMay, @TrangThaiHoatDong)";

                        // Thay thế các tham số trong truy vấn bằng giá trị từ các TextBox
                        cmd.Parameters.AddWithValue("@MaMayTinh", txtMaMayTinh.Text);
                        cmd.Parameters.AddWithValue("@TenDangNhap", txtTenDangNhap.Text);
                        cmd.Parameters.AddWithValue("@LoaiMay", txtLoaiMay.Text);
                        cmd.Parameters.AddWithValue("@TrangThaiHoatDong", txtTrangThaiHoatDong.Text);
                       

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

        private void formThongTinMay_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=MSI;Initial Catalog=DB.Lab4;Integrated Security=True"))
            {
                // Mở kết nối
                connection.Open();

                // Tạo truy vấn SQL để lấy dữ liệu từ bảng TaiKhoan
                string query = "SELECT * FROM MayTinh";

                // Tạo một đối tượng SqlDataAdapter để lấy dữ liệu từ cơ sở dữ liệu và điền vào DataTable
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();

                // Đổ dữ liệu từ SqlDataAdapter vào DataTable
                adapter.Fill(dataTable);

                // Thiết lập DataGridView là nguồn dữ liệu của DataTable
                data_May.DataSource = dataTable;
            }
        }

        private void BTN_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void data_May_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.data_May.Rows[e.RowIndex];
                string maMayTinh = row.Cells["MaMayTinh"].Value.ToString();

                // Lưu mã tài khoản vào Tag của nút BTN_XoaMay để sử dụng sau này
                BTN_XoaMay.Tag = maMayTinh;
            }


            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.data_May.Rows[e.RowIndex];
                txtMaMayTinh.Text = row.Cells["MaMayTinh"].Value.ToString();
                txtTenDangNhap.Text = row.Cells["TenDangNhap"].Value.ToString();
                txtLoaiMay.Text = row.Cells["LoaiMay"].Value.ToString();
                txtTrangThaiHoatDong.Text = row.Cells["TrangThaiHoatDong"].Value.ToString();
            }


        }

        private void BTN_XoaMay_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem Tag có giá trị không
            if (BTN_XoaMay.Tag != null)
            {
                // Lấy mã tài khoản từ Tag của nút BTN_XoaDuLieu
                string MaMayTinh = BTN_XoaMay.Tag.ToString();

                // Gọi hàm xóa dữ liệu
                XoaDuLieu(MaMayTinh);
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để xóa.");
            }
        }

        private void XoaDuLieu(string maMayTinh)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand cmd = connection.CreateCommand())
                    {
                        // Truy vấn SQL để xóa dữ liệu từ bảng TaiKhoan dựa trên MaTaiKhoan
                        cmd.CommandText = @"DELETE FROM MayTinh WHERE MaMayTinh = @MaMayTinh";
                        cmd.Parameters.AddWithValue("MaMayTinh", maMayTinh);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Xóa dữ liệu thành công!");
                            // Refresh DataGridView sau khi xóa dữ liệu thành công
                            formThongTinMay_Load(null, null);
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

        private void BTN_SuaMay_Click(object sender, EventArgs e)
        {
            string maMayTinh = txtMaMayTinh.Text;
            string tenDangNhap = txtTenDangNhap.Text;
            string loaiMay = txtLoaiMay.Text;
            string trangThaiHoatDong = txtTrangThaiHoatDong.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand cmd = connection.CreateCommand())
                    {
                        // Truy vấn SQL để cập nhật thông tin tài khoản
                        cmd.CommandText = @"UPDATE MayTinh 
                                    SET MayMayTinh = @MaMayTinh, TenDangNhap = @TenDangNhap, LoaiMay = @LoaiMay, TrangThaiHoatDong = @TrangThaiHoatDong
                                    WHERE MayMayTinh = @MayMayTinh";

                        // Thay thế các tham số trong truy vấn bằng giá trị từ các TextBox
                        cmd.Parameters.AddWithValue("@MayMayTinh", maMayTinh);
                        cmd.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                        cmd.Parameters.AddWithValue("@LoaiMay", loaiMay);
                        cmd.Parameters.AddWithValue("@TrangThaiHoatDong", trangThaiHoatDong);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cập nhật thông tin tài khoản thành công!");
                            // Refresh DataGridView sau khi cập nhật thành công
                            formThongTinMay_Load(null, null);
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
