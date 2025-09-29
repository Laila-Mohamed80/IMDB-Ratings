using Oracle.DataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;

namespace Connected_Mode
{
    public partial class UpdateInformation_Form : Form
    {
        OracleDataAdapter adapter;
        DataSet ds;
        OracleCommandBuilder builder;
        string currentTable = "";
        string pkColumn = "";

        string constr = "User Id =hr;Password=1234;Data Source=orcl";
        public UpdateInformation_Form()
        {
            InitializeComponent();
        }

        private void LoadInformation_btn_Click(object sender, EventArgs e)
        {
            if (rdo_Movies.Checked)
            {
                currentTable = "Movies";
                pkColumn = "MovieID";
            }
            else if (rdo_Users.Checked)
            {
                currentTable = "Users";
                pkColumn = "UserID";
            }
            else if (rdo_Reviews.Checked)
            {
                currentTable = "Reviews";
                pkColumn = "ReviewID";
            }
            else if (rdo_Rating.Checked)
            {
                currentTable = "Ratings";
                pkColumn = "RatingID";
            }

            string cmdstr = "SELECT * FROM {currentTable}";

            adapter = new OracleDataAdapter(cmdstr, constr);
            ds = new DataSet();
            adapter.Fill(ds);

            DataTable dt = ds.Tables[0];

            if (dt.Columns.Contains(pkColumn))
                dt.PrimaryKey = new DataColumn[] { dt.Columns[pkColumn] };

            dgv_Informations.DataSource = dt;

            if (dt.Columns.Contains(pkColumn))
                dgv_Informations.Columns[pkColumn].ReadOnly = true;

            adapter.DeleteCommand = new OracleCommand(
                 "DELETE FROM {currentTable} WHERE {pkColumn} = :id", new OracleConnection(constr));
            adapter.DeleteCommand.Parameters.Add(":id", OracleDbType.Int32, 0, pkColumn);
        }

        private void save_btn_Click(object sender, EventArgs e)
        {

            builder = new OracleCommandBuilder(adapter);

            adapter.Update(ds.Tables[0]);
            MessageBox.Show("Your changes have been saved successfully.");

        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (dgv_Informations.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow selectedRow in dgv_Informations.SelectedRows)
                {
                    DataRow row = ((DataRowView)selectedRow.DataBoundItem).Row;
                    row.Delete();
                }


                adapter.Update(ds.Tables[0]);
                MessageBox.Show("Deleted successfully.");
            }
            else
            {
                MessageBox.Show("Please select the row first.");
            }

        }

        private void Previous_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Close();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UpdateInformation_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
