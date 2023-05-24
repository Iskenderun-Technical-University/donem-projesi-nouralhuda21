using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form5 : Form

    {
        public static bool check(string str)
        {
            return (String.IsNullOrEmpty(str) ||
                str.Trim().Length == 0) ? true : false;
        }

        public Form5()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PictureBox1_Click(object sender, EventArgs e)


        {
            this.Hide();
            Form3.form1.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (check(guna2TextBox1.Text) == true  || check(guna2TextBox3.Text) == true)
  

            {
                MessageBox.Show("ERROR");
            }
            else
            {
                Form3.form6.label10.Text = guna2TextBox1.Text;

                this.Hide();
                Form3.form6.Show();
            }
            }

        private void guna2TextBox3_TextChanged_1(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(guna2TextBox3.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                guna2TextBox3.Text = guna2TextBox3.Text.Remove(guna2TextBox3.Text.Length - 1);
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
    }

