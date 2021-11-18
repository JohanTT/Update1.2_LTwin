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

namespace UITest.Forms
{
    public partial class FormTaiKhoan : Form
    {
        // tạo biến cục bộ
        string strCon = @"Data Source=JOHAN\SQLEXPRESS;Initial Catalog=SHOES14;Integrated Security=True";
        // Đối tượng kết nối
        SqlConnection SqlCon = null;
        public FormTaiKhoan()
        {
            InitializeComponent();
        }

        private void FormTaiKhoan_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void TimTaiKhoanbt_Click(object sender, EventArgs e)
        {
            try
            {
                if (SqlCon == null)
                {
                    // Nếu chưa kết nối tiến hành thực hiện kết nối
                    SqlCon = new SqlConnection(strCon);
                }

                // Sau khi kết nối tiến hành mở
                if (SqlCon.State == System.Data.ConnectionState.Closed)  // Trạng thái hiện tại của SqlConnection mà đóng thì mở
                {
                    SqlCon.Open();
                    //MessageBox.Show("Quên kết nối kìa để kết nối giúp luôn cho!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            // lấy mã giày từ MaGiaytxt
            string makhachhang = MaKhachHangtxt.Text;

            // đối tượng truy vấn
            SqlCommand SqlCmd = new SqlCommand();
            SqlCmd.CommandType = System.Data.CommandType.Text;
            SqlCmd.CommandText = "SELECT * FROM KHACH_HANG WHERE MaKhachHang = '" + makhachhang + "'";
            // thêm phần định nghĩa pameter

            // gửi truy vấn vào kết nối CSDL
            SqlCmd.Connection = SqlCon;

            // Thực thi
            SqlDataReader reader = SqlCmd.ExecuteReader(); // tạo đầu đọc
            if (reader.Read())
            {
                string tenkhachhang = reader.GetString(1);
                string sodienthoai = reader.GetString(2);
                string diachi = reader.GetString(3);
                DateTime ngaysinh = reader.GetDateTime(4);
                string gioitinh = reader.GetString(5);

                // Hiển thị ra lại màn 
                TenKhachHangtxt.Text = tenkhachhang.Trim();
                SoDienThoaitxt.Text = sodienthoai.Trim();
                DiaChitxt.Text = diachi.Trim();
                NgaySinhtxt.Text = ngaysinh.ToString().Trim();
                GioiTinhtxt.Text = gioitinh.ToString().Trim();

            }
            reader.Close();
        }
    }
}
