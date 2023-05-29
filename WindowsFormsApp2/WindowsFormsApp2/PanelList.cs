using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class PanelList : UserControl
    {
        public PanelList()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form7 form = new Form7();
            form.label2.Text = this.label1.Text;
            form.ShowDialog();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
