namespace P00200355_DiaaMuhammadAbs_ADI_Code
{
    partial class ViewProject
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
            this.Logout_button = new System.Windows.Forms.Button();
            this.viewproject_dataGridView = new System.Windows.Forms.DataGridView();
            this.projectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aDI_Project_DiaaDataSet2 = new P00200355_DiaaMuhammadAbs_ADI_Code.ADI_Project_DiaaDataSet();
            this.projectTableAdapter2 = new P00200355_DiaaMuhammadAbs_ADI_Code.ADI_Project_DiaaDataSetTableAdapters.ProjectTableAdapter();
            this.ProjectType_comboBox = new System.Windows.Forms.ComboBox();
            this.search_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workingconditionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projecttypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.viewproject_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDI_Project_DiaaDataSet2)).BeginInit();
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
            this.Logout_button.Location = new System.Drawing.Point(602, 406);
            this.Logout_button.Name = "Logout_button";
            this.Logout_button.Size = new System.Drawing.Size(175, 32);
            this.Logout_button.TabIndex = 9;
            this.Logout_button.Text = "Logout";
            this.Logout_button.UseVisualStyleBackColor = false;
            this.Logout_button.Click += new System.EventHandler(this.Logout_button_Click_1);
            // 
            // viewproject_dataGridView
            // 
            this.viewproject_dataGridView.AllowUserToAddRows = false;
            this.viewproject_dataGridView.AllowUserToDeleteRows = false;
            this.viewproject_dataGridView.AutoGenerateColumns = false;
            this.viewproject_dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(229)))));
            this.viewproject_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewproject_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.workingconditionDataGridViewTextBoxColumn,
            this.projecttypeDataGridViewTextBoxColumn});
            this.viewproject_dataGridView.DataSource = this.projectBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(111)))), ((int)(((byte)(9)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(233)))), ((int)(((byte)(127)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.viewproject_dataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.viewproject_dataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(0)))));
            this.viewproject_dataGridView.Location = new System.Drawing.Point(2, 51);
            this.viewproject_dataGridView.Name = "viewproject_dataGridView";
            this.viewproject_dataGridView.ReadOnly = true;
            this.viewproject_dataGridView.RowHeadersWidth = 51;
            this.viewproject_dataGridView.RowTemplate.Height = 26;
            this.viewproject_dataGridView.Size = new System.Drawing.Size(796, 305);
            this.viewproject_dataGridView.TabIndex = 13;
            // 
            // projectBindingSource
            // 
            this.projectBindingSource.DataMember = "Project";
            this.projectBindingSource.DataSource = this.aDI_Project_DiaaDataSet2;
            // 
            // aDI_Project_DiaaDataSet2
            // 
            this.aDI_Project_DiaaDataSet2.DataSetName = "ADI_Project_DiaaDataSet";
            this.aDI_Project_DiaaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projectTableAdapter2
            // 
            this.projectTableAdapter2.ClearBeforeFill = true;
            // 
            // ProjectType_comboBox
            // 
            this.ProjectType_comboBox.FormattingEnabled = true;
            this.ProjectType_comboBox.Items.AddRange(new object[] {
            "Programming and development",
            "Design",
            "Writing and translation",
            "Digital marketing",
            "Others"});
            this.ProjectType_comboBox.Location = new System.Drawing.Point(262, 373);
            this.ProjectType_comboBox.Name = "ProjectType_comboBox";
            this.ProjectType_comboBox.Size = new System.Drawing.Size(170, 24);
            this.ProjectType_comboBox.TabIndex = 30;
            this.ProjectType_comboBox.SelectedIndexChanged += new System.EventHandler(this.ProjectType_comboBox_SelectedIndexChanged);
            // 
            // search_label
            // 
            this.search_label.AutoSize = true;
            this.search_label.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.search_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(111)))), ((int)(((byte)(9)))));
            this.search_label.Location = new System.Drawing.Point(12, 375);
            this.search_label.Name = "search_label";
            this.search_label.Size = new System.Drawing.Size(244, 22);
            this.search_label.TabIndex = 31;
            this.search_label.Text = "Search based on project type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Simplified Arabic Fixed", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(111)))), ((int)(((byte)(9)))));
            this.label3.Location = new System.Drawing.Point(23, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 39);
            this.label3.TabIndex = 32;
            this.label3.Text = "Project";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Client_Name";
            this.dataGridViewTextBoxColumn6.HeaderText = "Client_Name";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 90;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Project_Name";
            this.dataGridViewTextBoxColumn7.HeaderText = "Project_Name";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 90;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn8.HeaderText = "Description";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 150;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Timeline";
            this.dataGridViewTextBoxColumn9.HeaderText = "Timeline";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 165;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "budget";
            this.dataGridViewTextBoxColumn10.HeaderText = "budget";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 55;
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
            // projecttypeDataGridViewTextBoxColumn
            // 
            this.projecttypeDataGridViewTextBoxColumn.DataPropertyName = "Project_type";
            this.projecttypeDataGridViewTextBoxColumn.HeaderText = "Project_type";
            this.projecttypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.projecttypeDataGridViewTextBoxColumn.Name = "projecttypeDataGridViewTextBoxColumn";
            this.projecttypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.projecttypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // ViewProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.search_label);
            this.Controls.Add(this.ProjectType_comboBox);
            this.Controls.Add(this.viewproject_dataGridView);
            this.Controls.Add(this.Logout_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewProject";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project";
            this.Load += new System.EventHandler(this.ViewProject_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.viewproject_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDI_Project_DiaaDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Logout_button;
        private ADI_Project_DiaaDataSet aDI_Project_DiaaDataSet;
        private ADI_Project_DiaaDataSetTableAdapters.ProjectTableAdapter projectTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timelineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn budgetDataGridViewTextBoxColumn;
        private ADI_Project_DiaaDataSet aDI_Project_DiaaDataSet1;
        private ADI_Project_DiaaDataSetTableAdapters.ProjectTableAdapter projectTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridView viewproject_dataGridView;
        private ADI_Project_DiaaDataSet aDI_Project_DiaaDataSet2;
        private ADI_Project_DiaaDataSetTableAdapters.ProjectTableAdapter projectTableAdapter2;
        private System.Windows.Forms.BindingSource projectBindingSource;
        private System.Windows.Forms.ComboBox ProjectType_comboBox;
        private System.Windows.Forms.Label search_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn workingconditionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projecttypeDataGridViewTextBoxColumn;
    }
}