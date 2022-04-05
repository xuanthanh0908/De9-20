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
    public partial class Bai14 : Form
    {
        public Bai14()
        {
            InitializeComponent();
            dgvSP.DataSource = Load_Form().Tables["SP"];
            dgvSP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public DataSet Load_Form()
        {
            DataSet dataSet = new DataSet();
            string conn = @"Data Source=DESKTOP-LNRFFUR\SQLEXPRESS;Initial Catalog=PMStore;Integrated Security=True";
            string query = "SELECT * FROM SANPHAM WHERE SOLUONGTON = 0 OR DATEDIFF(DAY,NGAYHETHAN,GETDATE()) >=0";
            SqlConnection conection = new SqlConnection(conn);
            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conection);
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
