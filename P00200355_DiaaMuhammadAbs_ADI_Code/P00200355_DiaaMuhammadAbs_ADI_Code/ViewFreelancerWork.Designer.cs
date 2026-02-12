namespace P00200355_DiaaMuhammadAbs_ADI_Code
{
    partial class ViewFreelancerWork
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this._dataGridView = new System.Windows.Forms.DataGridView();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.submissionDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workingconditionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.freelancerAcceptedBidsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aDI_Project_DiaaDataSet = new P00200355_DiaaMuhammadAbs_ADI_Code.ADI_Project_DiaaDataSet();
            this.freelancer_Accepted_BidsTableAdapter = new P00200355_DiaaMuhammadAbs_ADI_Code.ADI_Project_DiaaDataSetTableAdapters.Freelancer_Accepted_BidsTableAdapter();
            this.search_button = new System.Windows.Forms.Button();
            this.Search_textBox = new System.Windows.Forms.TextBox();
            this.search_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Add_button = new System.Windows.Forms.Button();
            this.Working_condition_comboBox = new System.Windows.Forms.ComboBox();
            this.Back_button = new System.Windows.Forms.Button();
            this.Logout_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.freelancerAcceptedBidsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDI_Project_DiaaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // _dataGridView
            // 
            this._dataGridView.AllowUserToAddRows = false;
            this._dataGridView.AllowUserToDeleteRows = false;
            this._dataGridView.AutoGenerateColumns = false;
            this._dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this._dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usernameDataGridViewTextBoxColumn,
            this.projectNameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.submissionDateDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.workingconditionDataGridViewTextBoxColumn});
            this._dataGridView.DataSource = this.freelancerAcceptedBidsBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(111)))), ((int)(((byte)(9)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(233)))), ((int)(((byte)(127)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._dataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this._dataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(0)))));
            this._dataGridView.Location = new System.Drawing.Point(1, 0);
            this._dataGridView.Name = "_dataGridView";
            this._dataGridView.ReadOnly = true;
            this._dataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(204)))));
            this._dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this._dataGridView.RowTemplate.Height = 26;
            this._dataGridView.Size = new System.Drawing.Size(796, 319);
            this._dataGridView.TabIndex = 12;
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
            // projectNameDataGridViewTextBoxColumn
            // 
            this.projectNameDataGridViewTextBoxColumn.DataPropertyName = "Project_Name";
            this.projectNameDataGridViewTextBoxColumn.HeaderText = "Project_Name";
            this.projectNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.projectNameDataGridViewTextBoxColumn.Name = "projectNameDataGridViewTextBoxColumn";
            this.projectNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.projectNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // submissionDateDataGridViewTextBoxColumn
            // 
            this.submissionDateDataGridViewTextBoxColumn.DataPropertyName = "Submission_Date";
            this.submissionDateDataGridViewTextBoxColumn.HeaderText = "Submission_Date";
            this.submissionDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.submissionDateDataGridViewTextBoxColumn.Name = "submissionDateDataGridViewTextBoxColumn";
            this.submissionDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.submissionDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // workingconditionDataGridViewTextBoxColumn
            // 
            this.workingconditionDataGridViewTextBoxColumn.DataPropertyName = "Working_condition";
            this.workingconditionDataGridViewTextBoxColumn.HeaderText = "Working_condition";
            this.workingconditionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.workingconditionDataGridViewTextBoxColumn.Name = "workingconditionDataGridViewTextBoxColumn";
            this.workingconditionDataGridViewTextBoxColumn.ReadOnly = true;
            this.workingconditionDataGridViewTextBoxColumn.Width = 125;
            // 
            // freelancerAcceptedBidsBindingSource
            // 
            this.freelancerAcceptedBidsBindingSource.DataMember = "Freelancer_Accepted_Bids";
            this.freelancerAcceptedBidsBindingSource.DataSource = this.aDI_Project_DiaaDataSet;
            // 
            // aDI_Project_DiaaDataSet
            // 
            this.aDI_Project_DiaaDataSet.DataSetName = "ADI_Project_DiaaDataSet";
            this.aDI_Project_DiaaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // freelancer_Accepted_BidsTableAdapter
            // 
            this.freelancer_Accepted_BidsTableAdapter.ClearBeforeFill = true;
            // 
            // search_button
            // 
            this.search_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(178)))));
            this.search_button.FlatAppearance.BorderSize = 0;
            this.search_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_button.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.search_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(111)))), ((int)(((byte)(9)))));
            this.search_button.Location = new System.Drawing.Point(415, 350);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(88, 26);
            this.search_button.TabIndex = 22;
            this.search_button.Text = "Search";
            this.search_button.UseVisualStyleBackColor = false;
            this.search_button.Click += new System.EventHandler(this.search_button_Click_1);
            // 
            // Search_textBox
            // 
            this.Search_textBox.Location = new System.Drawing.Point(254, 350);
            this.Search_textBox.Name = "Search_textBox";
            this.Search_textBox.Size = new System.Drawing.Size(145, 24);
            this.Search_textBox.TabIndex = 21;
            // 
            // search_label
            // 
            this.search_label.AutoSize = true;
            this.search_label.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.search_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(111)))), ((int)(((byte)(9)))));
            this.search_label.Location = new System.Drawing.Point(31, 354);
            this.search_label.Name = "search_label";
            this.search_label.Size = new System.Drawing.Size(217, 22);
            this.search_label.TabIndex = 20;
            this.search_label.Text = "Search for your username:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(111)))), ((int)(((byte)(9)))));
            this.label1.Location = new System.Drawing.Point(31, 389);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 22);
            this.label1.TabIndex = 25;
            this.label1.Text = "Project status:";
            // 
            // Add_button
            // 
            this.Add_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(178)))));
            this.Add_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Add_button.FlatAppearance.BorderSize = 0;
            this.Add_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_button.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(111)))), ((int)(((byte)(9)))));
            this.Add_button.Location = new System.Drawing.Point(296, 389);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(77, 24);
            this.Add_button.TabIndex = 24;
            this.Add_button.Text = "Add";
            this.Add_button.UseVisualStyleBackColor = false;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // Working_condition_comboBox
            // 
            this.Working_condition_comboBox.FormattingEnabled = true;
            this.Working_condition_comboBox.Items.AddRange(new object[] {
            "Completed",
            "Ongoing"});
            this.Working_condition_comboBox.Location = new System.Drawing.Point(159, 387);
            this.Working_condition_comboBox.Name = "Working_condition_comboBox";
            this.Working_condition_comboBox.Size = new System.Drawing.Size(121, 24);
            this.Working_condition_comboBox.TabIndex = 23;
            // 
            // Back_button
            // 
            this.Back_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(178)))));
            this.Back_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Back_button.FlatAppearance.BorderSize = 0;
            this.Back_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back_button.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.Back_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(111)))), ((int)(((byte)(9)))));
            this.Back_button.Location = new System.Drawing.Point(604, 354);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(175, 32);
            this.Back_button.TabIndex = 26;
            this.Back_button.Text = "Back to client page";
            this.Back_button.UseVisualStyleBackColor = false;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // Logout_button
            // 
            this.Logout_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(178)))));
            this.Logout_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Logout_button.FlatAppearance.BorderSize = 0;
            this.Logout_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logout_button.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.Logout_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(111)))), ((int)(((byte)(9)))));
            this.Logout_button.Location = new System.Drawing.Point(645, 392);
            this.Logout_button.Name = "Logout_button";
            this.Logout_button.Size = new System.Drawing.Size(89, 32);
            this.Logout_button.TabIndex = 27;
            this.Logout_button.Text = "Logout";
            this.Logout_button.UseVisualStyleBackColor = false;
            this.Logout_button.Click += new System.EventHandler(this.Logout_button_Click);
            // 
            // ViewFreelancerWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Logout_button);
            this.Controls.Add(this.Back_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.Working_condition_comboBox);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.Search_textBox);
            this.Controls.Add(this.search_label);
            this.Controls.Add(this._dataGridView);
            this.Name = "ViewFreelancerWork";
            this.Text = "FreelancerWork";
            this.Load += new System.EventHandler(this.FreelancerWork_Load);
            ((System.ComponentModel.ISupportInitialize)(this._dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.freelancerAcceptedBidsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDI_Project_DiaaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView _dataGridView;
        private ADI_Project_DiaaDataSet aDI_Project_DiaaDataSet;
        private ADI_Project_DiaaDataSetTableAdapters.Freelancer_Accepted_BidsTableAdapter freelancer_Accepted_BidsTableAdapter;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.TextBox Search_textBox;
        private System.Windows.Forms.Label search_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.ComboBox Working_condition_comboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn submissionDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workingconditionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource freelancerAcceptedBidsBindingSource;
        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.Button Logout_button;
    }
}