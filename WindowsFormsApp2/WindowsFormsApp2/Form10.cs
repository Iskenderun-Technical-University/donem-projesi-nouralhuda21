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
    public partial class Form10 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\LENOVO\source\proje3\donem-projesi-nouralhuda21\WindowsFormsApp2\WindowsFormsApp2\Database.mdf;Integrated Security=True");
        public DataTable LoadUserTable()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM StNotes";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet1.StNotes' table. You can move, or remove it, as needed.
            this.stNotesTableAdapter.Fill(this.databaseDataSet1.StNotes);
            dataGridView1.DataSource = LoadUserTable();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3.form1.Show();
        }
    }
}
