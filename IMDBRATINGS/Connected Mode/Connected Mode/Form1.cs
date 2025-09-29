using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace Connected_Mode

{
    public partial class Form1 : Form
    {
        // ضع هنا Connection String الخاص بك
        string ordb = "Data Source=orcl;User Id=scott;Password=tiger;";
        OracleConnection conn;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        // 1. Select rows from DB using bind variables and command parameters
        private void btnSelectByGenre_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT MovieID ,Title FROM Movies WHERE Genre = :genre";
            cmd.Parameters.Add("genre", txtGenre.Text); 

            OracleDataReader dr = cmd.ExecuteReader();

            comboBox1.Items.Clear();

            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0].ToString() + "- " + dr[1]);
             
            }

            dr.Close();

        }

        // 2. Insert rows (without using procedures)
        private void btnInsertMovie_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "INSERT INTO Movies (MovieID, Title, ReleaseYear, Genre) VALUES (:id, :title, :year, :genre)";
            cmd.Parameters.Add("id", Convert.ToInt32(txtMovieID.Text));
            cmd.Parameters.Add("title", txtTitle.Text);
            cmd.Parameters.Add("year", Convert.ToInt32(txtYear.Text));
            cmd.Parameters.Add("genre", txtGenreInsert.Text);

            int r = cmd.ExecuteNonQuery();
            if (r != -1)
                MessageBox.Show("Movie inserted successfully!");
        }
        // 3. Select ONE row from DB using stored procedure (OUT parameter)
        private void btnGetRatingValueByID_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            
                cmd.Connection = conn;
                cmd.CommandText = "GetRatingValueByID"; 
                cmd.CommandType = CommandType.StoredProcedure;

                // IN parameter
                cmd.Parameters.Add("p_RatingID", OracleDbType.Int32).Value = Convert.ToInt32(txtRatingID.Text);

            // OUT parameter 
            cmd.Parameters.Add("p_RatingValue", OracleDbType.Decimal, ParameterDirection.Output);


            cmd.ExecuteNonQuery();
            // Display the result in a TextBox
            txtRatingValue.Text = cmd.Parameters["p_RatingValue"].Value.ToString();
            
        }

        // 4. Select multiple rows from DB using stored procedures
        private void btnGetRatingsForMovie_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "GetRatingsForMovie";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("p_MovieID", Convert.ToInt32(txtMovieIDMultiple.Text));

            cmd.Parameters.Add("p_Cursor", OracleDbType.RefCursor, ParameterDirection.Output);


            OracleDataReader dr = cmd.ExecuteReader();

            
            cmb_Ratings.Items.Clear();

            while (dr.Read())
            {

                cmb_Ratings.Items.Add(dr["RatingID"].ToString());
            }

            dr.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MainPage form5 = new MainPage();
            form5.Show();
            this.Hide();
        }

      
    }
}