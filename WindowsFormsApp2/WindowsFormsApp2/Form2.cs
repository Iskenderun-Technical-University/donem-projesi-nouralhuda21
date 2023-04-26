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
    public partial class Form2 : Form

    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\LENOVO\source\proje3\donem-projesi-nouralhuda21\WindowsFormsApp2\WindowsFormsApp2\Database.mdf;Integrated Security=True");
        public static string userid;
        public static bool check(string str)

        {
            return (String.IsNullOrEmpty(str) ||
                str.Trim().Length == 0) ? true : false;
        }

        public Form2()
        {
            InitializeComponent();
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
            SqlCommand com = new SqlCommand();
            userid = guna2TextBox1.Text;

            if (check(guna2TextBox1.Text)== true || check(guna2TextBox2.Text)==true)
            {
                MessageBox.Show("ERROR");
            }
            else
            {
                con.Open();
                com.Connection = con;
                com.CommandText = " select * from StudentLogin where UserName='" + guna2TextBox1.Text +
                    "'And Password='" + guna2TextBox2.Text + "'";
                SqlDataReader reader = com.ExecuteReader();
                if (reader.Read())
                {
                    this.Hide();
                    Form3.form4.Show();
                    Form3.form4.label11.Text = userid;
                }
                else
                {
                    MessageBox.Show("" +
                 
                        "Invaild login datails!", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    guna2TextBox1.Clear(); guna2TextBox2.Clear(); guna2TextBox1.Focus();
                }
                con.Close();
               
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (check(guna2TextBox1.Text) == true || check(guna2TextBox2.Text) == true)
            {
                MessageBox.Show("ERROR");
            }
            else
            {
                con.Open();
                string query = " INSERT INTO StudentLogin(UserName , Password) VALUES(@UserName ,@Password)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@UserName", guna2TextBox1.Text);
                cmd.Parameters.AddWithValue("@Password", guna2TextBox2.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                guna2TextBox1.Clear();guna2TextBox2.Clear();
                guna2TextBox1.Focus();
                MessageBox.Show("User saved");
            }
        }

        private void guna2CirclePictureBox10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
