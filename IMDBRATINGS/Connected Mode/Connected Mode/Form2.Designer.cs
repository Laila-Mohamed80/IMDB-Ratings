namespace Connected_Mode
{
    partial class Form2
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
            this.movie_title = new System.Windows.Forms.Label();
            this.search_box = new System.Windows.Forms.TextBox();
            this.search_btn = new System.Windows.Forms.Button();
            this.dgv_MoiveReviews = new System.Windows.Forms.DataGridView();
            this.Next = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MoiveReviews)).BeginInit();
            this.SuspendLayout();
            // 
            // movie_title
            // 
            this.movie_title.AutoSize = true;
            this.movie_title.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movie_title.Location = new System.Drawing.Point(37, 25);
            this.movie_title.Name = "movie_title";
            this.movie_title.Size = new System.Drawing.Size(88, 18);
            this.movie_title.TabIndex = 0;
            this.movie_title.Text = "Movie Title";
            // 
            // search_box
            // 
            this.search_box.Location = new System.Drawing.Point(153, 23);
            this.search_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.search_box.Name = "search_box";
            this.search_box.Size = new System.Drawing.Size(271, 20);
            this.search_box.TabIndex = 1;
            // 
            // search_btn
            // 
            this.search_btn.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_btn.Location = new System.Drawing.Point(429, 21);
            this.search_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(64, 24);
            this.search_btn.TabIndex = 2;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // dgv_MoiveReviews
            // 
            this.dgv_MoiveReviews.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_MoiveReviews.Location = new System.Drawing.Point(68, 89);
            this.dgv_MoiveReviews.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_MoiveReviews.Name = "dgv_MoiveReviews";
            this.dgv_MoiveReviews.RowHeadersWidth = 51;
            this.dgv_MoiveReviews.RowTemplate.Height = 26;
            this.dgv_MoiveReviews.Size = new System.Drawing.Size(757, 325);
            this.dgv_MoiveReviews.TabIndex = 3;
            this.dgv_MoiveReviews.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_MoiveReviews_CellContentClick);
            // 
            // Next
            // 
            this.Next.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Next.Location = new System.Drawing.Point(1042, 557);
            this.Next.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(117, 29);
            this.Next.TabIndex = 4;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.exit_btn.Location = new System.Drawing.Point(1042, 591);
            this.exit_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(117, 31);
            this.exit_btn.TabIndex = 5;
            this.exit_btn.Text = "Exit";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(912, 587);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "Mainview";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 631);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.dgv_MoiveReviews);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.search_box);
            this.Controls.Add(this.movie_title);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ViewReviews_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MoiveReviews)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label movie_title;
        private System.Windows.Forms.TextBox search_box;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.DataGridView dgv_MoiveReviews;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Button button1;
    }
}

