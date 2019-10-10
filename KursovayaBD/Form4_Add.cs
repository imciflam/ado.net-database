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

namespace KursovayaBD
{
    public partial class Form4_Add : MaterialForm
    {
        private Form4 form4;
        public Form4_Add(Form4 form4)
        {
            this.form4 = form4;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                DataRow row = form4.ds.Tables[0].NewRow(); // добавляем новую строку в DataTable
                form4.ds.Tables[0].Rows.Add(row);
                row["Aircraft_id"] = numericUpDown1.Value; // fill em like this
                row["Aircraft_type"] = textBox2.Text;
                row["Aircraft_capacity"] = numericUpDown2.Text;
                row["Aircraft_date_of_manufacture"] = maskedTextBox1.Text;
                MessageBox.Show(" Aircraft was added successfully.\n Press `save` if you are finished.\n Press `Add` or `Remove` if you are not done.\n Double click any row to edit.");
                this.Close();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.ToString());
                foreach (DataGridViewRow row in form4.dataGridView1.SelectedRows)
                {
                    form4.dataGridView1.Rows.RemoveAt(form4.dataGridView1.Rows.Count - 1);
                }
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
        }
    }
}
