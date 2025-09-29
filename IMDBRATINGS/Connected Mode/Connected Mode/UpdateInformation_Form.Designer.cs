namespace Connected_Mode
{
    partial class UpdateInformation_Form
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdo_Rating = new System.Windows.Forms.RadioButton();
            this.rdo_Reviews = new System.Windows.Forms.RadioButton();
            this.rdo_Users = new System.Windows.Forms.RadioButton();
            this.rdo_Movies = new System.Windows.Forms.RadioButton();
            this.LoadInformation_btn = new System.Windows.Forms.Button();
            this.dgv_Informations = new System.Windows.Forms.DataGridView();
            this.save_btn = new System.Windows.Forms.Button();
            this.Previous = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Informations)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdo_Rating);
            this.groupBox1.Controls.Add(this.rdo_Reviews);
            this.groupBox1.Controls.Add(this.rdo_Users);
            this.groupBox1.Controls.Add(this.rdo_Movies);
            this.groupBox1.Location = new System.Drawing.Point(416, 21);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(238, 121);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // rdo_Rating
            // 
            this.rdo_Rating.AutoSize = true;
            this.rdo_Rating.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.rdo_Rating.Location = new System.Drawing.Point(19, 96);
            this.rdo_Rating.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdo_Rating.Name = "rdo_Rating";
            this.rdo_Rating.Size = new System.Drawing.Size(129, 19);
            this.rdo_Rating.TabIndex = 3;
            this.rdo_Rating.TabStop = true;
            this.rdo_Rating.Text = "Rating Information";
            this.rdo_Rating.UseVisualStyleBackColor = true;
            // 
            // rdo_Reviews
            // 
            this.rdo_Reviews.AutoSize = true;
            this.rdo_Reviews.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.rdo_Reviews.Location = new System.Drawing.Point(19, 73);
            this.rdo_Reviews.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdo_Reviews.Name = "rdo_Reviews";
            this.rdo_Reviews.Size = new System.Drawing.Size(141, 19);
            this.rdo_Reviews.TabIndex = 2;
            this.rdo_Reviews.TabStop = true;
            this.rdo_Reviews.Text = "Reviews Information";
            this.rdo_Reviews.UseVisualStyleBackColor = true;
            // 
            // rdo_Users
            // 
            this.rdo_Users.AutoSize = true;
            this.rdo_Users.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_Users.Location = new System.Drawing.Point(19, 50);
            this.rdo_Users.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdo_Users.Name = "rdo_Users";
            this.rdo_Users.Size = new System.Drawing.Size(127, 19);
            this.rdo_Users.TabIndex = 1;
            this.rdo_Users.TabStop = true;
            this.rdo_Users.Text = "Users Information";
            this.rdo_Users.UseVisualStyleBackColor = true;
            // 
            // rdo_Movies
            // 
            this.rdo_Movies.AutoSize = true;
            this.rdo_Movies.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_Movies.Location = new System.Drawing.Point(19, 28);
            this.rdo_Movies.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdo_Movies.Name = "rdo_Movies";
            this.rdo_Movies.Size = new System.Drawing.Size(133, 19);
            this.rdo_Movies.TabIndex = 0;
            this.rdo_Movies.TabStop = true;
            this.rdo_Movies.Text = "Movies Information";
            this.rdo_Movies.UseVisualStyleBackColor = true;
            // 
            // LoadInformation_btn
            // 
            this.LoadInformation_btn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadInformation_btn.Location = new System.Drawing.Point(447, 156);
            this.LoadInformation_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LoadInformation_btn.Name = "LoadInformation_btn";
            this.LoadInformation_btn.Size = new System.Drawing.Size(174, 24);
            this.LoadInformation_btn.TabIndex = 1;
            this.LoadInformation_btn.Text = "Load Information";
            this.LoadInformation_btn.UseVisualStyleBackColor = true;
            this.LoadInformation_btn.Click += new System.EventHandler(this.LoadInformation_btn_Click);
            // 
            // dgv_Informations
            // 
            this.dgv_Informations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Informations.Location = new System.Drawing.Point(155, 184);
            this.dgv_Informations.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Informations.Name = "dgv_Informations";
            this.dgv_Informations.RowHeadersWidth = 51;
            this.dgv_Informations.RowTemplate.Height = 26;
            this.dgv_Informations.Size = new System.Drawing.Size(764, 375);
            this.dgv_Informations.TabIndex = 2;
            // 
            // save_btn
            // 
            this.save_btn.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_btn.Location = new System.Drawing.Point(573, 569);
            this.save_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(106, 28);
            this.save_btn.TabIndex = 3;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // Previous
            // 
            this.Previous.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.Previous.Location = new System.Drawing.Point(952, 539);
            this.Previous.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Previous.Name = "Previous";
            this.Previous.Size = new System.Drawing.Size(102, 28);
            this.Previous.TabIndex = 4;
            this.Previous.Text = "Previous";
            this.Previous.UseVisualStyleBackColor = true;
            this.Previous.Click += new System.EventHandler(this.Previous_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.Location = new System.Drawing.Point(416, 569);
            this.delete_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(106, 28);
            this.delete_btn.TabIndex = 6;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.exit_btn.Location = new System.Drawing.Point(952, 572);
            this.exit_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(102, 28);
            this.exit_btn.TabIndex = 7;
            this.exit_btn.Text = "Exit";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // UpdateInformation_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 607);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.Previous);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.dgv_Informations);
            this.Controls.Add(this.LoadInformation_btn);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UpdateInformation_Form";
            this.Text = " ";
            this.Load += new System.EventHandler(this.UpdateInformation_Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Informations)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdo_Rating;
        private System.Windows.Forms.RadioButton rdo_Reviews;
        private System.Windows.Forms.RadioButton rdo_Users;
        private System.Windows.Forms.RadioButton rdo_Movies;
        private System.Windows.Forms.Button LoadInformation_btn;
        private System.Windows.Forms.DataGridView dgv_Informations;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button Previous;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button exit_btn;
    }
}