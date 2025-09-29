using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System;
using System.Collections;
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
    public partial class Form2 : Form
    {
        OracleDataAdapter adapter;
        DataSet ds;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void search_btn_Click(object sender, EventArgs e)
        {
            string constr = "Data Source=orcl;User Id=scott;Password=tiger;";
            string cmdstr = @"
                    select r.ReviewID, m.Title, u.Username, r.ReviewText, r.ReviewDate
                    from Reviews r, Movies m, Users u
                    where r.MovieID = m.MovieID
                    and r.UserID = u.UserID
                    and LOWER(m.Title) = LOWER(:title)";
            adapter = new OracleDataAdapter(cmdstr, constr);
            adapter.SelectCommand.Parameters.Add("title", search_box.Text);
            ds = new DataSet();
            adapter.Fill(ds);
            dgv_MoiveReviews.DataSource = ds.Tables[0];
        }
        private void Next_Click(object sender, EventArgs e)
        {
            UpdateInformation_Form frm = new UpdateInformation_Form();
            frm.Show();
            this.Hide();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgv_MoiveReviews_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ViewReviews_Form_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainPage form6 = new MainPage();
            form6.Show();
            this.Hide();
        }
    }
}
