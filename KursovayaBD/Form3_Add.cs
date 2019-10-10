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
    public partial class Form3_Add : MaterialForm
    {
        private Form3 form3;

        public Form3_Add(Form3 form3)
        {
            this.form3 = form3;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                 
                DataRow row = form3.ds.Tables[0].NewRow(); // добавляем новую строку в DataTable
                form3.ds.Tables[0].Rows.Add(row);
                row["Flight_id"] = textBox1.Text; // fill em like this
                row["Category"] = textBox2.Text;
                row["Company_name"] = textBox3.Text;
                row["Additions"] = textBox4.Text; 
                MessageBox.Show("Flight was added successfully.\n Press `save` if you are finished.\n Press `Add` or `Remove` if you are not done.\n Double click any row to edit.");
                this.Close();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.ToString());
                foreach (DataGridViewRow row in form3.dataGridView1.SelectedRows)
                {
                    form3.dataGridView1.Rows.RemoveAt(form3.dataGridView1.Rows.Count - 1);
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
