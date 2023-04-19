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
    public partial class Form2 : Form

    {
        public static bool check(string str)
        {
            return (String.IsNullOrEmpty(str) ||
                str.Trim().Length == 0) ? true : false;
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

            if (check(guna2TextBox3.Text) == true || check(guna2TextBox4.Text) == true)

            {
                MessageBox.Show("ERROR");
            }
            else
            {


                this.Hide();
                Form3.form1.Show();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (check(guna2TextBox1.Text)== true || check(guna2TextBox2.Text)==true)
            {
                MessageBox.Show("ERROR");
            }
            else
            {


                this.Hide();
                Form3.form4.Show();
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
