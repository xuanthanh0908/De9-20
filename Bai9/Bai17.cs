﻿using System;
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
    public partial class Bai17 : Form
    {
        public Bai17()
        {
            InitializeComponent();
            dgvSP.DataSource = Load_form().Tables["SP"];
            dgvSP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public DataSet Load_form()
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
            string query = "UPDATE SANPHAM SET NhaCC = '"+txtNCC.Text+"' WHERE MASP = '"+txtMSP.Text+"'";
            SqlConnection connection = new SqlConnection(conn);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Sửa thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi :" + ex.Message);
            }
            dgvSP.DataSource = Load_form().Tables["SP"];
            dgvSP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
