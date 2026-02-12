using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace P00200355_DiaaMuhammadAbs_ADI_Code
{
    public partial class ViewProject : Form
    {
        public ViewProject()
        {
            InitializeComponent();
        }
        // Event handler for the logout button
        private void Logout_button_Click_1(object sender, EventArgs e)
        {
            Main_Page main_Page = new Main_Page();
            this.Hide();
            MessageBox.Show("Logout Succeeded.");
            main_Page.Show();
        }

        private void ViewProject_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aDI_Project_DiaaDataSet2.Project' table. You can move, or remove it, as needed.
            this.projectTableAdapter2.Fill(this.aDI_Project_DiaaDataSet2.Project);
        }

        private void ProjectType_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected project type
            string selectedProjectType = ProjectType_comboBox.SelectedItem.ToString();

            // Filter data based on the selected project type
            DataView dataView = new DataView(this.aDI_Project_DiaaDataSet2.Project);
            dataView.RowFilter = $"Project_type = '{selectedProjectType}'";

            // Display the filtered data in the DataGridView
            viewproject_dataGridView.DataSource = dataView;
        }
    }
}
