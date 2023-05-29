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
    public partial class QuesPanel : UserControl

    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\LENOVO\source\proje3\donem-projesi-nouralhuda21\WindowsFormsApp2\WindowsFormsApp2\Database.mdf;Integrated Security=True");
        public static int i = 0;
        public QuesPanel()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
   
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            guna2Button1.Enabled = false;
            string query = "select CorrectAnswer from DataQues where id = '" + label2.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            if (guna2RadioButton1.Checked)
            {
                if (guna2RadioButton1.Text == cmd.ExecuteScalar().ToString())
                {
                    i++;

                }


            }
            else if (guna2RadioButton2.Checked)
            {
                if (guna2RadioButton2.Text == cmd.ExecuteScalar().ToString())
                {
                    i++;

                }
            }
            else if (guna2RadioButton3.Checked)
            {
                if (guna2RadioButton3.Text == cmd.ExecuteScalar().ToString())
                {
                    i++;
                }
            }
            else if (guna2RadioButton4.Checked)
            {
                if (guna2RadioButton4.Text == cmd.ExecuteScalar().ToString())
                {
                    i++;

                }
            }
            con.Close();
        }
    }
}
