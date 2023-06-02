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
    public partial class Form4 : Form
    {
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\LENOVO\source\proje3\donem-projesi-nouralhuda21\WindowsFormsApp2\WindowsFormsApp2\Database.mdf;Integrated Security=True");


        public Form4()
        {
            InitializeComponent();
        }

        private void guna2CirclePictureBox10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3.form8.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3.form9.Show();

        }

        private void Form4_Load(object sender, EventArgs e)
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

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3.form2.Show();

        }
    }
}
