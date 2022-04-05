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

namespace Bai9
{
    public partial class Bai10 : Form
    {
        public Bai10()
        {
            InitializeComponent();
            dgvBN.DataSource = Load_form().Tables["BeNgoan"];
            dgvBN.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public DataSet Load_form()
        {
            DataSet dataSet = new DataSet();
            string conn = @"Data Source=DESKTOP-LNRFFUR\SQLEXPRESS;Initial Catalog=HoaHong;Integrated Security=True";
            string query = "SELECT * FROM BENGOAN ";
            SqlConnection connection = new SqlConnection(conn);
            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                dataAdapter.Fill(dataSet, "BeNgoan");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi :" + ex.Message);
            }
            return dataSet;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string conn = @"Data Source=DESKTOP-LNRFFUR\SQLEXPRESS;Initial Catalog=HoaHong;Integrated Security=True";
            string query = "INSERT INTO BENGOAN VALUES(@MABN,@MALOP,@TENBN,@NGAYSINH,@GIOITINH,@TENBO,@TENME,@DIACHI)";
            SqlConnection connection = new SqlConnection(conn);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MABN", txtMabn.Text);
                command.Parameters.AddWithValue("@MALOP", txtMalop.Text);
                command.Parameters.AddWithValue("@TENBN", txtTenBN.Text);
                command.Parameters.AddWithValue("@NGAYSINH", DateNS.Value.Date);
                command.Parameters.AddWithValue("@GIOITINH", txtGT.Text);
                command.Parameters.AddWithValue("@TENBO", txtTenBo.Text);
                command.Parameters.AddWithValue("@TENME", txtTenMe.Text);
                command.Parameters.AddWithValue("@DIACHI", txtDC.Text);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Thêm mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi :" + ex.Message);
            }
            dgvBN.DataSource = Load_form().Tables["BeNgoan"];
            dgvBN.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
    }
}
