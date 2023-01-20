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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CRUDA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Insert into student values (@ID, @Name, @Department)", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(txtbxID.Text));
            cmd.Parameters.AddWithValue("@Name", txbxName.Text);
            cmd.Parameters.AddWithValue("@Department", txtbxDepartment.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully saved");
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from student", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd=new SqlCommand("delete from student where id="+ int.Parse(txtbxID.Text), con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully deleted");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("update student set Name = '"+ txbxName.Text+"',Department='"+txtbxDepartment.Text+"'where ID = '"+int.Parse(txtbxID.Text)+"'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully updated");
        }
    }
}
