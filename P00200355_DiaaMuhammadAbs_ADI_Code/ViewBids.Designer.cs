namespace P00200355_DiaaMuhammadAbs_ADI_Code
{
    partial class ViewBids
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Logout_button = new System.Windows.Forms.Button();
            this.Back_button = new System.Windows.Forms.Button();
            this.viewBid_dataGridView = new System.Windows.Forms.DataGridView();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.submissionDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.biddingsystemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aDI_Project_DiaaDataSet = new P00200355_DiaaMuhammadAbs_ADI_Code.ADI_Project_DiaaDataSet();
            this.bidding_systemTableAdapter = new P00200355_DiaaMuhammadAbs_ADI_Code.ADI_Project_DiaaDataSetTableAdapters.Bidding_systemTableAdapter();
            this.Status_comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Add_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.viewBid_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.biddingsystemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDI_Project_DiaaDataSet)).BeginInit();
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
            this.Logout_button.Location = new System.Drawing.Point(613, 406);
            this.Logout_button.Name = "Logout_button";
            this.Logout_button.Size = new System.Drawing.Size(175, 32);
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
            this.Back_button.Location = new System.Drawing.Point(425, 406);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(175, 32);
            this.Back_button.TabIndex = 10;
            this.Back_button.Text = "Back to client page";
            this.Back_button.UseVisualStyleBackColor = false;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // viewBid_dataGridView
            // 
            this.viewBid_dataGridView.AllowUserToAddRows = false;
            this.viewBid_dataGridView.AllowUserToDeleteRows = false;
            this.viewBid_dataGridView.AutoGenerateColumns = false;
            this.viewBid_dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.viewBid_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.viewBid_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewBid_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usernameDataGridViewTextBoxColumn,
            this.projectNameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.submissionDateDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.viewBid_dataGridView.DataSource = this.biddingsystemBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(111)))), ((int)(((byte)(9)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(233)))), ((int)(((byte)(127)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.viewBid_dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.viewBid_dataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(0)))));
            this.viewBid_dataGridView.Location = new System.Drawing.Point(2, 51);
            this.viewBid_dataGridView.Name = "viewBid_dataGridView";
            this.viewBid_dataGridView.ReadOnly = true;
            this.viewBid_dataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(204)))));
            this.viewBid_dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.viewBid_dataGridView.RowTemplate.Height = 26;
            this.viewBid_dataGridView.Size = new System.Drawing.Size(796, 294);
            this.viewBid_dataGridView.TabIndex = 11;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            this.usernameDataGridViewTextBoxColumn.Width = 90;
            // 
            // projectNameDataGridViewTextBoxColumn
            // 
            this.projectNameDataGridViewTextBoxColumn.DataPropertyName = "Project_Name";
            this.projectNameDataGridViewTextBoxColumn.HeaderText = "Project_Name";
            this.projectNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.projectNameDataGridViewTextBoxColumn.Name = "projectNameDataGridViewTextBoxColumn";
            this.projectNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.projectNameDataGridViewTextBoxColumn.Width = 95;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Width = 150;
            // 
            // submissionDateDataGridViewTextBoxColumn
            // 
            this.submissionDateDataGridViewTextBoxColumn.DataPropertyName = "Submission_Date";
            this.submissionDateDataGridViewTextBoxColumn.HeaderText = "Submission_Date";
            this.submissionDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.submissionDateDataGridViewTextBoxColumn.Name = "submissionDateDataGridViewTextBoxColumn";
            this.submissionDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.submissionDateDataGridViewTextBoxColumn.Width = 165;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 50;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Width = 60;
            // 
            // biddingsystemBindingSource
            // 
            this.biddingsystemBindingSource.DataMember = "Bidding_system";
            this.biddingsystemBindingSource.DataSource = this.aDI_Project_DiaaDataSet;
            // 
            // aDI_Project_DiaaDataSet
            // 
            this.aDI_Project_DiaaDataSet.DataSetName = "ADI_Project_DiaaDataSet";
            this.aDI_Project_DiaaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bidding_systemTableAdapter
            // 
            this.bidding_systemTableAdapter.ClearBeforeFill = true;
            // 
            // Status_comboBox
            // 
            this.Status_comboBox.FormattingEnabled = true;
            this.Status_comboBox.Items.AddRange(new object[] {
            "Accept",
            "Reject"});
            this.Status_comboBox.Location = new System.Drawing.Point(170, 369);
            this.Status_comboBox.Name = "Status_comboBox";
            this.Status_comboBox.Size = new System.Drawing.Size(121, 24);
            this.Status_comboBox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(111)))), ((int)(((byte)(9)))));
            this.label1.Location = new System.Drawing.Point(12, 371);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 22);
            this.label1.TabIndex = 14;
            this.label1.Text = "Update bid status:";
            // 
            // Add_button
            // 
            this.Add_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(178)))));
            this.Add_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Add_button.FlatAppearance.BorderSize = 0;
            this.Add_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_button.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(111)))), ((int)(((byte)(9)))));
            this.Add_button.Location = new System.Drawing.Point(297, 369);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(77, 24);
            this.Add_button.TabIndex = 13;
            this.Add_button.Text = "Add";
            this.Add_button.UseVisualStyleBackColor = false;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Simplified Arabic Fixed", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(111)))), ((int)(((byte)(9)))));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(332, 39);
            this.label3.TabIndex = 29;
            this.label3.Text = "Freelancer bids";
            // 
            // ViewBids
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.Status_comboBox);
            this.Controls.Add(this.viewBid_dataGridView);
            this.Controls.Add(this.Back_button);
            this.Controls.Add(this.Logout_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewBids";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Freelancer bids";
            this.Load += new System.EventHandler(this.ViewBids_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewBid_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.biddingsystemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDI_Project_DiaaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Logout_button;
        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.DataGridView viewBid_dataGridView;
        private ADI_Project_DiaaDataSet aDI_Project_DiaaDataSet;
        private ADI_Project_DiaaDataSetTableAdapters.Bidding_systemTableAdapter bidding_systemTableAdapter;
        private System.Windows.Forms.ComboBox Status_comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.BindingSource biddingsystemBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn submissionDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
    }
}