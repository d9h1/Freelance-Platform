using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace P00200355_DiaaMuhammadAbs_ADI_Code
{
    public partial class ViewFreelancerWork : Form
    {
        private DataView dataView;

        public ViewFreelancerWork()
        {
            InitializeComponent();
        }

        // Event handler when the form loads
        private void FreelancerWork_Load(object sender, EventArgs e)
        {
            // Fill the Freelancer_Accepted_Bids table from the dataset
            this.freelancer_Accepted_BidsTableAdapter.Fill(this.aDI_Project_DiaaDataSet.Freelancer_Accepted_Bids);

            // Initialize DataView with the Freelancer_Accepted_Bids table
            dataView = new DataView(this.aDI_Project_DiaaDataSet.Freelancer_Accepted_Bids);

            // Set the DataGridView's DataSource to the DataView
            _dataGridView.DataSource = dataView;
            _dataGridView.Visible = false; // Initially, hide the DataGridView
        }

        // Event handler when the search button is clicked
        private void search_button_Click_1(object sender, EventArgs e)
        {
            // Get the search keyword from the TextBox
            string searchKeyword = Search_textBox.Text;

            Console.WriteLine("Search Keyword: " + searchKeyword);

            if (!string.IsNullOrEmpty(searchKeyword))
            {
                // Apply a row filter to the DataView based on the search keyword
                dataView.RowFilter = $"Username LIKE '%{searchKeyword}%'";
                Console.WriteLine("Filtered Rows Count: " + _dataGridView.Rows.Count);
                _dataGridView.Refresh();
                _dataGridView.Visible = true;

                if (_dataGridView.Rows.Count == 0)
                {
                    MessageBox.Show("No matching username found");
                }
            }
            else
            {
                // If the search keyword is empty, clear the row filter and hide the DataGridView
                dataView.RowFilter = "";
                _dataGridView.Visible = false;
            }
        }

        // Event handler when the add button is clicked
        private void Add_button_Click(object sender, EventArgs e)
        {
            // Check if a row is selected in the DataGridView
            if (_dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a bid to update the status.");
                return;
            }

            // Get the selected row index, working condition, and ID
            int selectedRowIndex = _dataGridView.SelectedRows[0].Index;
            string selectedWorking_condition = Working_condition_comboBox.SelectedItem.ToString();
            int selectedID = Convert.ToInt32(this.aDI_Project_DiaaDataSet.Freelancer_Accepted_Bids.Rows[selectedRowIndex]["ID"]);

            // SQL update queries for the Freelancer_Accepted_Bids and Project tables
            string freelancerUpdateQuery = "UPDATE Freelancer_Accepted_Bids SET Working_condition = @NewWorking_condition WHERE ID = @ID";
            string projectUpdateQuery = "UPDATE Project SET Working_condition = @NewWorking_condition WHERE Project_Name = @Project_Name";

            try
            {
                // Open a new OleDbConnection
                using (OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\hanen\OneDrive\Desktop\uni\uni level 5\level 5-1 semester\Finl Assignments\P00200355_DiaaMuhammadAbs_ADI\P00200355_DiaaMuhammadAbs_ADI_Code\ADI_Project_Diaa.accdb;Persist Security Info=True"))
                {
                    connection.Open();

                    // Update the Freelancer_Accepted_Bids table with the new working condition
                    using (OleDbCommand freelancerCommand = new OleDbCommand(freelancerUpdateQuery, connection))
                    {
                        freelancerCommand.Parameters.AddWithValue("@NewWorking_condition", selectedWorking_condition);
                        freelancerCommand.Parameters.AddWithValue("@ID", selectedID);
                        freelancerCommand.ExecuteNonQuery();
                    }

                    // Check if the working condition is "Ongoing" or "Completed" before transferring to the Project table
                    if (selectedWorking_condition == "Ongoing" || selectedWorking_condition == "Completed")
                    {
                        // Update the Project table with the new working condition
                        using (OleDbCommand projectCommand = new OleDbCommand(projectUpdateQuery, connection))
                        {
                            projectCommand.Parameters.AddWithValue("@NewWorking_condition", selectedWorking_condition);
                            projectCommand.Parameters.AddWithValue("@Project_Name", this.aDI_Project_DiaaDataSet.Freelancer_Accepted_Bids.Rows[selectedRowIndex]["Project_Name"]);
                            projectCommand.ExecuteNonQuery();
                        }
                    }

                    // Close the connection
                    connection.Close();
                }

                // Update the dataset with the new working condition
                this.aDI_Project_DiaaDataSet.Freelancer_Accepted_Bids[selectedRowIndex].Working_condition = selectedWorking_condition;
                this.freelancer_Accepted_BidsTableAdapter.Update(this.aDI_Project_DiaaDataSet.Freelancer_Accepted_Bids.Rows[selectedRowIndex]);
                _dataGridView.Refresh();
                MessageBox.Show("Status updated successfully");
            }
            catch (Exception ex)
            {
                // Display an error message if an exception occurs during the update
                MessageBox.Show("Error updating status: " + ex.Message);
            }
        }

        // Event handler when the back button is clicked
        private void Back_button_Click(object sender, EventArgs e)
        {
            // To go back to the freelancer page
            FreelancerDashboard freelancerDashboard = new FreelancerDashboard();
            freelancerDashboard.Show();
            // To hide the view freelancer work page
            this.Hide();
        }

        // Event handler for the logout button
        private void Logout_button_Click(object sender, EventArgs e)
        {
            // Create an instance of the Main_Page form
            Main_Page main_Page = new Main_Page();
            // Hide the current form
            this.Hide();
            // Show a success message and the Main_Page form
            MessageBox.Show("Logout Succeeded.");
            main_Page.Show();
        }
    }
}
