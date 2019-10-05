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
    public partial class Form5_Add : Form
    {
        private Form5 form5;
        public Form5_Add(Form5 form5)
        {
            this.form5 = form5;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                DataRow row = form5.ds.Tables[0].NewRow(); // добавляем новую строку в DataTable
                form5.ds.Tables[0].Rows.Add(row);
                row["Direction_id"] = textBox1.Text; // fill em like this
                row["Distance"] = textBox2.Text;
                row["Destination"] = textBox3.Text;
                row["Time_of_arrival"] = textBox4.Text;
                row["Time_of_departure"] = textBox5.Text;
                MessageBox.Show(" Direction was added successfully.\n Press `save` if you are finished.\n Press `Add` or `Remove` if you are not done.\n Double click any row to edit.");
                this.Close();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.ToString());
                foreach (DataGridViewRow row in form5.dataGridView1.SelectedRows)
                {
                    form5.dataGridView1.Rows.RemoveAt(form5.dataGridView1.Rows.Count - 1);
                }
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Flight_id_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
