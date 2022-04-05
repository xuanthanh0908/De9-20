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
    public partial class Bai18 : Form
    {
        public Bai18()
        {
            InitializeComponent();
            dgvSP.DataSource = Load_Form().Tables["SP"];
            dgvSP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public DataSet Load_Form()
        {
            DataSet dataSet = new DataSet();
            string conn = @"Data Source=DESKTOP-LNRFFUR\SQLEXPRESS;Initial Catalog=PMStore;Integrated Security=True";
            string query = "Select * from SanPham";
            SqlConnection connection = new SqlConnection(conn);
            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                dataAdapter.Fill(dataSet, "SP");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi : " + ex.Message);
            }
            return dataSet;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conn = @"Data Source=DESKTOP-LNRFFUR\SQLEXPRESS;Initial Catalog=PMStore;Integrated Security=True";
            string query = "DELETE SANPHAM WHERE SOLUONGTON = 0 OR DATEDIFF(DAY,NGAYHETHAN,GETDATE()) >=0";
            SqlConnection connection = new SqlConnection(conn);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Xóa Thành công", "Thông  báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi : " + ex.Message);
            }
            dgvSP.DataSource = Load_Form().Tables["SP"];
            dgvSP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgvSP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1.PerformClick();
        }
    }
}
