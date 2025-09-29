using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;
namespace Connected_Mode
{
    public partial class cr2form : Form
    {
        CrystalReport2 cr2 = new CrystalReport2();
        public cr2form()
        {
            InitializeComponent();
        }

      
        private void cr2form_Load(object sender, EventArgs e)
        {
            cr2 = new CrystalReport2();
            foreach (ParameterDiscreteValue v in cr2.ParameterFields[0].DefaultValues){
                comboBox1.Items.Add(v.Value);
            }
        }
        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cr2.SetParameterValue(0, comboBox1.Text);
            crystalReportViewer1.ReportSource = cr2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainPage mp = new MainPage();
            mp.Show();
            this.Hide();
        }
    
    }
}
