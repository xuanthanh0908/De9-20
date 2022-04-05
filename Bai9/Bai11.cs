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
    public partial class Bai11 : Form
    {
        public Bai11()
        {
            InitializeComponent();
            dataGridView1.DataSource = Load_Form().Tables["BeNgoan"];
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            CBMalop.DataSource = Load_CB().Tables["LopHoc"];
            CBMalop.DisplayMember = "TenLop";
            CBMalop.ValueMember = "MaLop";
        }
        public DataSet Load_Form()
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
        public DataSet Load_CB()
        {
            DataSet dataSet = new DataSet();
            string conn = @"Data Source=DESKTOP-LNRFFUR\SQLEXPRESS;Initial Catalog=HoaHong;Integrated Security=True";
            string query = "Select * from LopHoc";
            SqlConnection connection = new SqlConnection(conn);
            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                dataAdapter.Fill(dataSet, "LopHoc");
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
            string query = "UPDATE BENGOAN SET MALOP = '"+CBMalop.SelectedValue+"' where MaBN = '"+txtMBN.Text+"'";
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
            dataGridView1.DataSource = Load_Form().Tables["BeNgoan"];
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
