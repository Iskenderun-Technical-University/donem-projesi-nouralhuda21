using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    { 
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\LENOVO\source\proje3\donem-projesi-nouralhuda21\WindowsFormsApp2\WindowsFormsApp2\Database.mdf;Integrated Security=True");


        public Form1()

        {
            InitializeComponent();
        }
      

       private void Form1_Load(object sender, EventArgs e)
        {
            con.Open();
            string query = "select * from StudentLogin";
            string query2 = "select * from TeacherLogin";
            SqlCommand cmd2 = new SqlCommand(query2, con);
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter Adb = new SqlDataAdapter(cmd);
            SqlDataAdapter Adb2 = new SqlDataAdapter(cmd2);
            Adb.Fill(dt);
            Adb.Fill(dt2);
            string query3 = "select  count (distinct QuizType) From DataQues";
            string query4 = "select  count (*) From DataQues";
            SqlCommand cmd3 = new SqlCommand(query3, con);
            SqlCommand cmd4 = new SqlCommand(query4, con);
            label9.Text = cmd3.ExecuteScalar().ToString();
            label8.Text = cmd4.ExecuteScalar().ToString();
            con.Close();

           label6.Text = dt.Rows.Count.ToString();
            label7.Text = dt2.Rows.Count.ToString();
        }




        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
            
            Form3.form5.Show();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form3.form10.Show();
        }

        private void guna2ControlBox1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

