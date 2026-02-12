using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P00200355_DiaaMuhammadAbs_ADI_Code
{
    public partial class ViewFreelancer : Form
    {
        public ViewFreelancer()
        {
            InitializeComponent();
        }
        // Event handler for the logout button
        private void Logout_button_Click(object sender, EventArgs e)
        {
            Main_Page main_Page = new Main_Page();
            this.Hide();
            MessageBox.Show("Logout Succeeded.");
            main_Page.Show();
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            //to go back to the client page
            ClientDashboard clientdashboard = new ClientDashboard();
            clientdashboard.Show();
            //to hide the view freelancer page
            this.Hide();
        }

        private void ViewFreelancer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aDI_Project_DiaaDataSet.Freelancer' table. You can move, or remove it, as needed.
            this.freelancerTableAdapter.Fill(this.aDI_Project_DiaaDataSet.Freelancer);
            // Create a DataView for the Freelancer table
            DataView freelancerView = new DataView(this.aDI_Project_DiaaDataSet.Freelancer);
            // Set the DataGridView's data source to the DataView
            viewFreelancer_dataGridView.DataSource = freelancerView;

        }

        private void Search_textBox_TextChanged(object sender, EventArgs e)
        {
            string searchText = Search_textBox.Text.Trim();
            DataView view = viewFreelancer_dataGridView.DataSource as DataView;

            if (view != null)
            {
                if (searchText.Length > 0)
                {
                    // Apply the filter to the DataView
                    view.RowFilter = $"Skills LIKE '%{searchText}%'";
                }
                else
                {
                    // Clear the filter to show all rows
                    view.RowFilter = "";
                }
            }
        }
    }
}
