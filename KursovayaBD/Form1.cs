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
using MaterialSkin;
using System.IO;

namespace KursovayaBD
{
    public partial class Form1 : MaterialForm
    { 
        // adonet
        DataSet ds;
        SqlDataAdapter adapter;
        SqlCommandBuilder commandBuilder;
        string connectionString = @"Data Source=DESKTOP-72MPP4U\SQLEXPRESS;Initial Catalog=usersdb;Integrated Security=True";
        // string connectionString2 = @"Data Source=DESKTOP-72MPP4U\SQLEXPRESS;Initial Catalog=usersdb;Integrated Security=True";
        string sql = "SELECT * FROM Ticket";
        public Form1()
        {
            InitializeComponent();
            // menuStrip1.Items.Add("|");
            // ToolStripSeparator toolStripSeparator = new ExtendedToolStripSeparator();
            // this.menuStrip1.Add(toolStripSeparator);

            // var materialSkinManager = MaterialSkinManager.Instance;
            // materialSkinManager.AddFormToManage(this);
            // materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            //  materialSkinManager.ColorScheme = new ColorScheme(Primary)
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

        private void mbutton1_Click(object sender, EventArgs e)
        {

            DataRow row = ds.Tables[0].NewRow(); // добавляем новую строку в DataTable
            ds.Tables[0].Rows.Add(row);
            
            /*Form2 f = new Form2();
            f.ShowDialog();*/
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mbutton4_Click(object sender, EventArgs e)//filter button
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
                    if (comboBox1.Text == "Ticket_class")
                    {
                        sql = "SELECT * FROM Ticket WHERE Ticket_class ='" + textBox1.Text + "'";
                    }
                    if (comboBox1.Text == "Passenger_surname")
                    {
                        sql = "SELECT * FROM Ticket WHERE Passenger_surname ='" + textBox1.Text + "'";
                    }
                    if (comboBox1.Text == "Ticket_id")
                    {
                        sql = "SELECT * FROM Ticket WHERE Ticket_id ='" + textBox1.Text + "'";
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void mbutton3_Click(object sender, EventArgs e)
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

        private void mainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            string connectionString = @"Data Source=DESKTOP-72MPP4U\SQLEXPRESS;Initial Catalog=usersdb;Integrated Security=True";
            string sql = "SELECT * FROM Ticket";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }

        }

        private void mbutton5_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    adapter = new SqlDataAdapter(sql, connection);
                    commandBuilder = new SqlCommandBuilder(adapter);
                    adapter.InsertCommand = new SqlCommand("sp_CreateTicket", connection);
                    adapter.InsertCommand.CommandType = CommandType.StoredProcedure;
                    adapter.InsertCommand.Parameters.Add(new SqlParameter("@Ticket_id", SqlDbType.Int, 50, "Ticket_id"));
                    adapter.InsertCommand.Parameters.Add(new SqlParameter("@Ticket_class", SqlDbType.VarChar, 50, "Ticket_class"));
                    adapter.InsertCommand.Parameters.Add(new SqlParameter("@Place", SqlDbType.SmallInt, 50, "Place"));
                    adapter.InsertCommand.Parameters.Add(new SqlParameter("@Passenger_surname", SqlDbType.VarChar, 50, "Passenger_surname"));
                    adapter.InsertCommand.Parameters.Add(new SqlParameter("@Passenger_name", SqlDbType.VarChar, 50, "Passenger_name"));
                    adapter.InsertCommand.Parameters.Add(new SqlParameter("@Passenger_middlename", SqlDbType.VarChar, 50, "Passenger_middlename"));
                    adapter.InsertCommand.Parameters.Add(new SqlParameter("@Price", SqlDbType.Money, 10, "Price"));
                    adapter.InsertCommand.Parameters.Add(new SqlParameter("@Discount", SqlDbType.Bit, 0, "Discount"));
                    adapter.InsertCommand.Parameters.Add(new SqlParameter("@Direction_id", SqlDbType.Int, 50, "Direction_id"));
                    adapter.InsertCommand.Parameters.Add(new SqlParameter("@Flight_id", SqlDbType.Int, 50, "Flight_id"));
                    adapter.InsertCommand.Parameters.Add(new SqlParameter("@Aircraft_id", SqlDbType.Int, 50, "Aircraft_id"));
                    adapter.InsertCommand.Parameters.Add(new SqlParameter("@Pilot_id", SqlDbType.Int, 50, "Pilot_id"));
                    adapter.Update(ds);
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show($"Exception occured. \n {ex}.\n Please return and retry.");
                return;
            }
        }

        private void mbutton2_Click(object sender, EventArgs e)//remove
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row);
            }
        }

        private void flightsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.ShowDialog();
        }

        private void pilotsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();

        }

        private void airfractsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.ShowDialog();
        }

        private void directionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 f = new Form5();
            f.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sortPilotsBySurnameAndCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 f = new Form6();
            f.ShowDialog();
        }

        private void sortPassengersByClassAndPlaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 f = new Form7();
            f.ShowDialog();
        }

        private void discountInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 f = new Form8();
            f.ShowDialog();
        }

        private void calculateRevenueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 f = new Form9();
            f.ShowDialog();
        }

        private void getInformationAboutPassengersDestinationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 f = new Form10();
            f.ShowDialog();
        }

        private void materialTabSelector1_Click(object sender, EventArgs e)
        {

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            try
            {
                 
            // creating Excel Application  
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // creating new WorkBook within Excel application  
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // creating new Excelsheet in workbook  
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // see the excel sheet behind the program  
            app.Visible = true;
            // get the reference of first sheet. By default its name is Sheet1.  
            // store its reference to worksheet  
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            // changing the name of active sheet  
            worksheet.Name = "Exported from gridview";
            // storing header part in Excel  
            for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                }
            }
            // save the application  
            workbook.SaveAs("C:\\Users\\Vitalia\\Desktop\\reports\\output.xlsx", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            // Exit from the application  
            app.Quit();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            TextWriter writer = new StreamWriter("C:\\Users\\Vitalia\\Desktop\\reports\\text.txt");
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    writer.Write("\t" + dataGridView1.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                }
                writer.WriteLine("");
                writer.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            }
            writer.Close();
            MessageBox.Show("Data Exported");

        }
    }
}
