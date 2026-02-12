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

        private void FreelancerWork_Load(object sender, EventArgs e)
        {
            this.freelancer_Accepted_BidsTableAdapter.Fill(this.aDI_Project_DiaaDataSet.Freelancer_Accepted_Bids);

            dataView = new DataView(this.aDI_Project_DiaaDataSet.Freelancer_Accepted_Bids);
            _dataGridView.DataSource = dataView;
            _dataGridView.Visible = false;
        }

        private void search_button_Click_1(object sender, EventArgs e)
        {
            string searchKeyword = Search_textBox.Text;

            Console.WriteLine("Search Keyword: " + searchKeyword);

            if (!string.IsNullOrEmpty(searchKeyword))
            {
                dataView.RowFilter = $"Username LIKE '%{searchKeyword}%'";
                Console.WriteLine("Filtered Rows Count: " + _dataGridView.Rows.Count);
                _dataGridView.Refresh();
                _dataGridView.Visible = true;

                if (_dataGridView.Rows.Count == 0)
                {
                    MessageBox.Show("No matching records found.");
                }
            }
            else
            {
                dataView.RowFilter = "";
                _dataGridView.Visible = false;
            }
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            if (_dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a bid to update the status.");
                return;
            }

            int selectedRowIndex = _dataGridView.SelectedRows[0].Index;
            string selectedWorking_condition = Working_condition_comboBox.SelectedItem.ToString();
            int selectedID = Convert.ToInt32(this.aDI_Project_DiaaDataSet.Freelancer_Accepted_Bids.Rows[selectedRowIndex]["ID"]);

            string freelancerUpdateQuery = "UPDATE Freelancer_Accepted_Bids SET Working_condition = @NewWorking_condition WHERE ID = @ID";
            string projectUpdateQuery = "UPDATE Project SET Working_condition = @NewWorking_condition WHERE Project_Name = @Project_Name";

            try
            {
                using (OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\hanen\OneDrive\Desktop\uni\uni level 5\level 5-1 semester\Finl Assignments\P00200355_DiaaMuhammadAbs_ADI\P00200355_DiaaMuhammadAbs_ADI_Code\ADI_Project_Diaa.accdb;Persist Security Info=True"))
                {
                    connection.Open();

                    using (OleDbCommand freelancerCommand = new OleDbCommand(freelancerUpdateQuery, connection))
                    {
                        freelancerCommand.Parameters.AddWithValue("@NewWorking_condition", selectedWorking_condition);
                        freelancerCommand.Parameters.AddWithValue("@ID", selectedID);
                        freelancerCommand.ExecuteNonQuery();
                    }

                    // Check if the working condition is "Ongoing" or "Completed" before transferring to the Project table
                    if (selectedWorking_condition == "Ongoing" || selectedWorking_condition == "Completed")
                    {
                        using (OleDbCommand projectCommand = new OleDbCommand(projectUpdateQuery, connection))
                        {
                            projectCommand.Parameters.AddWithValue("@NewWorking_condition", selectedWorking_condition);
                            projectCommand.Parameters.AddWithValue("@Project_Name", this.aDI_Project_DiaaDataSet.Freelancer_Accepted_Bids.Rows[selectedRowIndex]["Project_Name"]);
                            projectCommand.ExecuteNonQuery();
                        }
                    }

                    connection.Close();
                }

                this.aDI_Project_DiaaDataSet.Freelancer_Accepted_Bids[selectedRowIndex].Working_condition = selectedWorking_condition;
                this.freelancer_Accepted_BidsTableAdapter.Update(this.aDI_Project_DiaaDataSet.Freelancer_Accepted_Bids.Rows[selectedRowIndex]);

                _dataGridView.Refresh();
                MessageBox.Show("Status updated successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating status: " + ex.Message);
            }
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            FreelancerDashboard freelancerDashboard = new FreelancerDashboard();
            freelancerDashboard.Show();
            this.Hide();
        }

        private void Logout_button_Click(object sender, EventArgs e)
        {
            Main_Page main_Page = new Main_Page();
            this.Hide();
            MessageBox.Show("Logout Succeeded.");
            main_Page.Show();
        }
    }
}
