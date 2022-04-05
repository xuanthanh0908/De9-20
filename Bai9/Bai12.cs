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
    public partial class Bai12 : Form
    {
        public Bai12()
        {
            InitializeComponent();
            dgvBN.DataSource = Load_Formm().Tables["BeNgoan"];
            dgvBN.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public DataSet Load_Formm()
        {
            DataSet dataSet = new DataSet();
            string conn = @"Data Source=DESKTOP-LNRFFUR\SQLEXPRESS;Initial Catalog=HoaHong;Integrated Security=True";
            string query = "Select * from BeNgoan";
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

        private void button1_Click(object sender, EventArgs e)
        {
            string conn = @"Data Source=DESKTOP-LNRFFUR\SQLEXPRESS;Initial Catalog=HoaHong;Integrated Security=True";
            string query = "UPDATE BENGOAN SET TENBENGOAN = '" + txtTenBN.Text + "'  where MABN = '" + txtMABN.Text + "'";
            SqlConnection connection = new SqlConnection(conn);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)

            {

                MessageBox.Show("Lỗi :" + ex.Message);
            }
            dgvBN.DataSource = Load_Formm().Tables["BeNgoan"];
            dgvBN.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
