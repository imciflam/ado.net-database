﻿using System;
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
    public partial class Form6 : Form
    {
        DataSet ds;
        SqlDataAdapter adapter;
        // SqlCommandBuilder commandBuilder;
        string connectionString = @"Data Source=DESKTOP-72MPP4U\SQLEXPRESS;Initial Catalog=pilotsdb;Integrated Security=True";
        string sql = "SELECT * FROM Pilot ORDER BY Pilot_category, Pilot_surname";

        public Form6()
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

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
