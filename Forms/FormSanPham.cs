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
    public partial class FormSanPham : Form
    {
        // tạo biến cục bộ
        string strCon = @"Data Source=JOHAN\SQLEXPRESS;Initial Catalog=SHOES14;Integrated Security=True";
        // Đối tượng kết nối
        SqlConnection SqlCon = null;
        public FormSanPham()
        {
            InitializeComponent();
        }

        private void MatHangList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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

            // đối tượng truy vấn
            SqlCommand SqlCmd = new SqlCommand();
            SqlCmd.CommandType = System.Data.CommandType.Text;
            SqlCmd.CommandText = "SELECT * FROM MAT_HANG";

            // gửi truy vấn vào kết nối CSDL
            SqlCmd.Connection = SqlCon;

            // Thực thi
            SqlDataReader reader = SqlCmd.ExecuteReader();
            while (reader.Read())
            {
                string magiay = reader.GetString(0);
                string tengiay = reader.GetString(1);
                double soluong = reader.GetDouble(2);
                string mausac = reader.GetString(3);
                string size = reader.GetString(4);
                double dongia = reader.GetDouble(5);

                // Hiển thị lên giao diện
                ListViewItem lvi = new ListViewItem(magiay);
                lvi.SubItems.Add(tengiay);
                lvi.SubItems.Add(soluong.ToString());
                lvi.SubItems.Add(mausac);
                lvi.SubItems.Add(size);
                lvi.SubItems.Add(dongia.ToString());

                MatHangList.Items.Add(lvi); // list view chính có tên là KyGuiList
            }
            reader.Close();

        }
    }
}
