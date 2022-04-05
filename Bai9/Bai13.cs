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
    public partial class Bai13 : Form
    {
        public Bai13()
        {
            InitializeComponent();
            dataGridView1.DataSource = Load_form().Tables["SanPham"];
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public DataSet Load_form()
        {
            DataSet dataSet = new DataSet();
            string conn = @"Data Source=DESKTOP-LNRFFUR\SQLEXPRESS;Initial Catalog=PMStore;Integrated Security=True";
            string query = "Select * from SanPham order by SoLuongTon ASC";
            SqlConnection connection = new SqlConnection(conn);
            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                dataAdapter.Fill(dataSet, "SanPham");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi : " + ex.Message);
            }
            return dataSet;
        }
    }
}
