 
using MaterialSkin.Controls;
using MaterialSkin;
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
    public partial class Form2_Add : MaterialForm
    {
        private Form2 form2;
        public Form2_Add(Form2 form2)
        { 
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
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
                row["Pilot_id"] = numericUpDown1.Value; // fill em like this
                row["Pilot_surname"] = textBox2.Text;
                row["Pilot_name"] = textBox3.Text;
                row["Pilot_middlename"] = textBox4.Text;
                row["Pilot_date_of_birth"] = maskedTextBox1.Text;
                row["Pilot_hiring_date"] = maskedTextBox2.Text;
                row["Pilot_category"] = comboBox1.Text;
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

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, "^[a-zA-Z]+$"))
            {
                textBox2.Text = "";
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBox3.Text, "^[a-zA-Z]+$"))
            {
                textBox3.Text = "";
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBox4.Text, "^[a-zA-Z]+$"))
            {
                textBox4.Text = "";
            }
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {

            numericUpDown1.Value = 0;
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {

            textBox2.Text = "";
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";

        }

        private void materialRaisedButton4_Click(object sender, EventArgs e)
        {

            textBox4.Text = "";
        }

        private void materialRaisedButton5_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "";
        }

        private void materialRaisedButton6_Click(object sender, EventArgs e)
        {
            maskedTextBox2.Text = "";
        }
    }
}
