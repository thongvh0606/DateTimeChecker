using DateTimeChecker;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTimeChecker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtDay.Text = "";
            txtMonth.Text = "";
            txtYear.Text = "";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure to exit?", "Confirm", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else if (dialog == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (txtDay.Text.Equals("") || txtMonth.Text.Equals("")||txtYear.Text.Equals(""))
            {
                DialogResult dialog = MessageBox.Show("Please fill up all data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;                
            }
            byte day, month;
            ushort year;
            bool isDay = byte.TryParse(txtDay.Text, out day);
            bool isMonth = byte.TryParse(txtMonth.Text, out month);
            bool isYear = ushort.TryParse(txtYear.Text, out year);
            if (isDay)
            {

                if (day < 1 || day > 31)
                {
                    DialogResult dialog = MessageBox.Show( "Input data for Day is out of range","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Input data for Day is incorrect format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (isMonth)
            {

                if (month < 1 || month > 12)
                {
                    DialogResult dialog = MessageBox.Show("Input data for Month is out of range", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Input data for Month is incorrect format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (isYear)
            {

                if (year < 1000 || year > 3000)
                {
                    DialogResult dialog = MessageBox.Show("Input data for Year is out of range", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Input data for Year is incorrect format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Checker.IsValiDate(year, month, day))
            {
                DialogResult dialog = MessageBox.Show("dd/mm/yyyy is correct date time!","Message",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else
            {
                DialogResult dialog = MessageBox.Show("dd/mm/yyyy is NOT correct date time!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
    }



}


