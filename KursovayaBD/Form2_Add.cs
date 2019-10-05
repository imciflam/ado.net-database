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
    public partial class Form2_Add : Form
    {
        private Form2 form2;
        public Form2_Add(Form2 form2)
        {
            this.form2 = form2;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                // textBox1.Text 
                DataRow row = form2.ds.Tables[0].NewRow(); // добавляем новую строку в DataTable
                form2.ds.Tables[0].Rows.Add(row);
                row["Pilot_id"] = textBox1.Text; // fill em like this
                row["Pilot_surname"] = textBox2.Text;
                row["Pilot_name"] = textBox3.Text;
                row["Pilot_middlename"] = textBox4.Text;
                row["Pilot_date_of_birth"] = textBox5.Text;
                row["Pilot_hiring_date"] = textBox6.Text;
                row["Pilot_category"] = textBox7.Text;
                MessageBox.Show(" Pilot was added successfully.\n Press `save` if you are finished.\n Press `Add` or `Remove` if you are not done.\n Double click any row to edit.");
                this.Close();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.ToString());
                foreach (DataGridViewRow row in form2.dataGridView1.SelectedRows)
                {
                    form2.dataGridView1.Rows.RemoveAt(form2.dataGridView1.Rows.Count - 1);
                }
                return;
            }

        }
    }
}
