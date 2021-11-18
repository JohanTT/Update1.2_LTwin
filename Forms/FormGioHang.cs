using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; 

namespace UITest.Forms
{
    public partial class FormGioHang : Form
    {
        // tạo biến cục bộ
        string strCon = @"Data Source=JOHAN\SQLEXPRESS;Initial Catalog=SHOES14;Integrated Security=True";
        // Đối tượng kết nối
        SqlConnection SqlCon = null;

        public FormGioHang()
        {
            InitializeComponent();
        }

        private void FormGioHang_Load(object sender, EventArgs e)
        {

        }

        private void FindGioHang_Click(object sender, EventArgs e)
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
            string magiay = MaGiaytxt.Text;

            // đối tượng truy vấn
            SqlCommand SqlCmd = new SqlCommand();
            SqlCmd.CommandType = System.Data.CommandType.Text;
            SqlCmd.CommandText = "SELECT * FROM MAT_HANG WHERE MaGiay = '" + magiay + "'";
            // thêm phần định nghĩa pameter

            // gửi truy vấn vào kết nối CSDL
            SqlCmd.Connection = SqlCon;

            // Thực thi
            SqlDataReader reader = SqlCmd.ExecuteReader(); // tạo đầu đọc
            if (reader.Read())
            {
                string tengiay = reader.GetString(1);
                double soluong = reader.GetDouble(2);
                string mausac = reader.GetString(3);
                string size = reader.GetString(4);
                double dongia = reader.GetDouble(5);

                // Hiển thị ra lại màn 
                TenGiaytxt.Text = tengiay.Trim();
                SoLuongtxt.Text = soluong.ToString().Trim();
                MauSactxt.Text = mausac.Trim();
                Sizetxt.Text = size.Trim();
                DonGiatxt.Text = dongia.ToString().Trim();
            }
            reader.Close();
        }
    }
}
