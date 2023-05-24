using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            
            InitializeComponent();
            }
        public static Form1  form1 = new Form1();
        public static Form2 form2 = new Form2();
        public static Form4 form4 = new Form4();
        public static Form5 form5 = new Form5();
        public static Form6 form6 = new Form6();
        public static Form7 form7 = new Form7();
        public static Form8 form8 = new Form8();
        public static Form9 form9 = new Form9();
        public static QuesPanel Panel = new QuesPanel();

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Hide();
            form2.Show();
            timer1.Stop();
        }
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
    }

       
    

