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
    public partial class Bai9 : Form
    {
        public Bai9()
        {
            InitializeComponent();
            dgvLH.DataSource = Load_form().Tables["LopHoc"];
            dgvLH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public DataSet Load_form()
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

                MessageBox.Show("Lỗi : " + ex.Message);
            }
            return dataSet;
        }
        public DataSet Check()
        {
            DataSet dataSet = new DataSet();
            string conn = @"Data Source=DESKTOP-LNRFFUR\SQLEXPRESS;Initial Catalog=HoaHong;Integrated Security=True";
            string query = "Select * from LopHoc where MaLop = '"+txtMaLop.Text+"'";
            SqlConnection connection = new SqlConnection(conn);
            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                dataAdapter.Fill(dataSet, "LopHoc01");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi : " + ex.Message);
            }
            return dataSet;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string conn = @"Data Source=DESKTOP-LNRFFUR\SQLEXPRESS;Initial Catalog=HoaHong;Integrated Security=True";
            string query = "Delete LopHoc where MaLop = '"+txtMaLop.Text+"'";
            SqlConnection connection = new SqlConnection(conn);
            try
            {
                if(Check().Tables["LopHoc01"].Rows.Count > 0)
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Xóa Thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không có Lớp học phù hợp", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                

            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi : " + ex.Message);
            }
            dgvLH.DataSource = Load_form().Tables["LopHoc"];
            dgvLH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
