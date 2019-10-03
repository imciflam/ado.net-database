using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursovayaBD
{
    public partial class Form1_Add : Form
    {
        private Form1 form1;

        public Form1_Add(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1; 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        { 
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {

           // textBox1.Text
            form1.dataGridView1.Columns.Add("Ticket_id", "1");
            form1.dataGridView1.Columns.Add("Ticket_class", "First");
            form1.dataGridView1.Columns.Add("Place", "1");
            form1.dataGridView1.Columns.Add("Passenger_surname", "1");
            form1.dataGridView1.Columns.Add("Passenger_name", "1");
            form1.dataGridView1.Columns.Add("Passenger_middlename", "1");
            form1.dataGridView1.Columns.Add("Price", "1");
            form1.dataGridView1.Columns.Add("Discount", "1");
            form1.dataGridView1.Columns.Add("Direction_id", "3574");
            form1.dataGridView1.Columns.Add("Flight_id", "1235");
            form1.dataGridView1.Columns.Add("Aircraft_id", "321");
            form1.dataGridView1.Columns.Add("Pilot_id", "666999");

            object[] row = new object[] { "1", "Product 1", "1000", "1", "1", "1", "1", "1", "3574", "1235", "321", "666999" };

            // form1.dataGridView1.Rows.Add(row);

        }
    }
}
