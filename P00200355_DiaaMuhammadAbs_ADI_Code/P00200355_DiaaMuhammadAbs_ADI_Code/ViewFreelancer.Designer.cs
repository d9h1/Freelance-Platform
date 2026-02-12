namespace P00200355_DiaaMuhammadAbs_ADI_Code
{
    partial class ViewFreelancer
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
            this.components = new System.ComponentModel.Container();
            this.Logout_button = new System.Windows.Forms.Button();
            this.Back_button = new System.Windows.Forms.Button();
            this.viewFreelancer_dataGridView = new System.Windows.Forms.DataGridView();
            this.Search_textBox = new System.Windows.Forms.TextBox();
            this.search_label = new System.Windows.Forms.Label();
            this.aDI_Project_DiaaDataSet = new P00200355_DiaaMuhammadAbs_ADI_Code.ADI_Project_DiaaDataSet();
            this.freelancerTableAdapter = new P00200355_DiaaMuhammadAbs_ADI_Code.ADI_Project_DiaaDataSetTableAdapters.FreelancerTableAdapter();
            this.freelancerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skillsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.portfolioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expertiseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.viewFreelancer_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDI_Project_DiaaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.freelancerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Logout_button
            // 
            this.Logout_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(178)))));
            this.Logout_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Logout_button.FlatAppearance.BorderSize = 0;
            this.Logout_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logout_button.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.Logout_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(111)))), ((int)(((byte)(9)))));
            this.Logout_button.Location = new System.Drawing.Point(448, 410);
            this.Logout_button.Name = "Logout_button";
            this.Logout_button.Size = new System.Drawing.Size(120, 28);
            this.Logout_button.TabIndex = 9;
            this.Logout_button.Text = "Logout";
            this.Logout_button.UseVisualStyleBackColor = false;
            this.Logout_button.Click += new System.EventHandler(this.Logout_button_Click);
            // 
            // Back_button
            // 
            this.Back_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(178)))));
            this.Back_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Back_button.FlatAppearance.BorderSize = 0;
            this.Back_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back_button.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.Back_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(111)))), ((int)(((byte)(9)))));
            this.Back_button.Location = new System.Drawing.Point(220, 410);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(169, 28);
            this.Back_button.TabIndex = 10;
            this.Back_button.Text = "Back to the client page";
            this.Back_button.UseVisualStyleBackColor = false;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // viewFreelancer_dataGridView
            // 
            this.viewFreelancer_dataGridView.AllowUserToAddRows = false;
            this.viewFreelancer_dataGridView.AllowUserToDeleteRows = false;
            this.viewFreelancer_dataGridView.AutoGenerateColumns = false;
            this.viewFreelancer_dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(229)))));
            this.viewFreelancer_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewFreelancer_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usernameDataGridViewTextBoxColumn,
            this.skillsDataGridViewTextBoxColumn,
            this.portfolioDataGridViewTextBoxColumn,
            this.expertiseDataGridViewTextBoxColumn});
            this.viewFreelancer_dataGridView.DataSource = this.freelancerBindingSource;
            this.viewFreelancer_dataGridView.Location = new System.Drawing.Point(3, 48);
            this.viewFreelancer_dataGridView.Name = "viewFreelancer_dataGridView";
            this.viewFreelancer_dataGridView.ReadOnly = true;
            this.viewFreelancer_dataGridView.RowHeadersWidth = 51;
            this.viewFreelancer_dataGridView.RowTemplate.Height = 26;
            this.viewFreelancer_dataGridView.Size = new System.Drawing.Size(796, 344);
            this.viewFreelancer_dataGridView.TabIndex = 12;
            // 
            // Search_textBox
            // 
            this.Search_textBox.Location = new System.Drawing.Point(299, 12);
            this.Search_textBox.Name = "Search_textBox";
            this.Search_textBox.Size = new System.Drawing.Size(145, 24);
            this.Search_textBox.TabIndex = 18;
            this.Search_textBox.TextChanged += new System.EventHandler(this.Search_textBox_TextChanged);
            // 
            // search_label
            // 
            this.search_label.AutoSize = true;
            this.search_label.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.search_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(111)))), ((int)(((byte)(9)))));
            this.search_label.Location = new System.Drawing.Point(116, 16);
            this.search_label.Name = "search_label";
            this.search_label.Size = new System.Drawing.Size(146, 22);
            this.search_label.TabIndex = 17;
            this.search_label.Text = "Search for skills:";
            // 
            // aDI_Project_DiaaDataSet
            // 
            this.aDI_Project_DiaaDataSet.DataSetName = "ADI_Project_DiaaDataSet";
            this.aDI_Project_DiaaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // freelancerTableAdapter
            // 
            this.freelancerTableAdapter.ClearBeforeFill = true;
            // 
            // freelancerBindingSource
            // 
            this.freelancerBindingSource.DataMember = "Freelancer";
            this.freelancerBindingSource.DataSource = this.aDI_Project_DiaaDataSet;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            this.usernameDataGridViewTextBoxColumn.Width = 125;
            // 
            // skillsDataGridViewTextBoxColumn
            // 
            this.skillsDataGridViewTextBoxColumn.DataPropertyName = "Skills";
            this.skillsDataGridViewTextBoxColumn.HeaderText = "Skills";
            this.skillsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.skillsDataGridViewTextBoxColumn.Name = "skillsDataGridViewTextBoxColumn";
            this.skillsDataGridViewTextBoxColumn.ReadOnly = true;
            this.skillsDataGridViewTextBoxColumn.Width = 125;
            // 
            // portfolioDataGridViewTextBoxColumn
            // 
            this.portfolioDataGridViewTextBoxColumn.DataPropertyName = "Portfolio";
            this.portfolioDataGridViewTextBoxColumn.HeaderText = "Portfolio";
            this.portfolioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.portfolioDataGridViewTextBoxColumn.Name = "portfolioDataGridViewTextBoxColumn";
            this.portfolioDataGridViewTextBoxColumn.ReadOnly = true;
            this.portfolioDataGridViewTextBoxColumn.Width = 125;
            // 
            // expertiseDataGridViewTextBoxColumn
            // 
            this.expertiseDataGridViewTextBoxColumn.DataPropertyName = "Expertise";
            this.expertiseDataGridViewTextBoxColumn.HeaderText = "Expertise";
            this.expertiseDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.expertiseDataGridViewTextBoxColumn.Name = "expertiseDataGridViewTextBoxColumn";
            this.expertiseDataGridViewTextBoxColumn.ReadOnly = true;
            this.expertiseDataGridViewTextBoxColumn.Width = 125;
            // 
            // ViewFreelancer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Search_textBox);
            this.Controls.Add(this.search_label);
            this.Controls.Add(this.viewFreelancer_dataGridView);
            this.Controls.Add(this.Back_button);
            this.Controls.Add(this.Logout_button);
            this.Name = "ViewFreelancer";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewFreelancer";
            this.Load += new System.EventHandler(this.ViewFreelancer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewFreelancer_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDI_Project_DiaaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.freelancerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Logout_button;
        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.DataGridView viewFreelancer_dataGridView;
        private ADI_Project_DiaaDataSet aDI_Project_DiaaDataSet;
        private ADI_Project_DiaaDataSetTableAdapters.FreelancerTableAdapter freelancerTableAdapter;
        private System.Windows.Forms.TextBox Search_textBox;
        private System.Windows.Forms.Label search_label;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn skillsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn portfolioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expertiseDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource freelancerBindingSource;
    }
}