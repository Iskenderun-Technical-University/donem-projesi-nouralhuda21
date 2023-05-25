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
    public partial class Form9 : Form


    {  SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\LENOVO\source\proje3\donem-projesi-nouralhuda21\WindowsFormsApp2\WindowsFormsApp2\Database.mdf;Integrated Security=True");
        
        public Form9()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form9_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string query = "select distinct QuizType From DataQues";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adb = new SqlDataAdapter(cmd);
            adb.Fill(dt);
            con.Close();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
              
                PanelList list = new PanelList();
                list.label1.Text = dt.Rows[i][0].ToString();
              
                list.Parent = flowLayoutPanel1;
            }
            dt.Clear();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3.form4.Show();
        }
    }
}
