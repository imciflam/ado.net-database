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
         

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            try
            {
                 

                // textBox1.Text 
                DataRow row = form1.ds.Tables[0].NewRow(); // добавляем новую строку в DataTable
                form1.ds.Tables[0].Rows.Add(row);
                row["Ticket_id"] = numericUpDown1.Value; // fill em like this
                row["Ticket_class"] = comboBox5.Text;
                row["Place"] = numericUpDown2.Value;
                row["Passenger_surname"] = textBox4.Text;
                row["Passenger_name"] = textBox5.Text;
                row["Passenger_middlename"] = textBox6.Text;
                row["Price"] = numericUpDown3.Value;
                row["Discount"] = materialCheckBox1.Checked.ToString();
                row["Direction_id"] = comboBox1.Text;
                row["Flight_id"] = comboBox2.Text;
                row["Aircraft_id"] = comboBox3.Text;
                row["Pilot_id"] = comboBox4.Text;
                MessageBox.Show(" Ticket was added successfully.\n Press `save` if you are finished.\n Press `Add` or `Remove` if you are not done.\n Double click any row to edit.");
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
        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBox4.Text, "^[a-zA-Z]+$"))
            {
                //var text = textBox4.Text;
                //textBox4.Text = text.Remove(text.Length - 1);

                textBox4.Text = "";
            } 
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

            if (!System.Text.RegularExpressions.Regex.IsMatch(textBox5.Text, "^[a-zA-Z]+$"))
            {
                //var text = textBox5.Text;
                //textBox5.Text = text.Remove(text.Length - 1);

                textBox5.Text = "";
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        { 
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBox6.Text, "^[a-zA-Z]+$"))
            {

                //var text = textBox6.Text;
                //textBox6.Text = text.Remove(text.Length - 1); 

                textBox6.Text = "";
            }
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = 0;
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            numericUpDown2.Value = 0; 
        }

        private void materialRaisedButton4_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
        }

        private void materialRaisedButton5_Click(object sender, EventArgs e)
        {
            textBox5.Text = ""; 
        }

        private void materialRaisedButton6_Click(object sender, EventArgs e)
        {
            textBox6.Text = ""; 
        }

        private void materialRaisedButton7_Click(object sender, EventArgs e)
        { 
            numericUpDown3.Value = 0;
        }

        private void materialRaisedButton8_Click(object sender, EventArgs e)
        {
            DirectionsDict fa = new DirectionsDict(this);
            fa.Show();
            
        }

        private void materialRaisedButton9_Click(object sender, EventArgs e)
        {
            FlightDict fa = new FlightDict(this);
            fa.Show();

        }

        private void materialRaisedButton10_Click(object sender, EventArgs e)
        {

            AircraftsDict fa = new AircraftsDict(this);
            fa.Show();
        }

        private void materialRaisedButton11_Click(object sender, EventArgs e)
        {

            PilotsDict fa = new PilotsDict(this);
            fa.Show();
        }
    }
}
