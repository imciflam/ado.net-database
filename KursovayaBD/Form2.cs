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
using System.IO;

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

        private void button6_Click(object sender, EventArgs e)
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
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }
                // save the application  
                workbook.SaveAs("C:\\Users\\Vitalia\\Desktop\\reports\\xlsxpilots.xlsx", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                // Exit from the application  
                MessageBox.Show("Data Exported");
                app.Quit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TextWriter writer = new StreamWriter("C:\\Users\\Vitalia\\Desktop\\reports\\textpilots.txt");
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
