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

namespace KursovayaBD
{
    public partial class Form10 : Form
    {
        DataSet ds;
        SqlDataAdapter adapter;
        // SqlCommandBuilder commandBuilder;
        string connectionString = @"Data Source=DESKTOP-72MPP4U\SQLEXPRESS;Initial Catalog=usersdb;Integrated Security=True";
        string sql = "SELECT Passenger_surname, Passenger_name, Passenger_middlename, Pilot_surname, Pilot_name, Pilot_middlename FROM usersdb.dbo.Ticket " +
            "INNER JOIN  pilotsdb.dbo.Pilot on usersdb.dbo.Ticket.Pilot_id = pilotsdb.dbo.Pilot.Pilot_id " +
            "ORDER BY Passenger_surname";
        // string sql1 = " SELECT * FROM pilotsdb.dbo.Pilot";
        public Form10()
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
    }
}
