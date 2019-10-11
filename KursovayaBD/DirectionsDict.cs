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

namespace KursovayaBD
{
    public partial class DirectionsDict : Form
    {
        private Form1_Add form1_add;
        public DirectionsDict(Form1_Add form1_add)
        {
            InitializeComponent();
            DataSet ds;
            SqlDataAdapter adapter;
            // SqlCommandBuilder commandBuilder;
            string connectionString = @"Data Source=DESKTOP-72MPP4U\SQLEXPRESS;Initial Catalog=usersdb;Integrated Security=True";
            string sql = "SELECT Direction_ID, Destination FROM Direction";
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
    }
}
