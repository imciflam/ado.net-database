using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MaterialSkin.Controls;

namespace KursovayaBD
{
    public partial class Form3 : MaterialForm
    {
        DataSet ds;
        SqlDataAdapter adapter;
        SqlCommandBuilder commandBuilder;
        string connectionString = @"Data Source=DESKTOP-72MPP4U\SQLEXPRESS;Initial Catalog=usersdb;Integrated Security=True";
        string sql = "SELECT * FROM Flight";

        public Form3()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                adapter = new SqlDataAdapter(sql, connection);

                ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }
 

 

 
        private void button4_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show("One of boxes was left empty, try again.");
            }
            else
            {
                string sql = "";
                string connectionString = @"Data Source=DESKTOP-72MPP4U\SQLEXPRESS;Initial Catalog=usersdb;Integrated Security=True";
                if (comboBox1.Text == "Category")
                {
                    sql = "SELECT * FROM Flight WHERE Category ='" + textBox1.Text + "'";
                }
                if (comboBox1.Text == "Company_name")
                {
                    sql = "SELECT * FROM Flight WHERE Company_name ='" + textBox1.Text + "'";
                }
                Form1 f = new Form1();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Exception occured. \n {ex}.\n Please return and retry.");
                return;
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                adapter = new SqlDataAdapter(sql, connection);

                ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DataRow row = ds.Tables[0].NewRow(); // добавляем новую строку в DataTable
            ds.Tables[0].Rows.Add(row);

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row);
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        { 
            try
            { 
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                adapter = new SqlDataAdapter(sql, connection);
                commandBuilder = new SqlCommandBuilder(adapter);
                adapter.InsertCommand = new SqlCommand("sp_CreateFlight", connection);
                adapter.InsertCommand.CommandType = CommandType.StoredProcedure;
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@Flight_id", SqlDbType.Int, 50, "Flight_id"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@Category", SqlDbType.VarChar, 50, "Category"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@Company_name", SqlDbType.VarChar, 50, "Company_name"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@Additions", SqlDbType.VarChar, 50, "Additions"));

                adapter.Update(ds);
            }
              }
            catch(SqlException ex)
            {
                MessageBox.Show($"Exception occured. \n {ex}.\n Please return and retry.");
                return;
            }
}
    }
}
