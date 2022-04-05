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
    public partial class Bai15 : Form
    {
        public Bai15()
        {
            InitializeComponent();
            dgvSP.DataSource = Load_form().Tables["SP"];
            dgvSP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public DataSet Load_form()
        {
            DataSet dataSet = new DataSet();
            string conn = @"";
            string query = "Select * from SanPham";
            SqlConnection connection = new SqlConnection(conn);
            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                dataAdapter.Fill(dataSet, "SP");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi :" + ex.Message);
            }
            return dataSet;
        }
    }
}
