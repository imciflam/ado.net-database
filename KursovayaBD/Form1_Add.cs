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
            DataRow row = form1.ds.Tables[0].NewRow(); // добавляем новую строку в DataTable
            form1.ds.Tables[0].Rows.Add(row);
            row["Ticket_id"] = 1; // fill em like this
            row["Ticket_class"] = 1;
            row["Place"] = 1;
            row["Passenger_surname"] = 1;
            row["Passenger_name"] = 1;
            row["Price"] = 1;
            row["Discount"] = 1;
            row["Direction_id"] = 3574;
            row["Flight_id"] = 1245;
            row["Aircraft_id"] = 321;
            row["Pilot_id"] = 666999;
            // form1.dataGridView1.Rows.Add(row);

        }
    }
}
