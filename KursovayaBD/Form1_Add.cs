using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;
using System.Data.SqlClient;

namespace KursovayaBD
{
    public partial class Form1_Add : MaterialForm
    {
        private Form1 form1;

        public Form1_Add(Form1 form1)
        {
            this.form1 = form1;
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            InitializeComponent();

            string connectionString = @"Data Source=DESKTOP-72MPP4U\SQLEXPRESS;Initial Catalog=usersdb;Integrated Security=True";
            using (SqlConnection saConn = new SqlConnection(connectionString))
            {
                saConn.Open();

                string query1 = "SELECT Direction_ID FROM Direction";
                string query2 = "SELECT Flight_ID FROM Flight";
                string query3 = "SELECT Aircraft_ID FROM Aircraft";
                SqlCommand cmd1 = new SqlCommand(query1, saConn);
                SqlCommand cmd2 = new SqlCommand(query2, saConn);
                SqlCommand cmd3 = new SqlCommand(query3, saConn);

                using (SqlDataReader saReader = cmd1.ExecuteReader())
                {
                    while (saReader.Read())
                    {
                        var name = saReader.GetValue(0);
                        this.comboBox1.Items.Add(name);
                    }
                }
                using (SqlDataReader saReader = cmd2.ExecuteReader())
                {
                    while (saReader.Read())
                    {
                        var name = saReader.GetValue(0);
                        this.comboBox2.Items.Add(name);
                    }
                }
                using (SqlDataReader saReader = cmd3.ExecuteReader())
                {
                    while (saReader.Read())
                    {
                        var name = saReader.GetValue(0);
                        this.comboBox3.Items.Add(name);
                    }
                }
                saConn.Close();
            }
            string connectionString2 = @"Data Source=DESKTOP-72MPP4U\SQLEXPRESS;Initial Catalog=pilotsdb;Integrated Security=True";
            using (SqlConnection saConn = new SqlConnection(connectionString2))
            {
                saConn.Open();

                string query1 = "SELECT Pilot_ID FROM Pilot"; 
                SqlCommand cmd1 = new SqlCommand(query1, saConn); 

                using (SqlDataReader saReader = cmd1.ExecuteReader())
                {
                    while (saReader.Read())
                    {
                        var name = saReader.GetValue(0);
                        this.comboBox4.Items.Add(name);
                    }
                }
                saConn.Close();
            } 
            }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            try
            {
                 

                // textBox1.Text 
                DataRow row = form1.ds.Tables[0].NewRow(); // добавляем новую строку в DataTable
                form1.ds.Tables[0].Rows.Add(row);
                row["Ticket_id"] = textBox1.Text; // fill em like this
                row["Ticket_class"] = textBox2.Text;
                row["Place"] = textBox3.Text;
                row["Passenger_surname"] = textBox4.Text;
                row["Passenger_name"] = textBox5.Text;
                row["Passenger_middlename"] = textBox6.Text;
                row["Price"] = textBox7.Text;
                row["Discount"] = materialCheckBox1.Checked.ToString();
                row["Direction_id"] = comboBox1.Text;
                row["Flight_id"] = comboBox2.Text;
                row["Aircraft_id"] = comboBox3.Text;
                row["Pilot_id"] = comboBox4.Text;
                MessageBox.Show("Ticket was added successfully.\n Press `save` if you are finished.\n Press `Add` or `Remove` if you are not done.");
                this.Close();
            }
            catch(ArgumentException ex)
            {
                MessageBox.Show(ex.ToString());
                foreach (DataGridViewRow row in form1.dataGridView1.SelectedRows)
                {
                    form1.dataGridView1.Rows.RemoveAt(form1.dataGridView1.Rows.Count - 1);
                }
                return;
            }

        }
    }
}
