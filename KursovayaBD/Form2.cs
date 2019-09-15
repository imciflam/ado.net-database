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
    public partial class Form2 : MaterialForm
    {
        DataSet ds;
        SqlDataAdapter adapter;
        SqlCommandBuilder commandBuilder;
        string connectionString = @"Data Source=DESKTOP-72MPP4U\SQLEXPRESS;Initial Catalog=pilotsdb;Integrated Security=True";
        string sql = "SELECT * FROM Pilot";
        public Form2()
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

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRow row = ds.Tables[0].NewRow(); // добавляем новую строку в DataTable
            ds.Tables[0].Rows.Add(row);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    adapter = new SqlDataAdapter(sql, connection);
                    commandBuilder = new SqlCommandBuilder(adapter);
                    adapter.InsertCommand = new SqlCommand("sp_CreatePilot", connection);
                    adapter.InsertCommand.CommandType = CommandType.StoredProcedure;
                    adapter.InsertCommand.Parameters.Add(new SqlParameter("@Pilot_id", SqlDbType.Int, 50, "Pilot_id"));
                    adapter.InsertCommand.Parameters.Add(new SqlParameter("@Pilot_surname", SqlDbType.VarChar, 50, "Pilot_surname"));
                    adapter.InsertCommand.Parameters.Add(new SqlParameter("@Pilot_name", SqlDbType.VarChar, 50, "Pilot_name"));
                    adapter.InsertCommand.Parameters.Add(new SqlParameter("@Pilot_middlename", SqlDbType.VarChar, 50, "Pilot_middlename"));
                    adapter.InsertCommand.Parameters.Add(new SqlParameter("@Pilot_date_of_birth", SqlDbType.Date, 50, "Pilot_date_of_birth"));
                    adapter.InsertCommand.Parameters.Add(new SqlParameter("@Pilot_hiring_date", SqlDbType.Date, 50, "Pilot_hiring_date"));
                    adapter.InsertCommand.Parameters.Add(new SqlParameter("@Pilot_category", SqlDbType.VarChar, 50, "Pilot_category"));

                    adapter.Update(ds);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Exception occured. \n {ex}.\n Please return and retry.");
                return;
            }
        }

        private void button4_Click(object sender, EventArgs e)
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
                string connectionString = @"Data Source=DESKTOP-72MPP4U\SQLEXPRESS;Initial Catalog=pilotsdb;Integrated Security=True";
                if (comboBox1.Text == "Pilot_hiring_date")
                {
                    sql = "SELECT * FROM Pilot WHERE Pilot_hiring_date ='" + textBox1.Text + "'";
                }
                if (comboBox1.Text == "Pilot_surname")
                {
                    sql = "SELECT * FROM Pilot WHERE Pilot_surname ='" + textBox1.Text + "'";
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

        private void button3_Click(object sender, EventArgs e)
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
    }
}
