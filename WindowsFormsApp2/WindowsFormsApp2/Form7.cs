﻿using System;
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
    public partial class Form7 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\LENOVO\source\proje3\donem-projesi-nouralhuda21\WindowsFormsApp2\WindowsFormsApp2\Database.mdf;Integrated Security=True");

        public Form7()
        {
            InitializeComponent();
        }
        public void testc()
        {
            Timer t = new Timer();
            t.Interval = 10000*60 ;
            t.Tick += new EventHandler(timer1_Tick);
            t.Start();
            

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            string query = "insert into StNotes (StName , QuizType , Notes) values (@StName ,@QuizType ,@Notes) ";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@StName", Form3.form4.label11.Text);
            cmd.Parameters.AddWithValue("@QuizType", label2.Text);
            cmd.Parameters.AddWithValue("@Notes", QuesPanel.i * 5);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Your Note İs : " + QuesPanel.i * 5 + " and saved to table successfully");
            this.Close();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            testc();
            guna2Button1.Enabled = false;
            

            flowLayoutPanel1.Controls.Clear();
            DataTable dt = new DataTable();
            string query = "select * from DataQues Where QuizType = '" + label2.Text + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adb = new SqlDataAdapter(cmd);
            adb.Fill(dt);
            con.Close();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                QuesPanel ques = new QuesPanel();
                ques.label2.Text = dt.Rows[i][0].ToString();
                ques.textBox1.Text = dt.Rows[i][1].ToString();
                ques.guna2RadioButton1.Text = dt.Rows[i][2].ToString();
                ques.guna2RadioButton2.Text = dt.Rows[i][3].ToString();
                ques.guna2RadioButton3.Text = dt.Rows[i][4].ToString();
                ques.guna2RadioButton4.Text = dt.Rows[i][5].ToString();
                ques.Parent = flowLayoutPanel1;
            }
            dt.Clear();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            string query = "insert into StNotes (StName , QuizType , Notes) values (@StName ,@QuizType ,@Notes) ";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@StName", Form3.form4.label11.Text);
            cmd.Parameters.AddWithValue("@QuizType", label2.Text);
            cmd.Parameters.AddWithValue("@Notes", QuesPanel.i*5);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Your Note İs : " + QuesPanel.i * 5 + " and saved to table successfully");
            this.Close();
        }

        
    }
}
