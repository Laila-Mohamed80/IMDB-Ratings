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
    public partial class cr1form : Form
    {
        CrystalReport1 CR1;
        public cr1form()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            CR1 = new CrystalReport1();
            crystalReportViewer1.ReportSource = CR1;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

       
    }
}
