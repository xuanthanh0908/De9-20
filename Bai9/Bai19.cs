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
    public partial class Bai19 : Form
    {
        public Bai19()
        {
            InitializeComponent();
            dgvSS.DataSource = Load_Form().Tables["SIM"];
            dgvSS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public DataSet Load_Form()
        {
            DataSet dataSet = new DataSet();
            string conn = @"Data Source=DESKTOP-LNRFFUR\SQLEXPRESS;Initial Catalog=Sim;Integrated Security=True";
            string query = "Select * from SIM";
            SqlConnection connection = new SqlConnection(conn);
            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                dataAdapter.Fill(dataSet, "SIM");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi :" + ex.Message);
            }
            return dataSet;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conn = @"Data Source=DESKTOP-LNRFFUR\SQLEXPRESS;Initial Catalog=Sim;Integrated Security=True";
            string query = "Select * from SIM where SoSim = '"+txtSS.Text+"'";
            SqlConnection connection = new SqlConnection(conn);
            
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader rd = command.ExecuteReader();
                if(rd.Read())
                {
                    MessageBox.Show("Mã : '"+rd["ID"].ToString()+"' và Ngày hết hạn là :'"+rd["NgayHetHan"].ToString()+"' ", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy kết quả", "Lỗi ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                connection.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi :" + ex.Message);
            }
        }
    }
}
