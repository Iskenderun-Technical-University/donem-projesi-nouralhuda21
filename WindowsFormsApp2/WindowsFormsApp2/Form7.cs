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
    public partial class Form7 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\LENOVO\source\proje3\donem-projesi-nouralhuda21\WindowsFormsApp2\WindowsFormsApp2\Database.mdf;Integrated Security=True");
        public Form7()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
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
                ques.textBox1.Text = dt.Rows[i][1].ToString();
                ques.guna2RadioButton1.Text = dt.Rows[i][2].ToString();
                ques.guna2RadioButton2.Text = dt.Rows[i][3].ToString();
                ques.guna2RadioButton3.Text = dt.Rows[i][4].ToString();
                ques.guna2RadioButton4.Text = dt.Rows[i][5].ToString();
                ques.Parent = flowLayoutPanel1;
            }
            dt.Clear();
        }
    }
}
