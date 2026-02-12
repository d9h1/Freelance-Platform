using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace P00200355_DiaaMuhammadAbs_ADI_Code
{
    public partial class ViewBids : Form
    {
        public ViewBids()
        {
            InitializeComponent();
        }

        private void Logout_button_Click(object sender, EventArgs e)
        {
            Main_Page main_Page = new Main_Page();
            this.Hide();
            MessageBox.Show("Logout Succeeded.");
            main_Page.Show();
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            // To go back to the client page
            ClientDashboard clientdashboard = new ClientDashboard();
            clientdashboard.Show();
            // To hide the view bid page
            this.Hide();
        }

        private void ViewBids_Load(object sender, EventArgs e)
        {
            // Load data into the 'aDI_Project_DiaaDataSet.Bidding_system' table.
            // You can move or remove it as needed.
            this.bidding_systemTableAdapter.Fill(this.aDI_Project_DiaaDataSet.Bidding_system);
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            // Check if a row is selected in the DataGridView
            if (viewBid_dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a bid to update the status.");
                return;
            }

            int selectedRowIndex = viewBid_dataGridView.SelectedRows[0].Index;
            string selectedStatus = Status_comboBox.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedStatus))
            {
                MessageBox.Show("Please select a status.");
                return;
            }

            // Get the BidID for the selected row
            int selectedID = Convert.ToInt32(this.aDI_Project_DiaaDataSet.Bidding_system.Rows[selectedRowIndex]["ID"]);

            // Update query with primary key (assuming BidID is the primary key)
            string updateQuery = "UPDATE Bidding_system SET Status = @NewStatus WHERE ID = @ID";

            try
            {
                using (OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\hanen\OneDrive\Desktop\uni\uni level 5\level 5-1 semester\Finl Assignments\P00200355_DiaaMuhammadAbs_ADI\P00200355_DiaaMuhammadAbs_ADI_Code\ADI_Project_Diaa.accdb;Persist Security Info=True"))
                {
                    connection.Open();

                    // Update Bidding_system table
                    using (OleDbCommand command = new OleDbCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@NewStatus", selectedStatus);
                        command.Parameters.AddWithValue("@ID", selectedID);
                        command.ExecuteNonQuery();
                    }

                    // Insert into Freelancer_Accepted_Bids table if the status is "Accepted"
                    if (selectedStatus == "Accept")
                    {
                        // Insert query for accepted bids into Freelancer_Accepted_Bids table
                        string insertQuery = "INSERT INTO Freelancer_Accepted_Bids (ID, Username, Project_Name, Description, Submission_Date, Price, Status) " +
                                             "VALUES (@ID, @Username, @Project_Name, @Description, @Submission_Date, @Price, @Status)";

                        using (OleDbCommand insertCommand = new OleDbCommand(insertQuery, connection))
                        {
                            insertCommand.Parameters.AddWithValue("@ID", selectedID);
                            insertCommand.Parameters.AddWithValue("@Username", this.aDI_Project_DiaaDataSet.Bidding_system.Rows[selectedRowIndex]["Username"]);
                            insertCommand.Parameters.AddWithValue("@Project_Name", this.aDI_Project_DiaaDataSet.Bidding_system.Rows[selectedRowIndex]["Project_Name"]);
                            insertCommand.Parameters.AddWithValue("@Description", this.aDI_Project_DiaaDataSet.Bidding_system.Rows[selectedRowIndex]["Description"]);
                            insertCommand.Parameters.AddWithValue("@Submission_Date", this.aDI_Project_DiaaDataSet.Bidding_system.Rows[selectedRowIndex]["Submission_Date"]);
                            insertCommand.Parameters.AddWithValue("@Price", this.aDI_Project_DiaaDataSet.Bidding_system.Rows[selectedRowIndex]["Price"]);
                            insertCommand.Parameters.AddWithValue("@Status", selectedStatus);
                            insertCommand.ExecuteNonQuery();
                        }
                    }

                    // Close the connection
                    connection.Close();
                }

                // Update the status in the dataset
                this.aDI_Project_DiaaDataSet.Bidding_system[selectedRowIndex].Status = selectedStatus;

                // Save the changes to the database using TableAdapter
                this.bidding_systemTableAdapter.Update(this.aDI_Project_DiaaDataSet.Bidding_system.Rows[selectedRowIndex]);

                MessageBox.Show("Status updated successfully.");

                // Refresh the DataGridView to reflect the change
                viewBid_dataGridView.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating status: " + ex.Message);
            }
        }
    }
}
