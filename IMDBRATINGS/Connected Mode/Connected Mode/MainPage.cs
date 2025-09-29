using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connected_Mode
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void disconnected_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }

        private void Connected_Click(object sender, EventArgs e)
        {
            Form1 frm3 = new Form1();
            frm3.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cr1form cr1 = new cr1form();
            cr1.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cr2form cr2 = new cr2form();
            cr2.Show();
            this.Hide();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {

        }
    }
}
