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
    public partial class FormKiGui : Form
    {
        // tạo biến cục bộ
        string strCon = @"Data Source=JOHAN\SQLEXPRESS;Initial Catalog=SHOES14;Integrated Security=True";
        // Đối tượng kết nối
        SqlConnection SqlCon = null;
        int dem = 0; // tạo biến đếm để ký gửi chỉ xuất hiện đúng 1 lần.
        public FormKiGui()
        {
            InitializeComponent();
        }

        private void KyGuiList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dem == 0)
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
                SqlCmd.CommandText = "SELECT * FROM KY_GUI";

                // gửi truy vấn vào kết nối CSDL
                SqlCmd.Connection = SqlCon;

                // Thực thi
                SqlDataReader reader = SqlCmd.ExecuteReader();
                while (reader.Read())
                {
                    string magiay = reader.GetString(0);
                    DateTime thoigian = reader.GetDateTime(1);
                    string makhachhang = reader.GetString(2);
                    string tenkhachhang = reader.GetString(3);
                    string sodienthoai = reader.GetString(4);
                    string diachi = reader.GetString(5);
                    double dongia = reader.GetDouble(6);
                    string manhanvien = reader.GetString(7);

                    // Hiển thị lên giao diện
                    ListViewItem lvimagiay = new ListViewItem(magiay);
                    ListViewItem lvithoigian = new ListViewItem(thoigian.ToString());
                    ListViewItem lvimakhachhang = new ListViewItem(makhachhang);
                    ListViewItem lvitenkhachhang = new ListViewItem(tenkhachhang);
                    ListViewItem lvisodienthoai = new ListViewItem(sodienthoai);
                    ListViewItem lvidiachi = new ListViewItem(diachi);
                    ListViewItem lvidongia = new ListViewItem(dongia.ToString());
                    ListViewItem lvimanhanvien = new ListViewItem(manhanvien);
                    /*
                    lvi.SubItems.Add(thoigian.ToString());
                    lvi.SubItems.Add(makhachhang);
                    lvi.SubItems.Add(tenkhachhang);
                    lvi.SubItems.Add(sodienthoai);
                    lvi.SubItems.Add(diachi);
                    lvi.SubItems.Add(dongia.ToString());
                    lvi.SubItems.Add(manhanvien);
                    */
                    KyGuiList.Items.Add(lvimagiay); // list view chính có tên là KyGuiList
                    KyGuiList.Items.Add(lvithoigian);
                    KyGuiList.Items.Add(lvimakhachhang);
                    KyGuiList.Items.Add(lvitenkhachhang);
                    KyGuiList.Items.Add(lvisodienthoai);
                    KyGuiList.Items.Add(lvidiachi);
                    KyGuiList.Items.Add(lvidongia);
                    KyGuiList.Items.Add(lvimanhanvien);
                }
                reader.Close();
                dem++;
            }
        }
    }
}
