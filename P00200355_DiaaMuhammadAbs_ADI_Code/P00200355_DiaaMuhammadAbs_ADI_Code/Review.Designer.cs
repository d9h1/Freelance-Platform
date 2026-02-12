namespace P00200355_DiaaMuhammadAbs_ADI_Code
{
    partial class Review
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
            this.Name_textBox = new System.Windows.Forms.TextBox();
            this.Name_label = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Evaluation_label = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Comments_label = new System.Windows.Forms.Label();
            this.Submit_button = new System.Windows.Forms.Button();
            this.Back_button = new System.Windows.Forms.Button();
            this.ViewFreelancer_button = new System.Windows.Forms.Button();
            this.PostProject_button = new System.Windows.Forms.Button();
            this.ViewBid_button = new System.Windows.Forms.Button();
            this.Logout_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Name_textBox
            // 
            this.Name_textBox.Location = new System.Drawing.Point(234, 98);
            this.Name_textBox.Name = "Name_textBox";
            this.Name_textBox.Size = new System.Drawing.Size(296, 24);
            this.Name_textBox.TabIndex = 0;
            this.Name_textBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Name_label
            // 
            this.Name_label.AutoSize = true;
            this.Name_label.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.Name_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(111)))), ((int)(((byte)(9)))));
            this.Name_label.Location = new System.Drawing.Point(53, 103);
            this.Name_label.Name = "Name_label";
            this.Name_label.Size = new System.Drawing.Size(147, 22);
            this.Name_label.TabIndex = 1;
            this.Name_label.Text = "Freelancer name:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1-Bad",
            "2-Satisfactory",
            "3-Good",
            "4-Very Good",
            "5-Outstanding"});
            this.comboBox1.Location = new System.Drawing.Point(234, 160);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Evaluation_label
            // 
            this.Evaluation_label.AutoSize = true;
            this.Evaluation_label.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.Evaluation_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(111)))), ((int)(((byte)(9)))));
            this.Evaluation_label.Location = new System.Drawing.Point(55, 162);
            this.Evaluation_label.Name = "Evaluation_label";
            this.Evaluation_label.Size = new System.Drawing.Size(101, 22);
            this.Evaluation_label.TabIndex = 3;
            this.Evaluation_label.Text = "Evaluation:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(234, 211);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(303, 85);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Comments_label
            // 
            this.Comments_label.AutoSize = true;
            this.Comments_label.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.Comments_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(111)))), ((int)(((byte)(9)))));
            this.Comments_label.Location = new System.Drawing.Point(58, 210);
            this.Comments_label.Name = "Comments_label";
            this.Comments_label.Size = new System.Drawing.Size(98, 22);
            this.Comments_label.TabIndex = 5;
            this.Comments_label.Text = "Comments:";
            // 
            // Submit_button
            // 
            this.Submit_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(178)))));
            this.Submit_button.FlatAppearance.BorderSize = 0;
            this.Submit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Submit_button.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.Submit_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(111)))), ((int)(((byte)(9)))));
            this.Submit_button.Location = new System.Drawing.Point(389, 335);
            this.Submit_button.Name = "Submit_button";
            this.Submit_button.Size = new System.Drawing.Size(148, 29);
            this.Submit_button.TabIndex = 6;
            this.Submit_button.Text = "Submit";
            this.Submit_button.UseVisualStyleBackColor = false;
            this.Submit_button.Click += new System.EventHandler(this.Submit_button_Click);
            // 
            // Back_button
            // 
            this.Back_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(178)))));
            this.Back_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Back_button.FlatAppearance.BorderSize = 0;
            this.Back_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back_button.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.Back_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(111)))), ((int)(((byte)(9)))));
            this.Back_button.Location = new System.Drawing.Point(592, 315);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(174, 37);
            this.Back_button.TabIndex = 7;
            this.Back_button.Text = "Back to client page";
            this.Back_button.UseVisualStyleBackColor = false;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // ViewFreelancer_button
            // 
            this.ViewFreelancer_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(178)))));
            this.ViewFreelancer_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ViewFreelancer_button.FlatAppearance.BorderSize = 0;
            this.ViewFreelancer_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewFreelancer_button.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.ViewFreelancer_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(111)))), ((int)(((byte)(9)))));
            this.ViewFreelancer_button.Location = new System.Drawing.Point(592, 263);
            this.ViewFreelancer_button.Name = "ViewFreelancer_button";
            this.ViewFreelancer_button.Size = new System.Drawing.Size(174, 37);
            this.ViewFreelancer_button.TabIndex = 19;
            this.ViewFreelancer_button.Text = "View Freelancer";
            this.ViewFreelancer_button.UseVisualStyleBackColor = false;
            this.ViewFreelancer_button.Click += new System.EventHandler(this.ViewFreelancer_button_Click);
            // 
            // PostProject_button
            // 
            this.PostProject_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(178)))));
            this.PostProject_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PostProject_button.FlatAppearance.BorderSize = 0;
            this.PostProject_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PostProject_button.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.PostProject_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(111)))), ((int)(((byte)(9)))));
            this.PostProject_button.Location = new System.Drawing.Point(592, 163);
            this.PostProject_button.Name = "PostProject_button";
            this.PostProject_button.Size = new System.Drawing.Size(174, 37);
            this.PostProject_button.TabIndex = 18;
            this.PostProject_button.Text = "Post Project";
            this.PostProject_button.UseVisualStyleBackColor = false;
            this.PostProject_button.Click += new System.EventHandler(this.PostProject_button_Click);
            // 
            // ViewBid_button
            // 
            this.ViewBid_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(178)))));
            this.ViewBid_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ViewBid_button.FlatAppearance.BorderSize = 0;
            this.ViewBid_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewBid_button.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.ViewBid_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(111)))), ((int)(((byte)(9)))));
            this.ViewBid_button.Location = new System.Drawing.Point(592, 211);
            this.ViewBid_button.Name = "ViewBid_button";
            this.ViewBid_button.Size = new System.Drawing.Size(174, 37);
            this.ViewBid_button.TabIndex = 17;
            this.ViewBid_button.Text = "View Bid";
            this.ViewBid_button.UseVisualStyleBackColor = false;
            this.ViewBid_button.Click += new System.EventHandler(this.ViewBid_button_Click);
            // 
            // Logout_button
            // 
            this.Logout_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(178)))));
            this.Logout_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Logout_button.FlatAppearance.BorderSize = 0;
            this.Logout_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logout_button.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.Logout_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(111)))), ((int)(((byte)(9)))));
            this.Logout_button.Location = new System.Drawing.Point(629, 371);
            this.Logout_button.Name = "Logout_button";
            this.Logout_button.Size = new System.Drawing.Size(88, 40);
            this.Logout_button.TabIndex = 15;
            this.Logout_button.Text = "Logout";
            this.Logout_button.UseVisualStyleBackColor = false;
            this.Logout_button.Click += new System.EventHandler(this.Logout_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::P00200355_DiaaMuhammadAbs_ADI_Code.Properties.Resources.P2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(662, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 113);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Simplified Arabic Fixed", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(111)))), ((int)(((byte)(9)))));
            this.label3.Location = new System.Drawing.Point(52, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(269, 39);
            this.label3.TabIndex = 25;
            this.label3.Text = "Leave review";
            // 
            // Review
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ViewFreelancer_button);
            this.Controls.Add(this.PostProject_button);
            this.Controls.Add(this.ViewBid_button);
            this.Controls.Add(this.Logout_button);
            this.Controls.Add(this.Back_button);
            this.Controls.Add(this.Submit_button);
            this.Controls.Add(this.Comments_label);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Evaluation_label);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Name_label);
            this.Controls.Add(this.Name_textBox);
            this.Location = new System.Drawing.Point(126, 113);
            this.Name = "Review";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Review";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Name_textBox;
        private System.Windows.Forms.Label Name_label;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label Evaluation_label;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label Comments_label;
        private System.Windows.Forms.Button Submit_button;
        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.Button ViewFreelancer_button;
        private System.Windows.Forms.Button PostProject_button;
        private System.Windows.Forms.Button ViewBid_button;
        private System.Windows.Forms.Button Logout_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
    }
}