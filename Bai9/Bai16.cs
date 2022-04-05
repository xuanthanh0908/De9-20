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
    public partial class Bai16 : Form
    {
        public Bai16()
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

                MessageBox.Show("Lỗi :" + ex.Message);
            }
            return dataSet;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conn = @"Data Source=DESKTOP-LNRFFUR\SQLEXPRESS;Initial Catalog=PMStore;Integrated Security=True";
            string query = "INSERT INTO SANPHAM VALUES(@MASP,@TENSP,@SLTON,@NGAYSX,@NGAYHH,@NCC)";
            SqlConnection connection = new SqlConnection(conn);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MASP", txtMSP.Text);
                command.Parameters.AddWithValue("@TENSP", txtTSP.Text);
                command.Parameters.AddWithValue("@SLTON", int.Parse(txtSL.Text));
                command.Parameters.AddWithValue("@NGAYSX", DateNSX.Value.Date);
                command.Parameters.AddWithValue("@NGAYHH", DateNHH.Value.Date);
                command.Parameters.AddWithValue("@NCC", txtNCC.Text);
                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Thêm mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi :" + ex.Message);
            }
            dgvSP.DataSource = Load_Form().Tables["SP"];
            dgvSP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
