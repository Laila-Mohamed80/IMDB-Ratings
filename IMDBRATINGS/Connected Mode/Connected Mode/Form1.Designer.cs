
namespace Connected_Mode
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMovieID = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtGenreInsert = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtRatingID = new System.Windows.Forms.TextBox();
            this.txtRatingValue = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.txtMovieIDMultiple = new System.Windows.Forms.TextBox();
            this.cmb_Ratings = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(150, 68);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(219, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "Movie IDs by Genre";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(246, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Select by Genre";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnSelectByGenre_Click);
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(100, 21);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(100, 20);
            this.txtGenre.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Genre :";
            // 
            // txtMovieID
            // 
            this.txtMovieID.Location = new System.Drawing.Point(174, 120);
            this.txtMovieID.Name = "txtMovieID";
            this.txtMovieID.Size = new System.Drawing.Size(195, 20);
            this.txtMovieID.TabIndex = 4;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(174, 154);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(195, 20);
            this.txtTitle.TabIndex = 5;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(174, 188);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(195, 20);
            this.txtYear.TabIndex = 6;
            // 
            // txtGenreInsert
            // 
            this.txtGenreInsert.Location = new System.Drawing.Point(174, 220);
            this.txtGenreInsert.Name = "txtGenreInsert";
            this.txtGenreInsert.Size = new System.Drawing.Size(195, 20);
            this.txtGenreInsert.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Movie ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Title :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Year :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Genre :";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(383, 173);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 31);
            this.button2.TabIndex = 12;
            this.button2.Text = "Insert Movie";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnInsertMovie_Click);
            // 
            // txtRatingID
            // 
            this.txtRatingID.Location = new System.Drawing.Point(174, 290);
            this.txtRatingID.Name = "txtRatingID";
            this.txtRatingID.Size = new System.Drawing.Size(195, 20);
            this.txtRatingID.TabIndex = 13;
            // 
            // txtRatingValue
            // 
            this.txtRatingValue.Location = new System.Drawing.Point(174, 327);
            this.txtRatingValue.Name = "txtRatingValue";
            this.txtRatingValue.Size = new System.Drawing.Size(195, 20);
            this.txtRatingValue.TabIndex = 14;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(383, 300);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 32);
            this.button3.TabIndex = 15;
            this.button3.Text = "Get Rating Value";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnGetRatingValueByID_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(102, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Rating ID :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(93, 330);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Rating Value :";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(383, 428);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(159, 31);
            this.button4.TabIndex = 18;
            this.button4.Text = "Get Ratings for Movie";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnGetRatingsForMovie_Click);
            // 
            // txtMovieIDMultiple
            // 
            this.txtMovieIDMultiple.Location = new System.Drawing.Point(174, 415);
            this.txtMovieIDMultiple.Name = "txtMovieIDMultiple";
            this.txtMovieIDMultiple.Size = new System.Drawing.Size(195, 20);
            this.txtMovieIDMultiple.TabIndex = 19;
            // 
            // cmb_Ratings
            // 
            this.cmb_Ratings.FormattingEnabled = true;
            this.cmb_Ratings.Location = new System.Drawing.Point(174, 458);
            this.cmb_Ratings.Name = "cmb_Ratings";
            this.cmb_Ratings.Size = new System.Drawing.Size(195, 21);
            this.cmb_Ratings.TabIndex = 20;
            this.cmb_Ratings.Text = "Get RatingId By MovieId";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(104, 418);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Movie ID :";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(41, 474);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(101, 37);
            this.button5.TabIndex = 22;
            this.button5.Text = "MainView";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 523);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmb_Ratings);
            this.Controls.Add(this.txtMovieIDMultiple);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtRatingValue);
            this.Controls.Add(this.txtRatingID);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGenreInsert);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtMovieID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMovieID;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtGenreInsert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtRatingID;
        private System.Windows.Forms.TextBox txtRatingValue;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtMovieIDMultiple;
        private System.Windows.Forms.ComboBox cmb_Ratings;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button5;
    }
}

