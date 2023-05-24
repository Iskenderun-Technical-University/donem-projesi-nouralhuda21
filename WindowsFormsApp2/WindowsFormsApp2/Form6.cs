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
    public partial class Form6 : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\LENOVO\source\proje3\donem-projesi-nouralhuda21\WindowsFormsApp2\WindowsFormsApp2\Database.mdf;Integrated Security=True");
        public static bool check(string str)
        {
            return (String.IsNullOrEmpty(str) ||
                str.Trim().Length == 0) ? true : false;
        }
        public DataTable LoadUserTable()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM DataQues";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public Form6()

        {
            InitializeComponent();
        }

       

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.DataQues' table. You can move, or remove it, as needed.
            this.dataQuesTableAdapter.Fill(this.databaseDataSet.DataQues);
            dataGridView1.DataSource = LoadUserTable();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (check(textBox1.Text) == true || check(textBox2.Text) == true || check(textBox3.Text) == true || check(textBox4.Text) == true || check(textBox5.Text) == true || check(textBox6.Text) == true)
            {
                MessageBox.Show("please enter the required data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string query = "insert into DataQues (Question , FirstOption , SecondOption , ThirdOption , FourthOption , CorrectAnswer , QuizType ) values (@Question , @FirstOption , @SecondOption , @ThirdOption , @FourthOption , @CorrectAnswer , @QuizType )";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                cmd.Parameters.AddWithValue("@Question", textBox1.Text);
                cmd.Parameters.AddWithValue("@FirstOption", textBox2.Text);
                cmd.Parameters.AddWithValue("@SecondOption", textBox3.Text);
                cmd.Parameters.AddWithValue("@ThirdOption", textBox4.Text);
                cmd.Parameters.AddWithValue("@FourthOption", textBox5.Text);
                cmd.Parameters.AddWithValue("@CorrectAnswer", textBox6.Text);
                cmd.Parameters.AddWithValue("@QuizType", label10.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Your Question Saved in your sql table", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = LoadUserTable();
            }



        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count != 0)
                {
                    textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    textBox5.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                    textBox6.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

                }

            }

            catch (Exception)
            {
                throw;
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            if (check(textBox1.Text) == true || check(textBox2.Text) == true || check(textBox3.Text) == true || check(textBox4.Text) == true || check(textBox5.Text) == true || check(textBox6.Text) == true)
            {
                MessageBox.Show("please enter the required data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                con.Open();
                string query = "DELETE FROM DataQues WHERE ID=" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("deleted successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = LoadUserTable();
                textBox1.Clear(); textBox2.Clear(); textBox3.Clear(); textBox4.Clear(); textBox5.Clear(); textBox6.Clear();
            }
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
