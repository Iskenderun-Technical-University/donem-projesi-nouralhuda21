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

            if (guna2TextBox3.Text == "" && guna2TextBox4.Text == "")
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
            if (guna2TextBox1.Text == "" && guna2TextBox2.Text == "")
            {
                MessageBox.Show("ERROR");
            }
            else
            {


                this.Hide();
                Form3.form4.Show();
            }
        }
    }
}
