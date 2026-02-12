using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace P00200355_DiaaMuhammadAbs_ADI_Code
{
    public partial class BiddingSystem : Form
    {
        public BiddingSystem()
        {
            InitializeComponent();
        }

        private void Submit_button_Click(object sender, EventArgs e)
        {
            // Database connection
            string connection = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\hanen\OneDrive\Desktop\uni\uni level 5\level 5-1 semester\Finl Assignments\P00200355_DiaaMuhammadAbs_ADI\P00200355_DiaaMuhammadAbs_ADI_Code\ADI_Project_Diaa.accdb"";Persist Security Info=True";

            // Retrieve project details from form fields
            string Username = username_textBox.Text;
            string Project_Name = ProjectName_textBox.Text;
            string Description = Description_richTextBox.Text;
            string Submission_Date = dateTimePicker1.Text;
            string Price = Price_textBox.Text;

            // Check if the project name exists in the Project database
            if (!IsProjectNameExists(Project_Name, connection))
            {
                MessageBox.Show("Project Name not found in the database. Please enter a valid Project Name");
                return;
            }

            // INSERT query 
            string query = $"INSERT INTO Bidding_system (Username, Project_Name, Description, Submission_Date, Price) VALUES ('{Username}','{Project_Name}','{Description}','{Submission_Date}','{Price}')";

            // Retrieve the client's username in the database and confirm that it is available.
            using (OleDbConnection c1 = new OleDbConnection(connection))
            {
                c1.Open();
                // SELECT query to check the freelancer username availability 
                string checkUsernameQuery = "SELECT COUNT(*) FROM Freelancer WHERE Username = @Username";
                using (OleDbCommand checkCommand = new OleDbCommand(checkUsernameQuery, c1))
                {
                    checkCommand.Parameters.AddWithValue("@Username", username_textBox.Text);
                    int count = (int)checkCommand.ExecuteScalar();

                    // Execute the insertion query
                    OleDbCommand c2 = new OleDbCommand(query, c1);
                    c2.ExecuteNonQuery();

                    // Close the database connection
                    c1.Close();
                    MessageBox.Show("Your project has been posted successfully");

                    if (count == 0)
                    {
                        MessageBox.Show("Username not found in the database");
                        return;
                    }
                }
            }

            // Nullity if statement
            if (string.IsNullOrEmpty(Username))
            {
                MessageBox.Show("Please choose your username");
            }
            else if (string.IsNullOrEmpty(Project_Name))
            {
                MessageBox.Show("Please set your project Name");
            }
            else if (string.IsNullOrEmpty(Description))
            {
                MessageBox.Show("Please write the bid description");
            }
            else if (string.IsNullOrEmpty(Submission_Date))
            {
                MessageBox.Show("Submission Date is Empty");
            }
            else if (string.IsNullOrEmpty(Price))
            {
                MessageBox.Show("Please set your price");
            }
        }

        private bool IsProjectNameExists(string projectName, string connection)
        {
            using (OleDbConnection c1 = new OleDbConnection(connection))
            {
                c1.Open();
                string checkProjectNameQuery = "SELECT COUNT(*) FROM Project WHERE Project_Name = @Project_Name";
                using (OleDbCommand checkCommand = new OleDbCommand(checkProjectNameQuery, c1))
                {
                    checkCommand.Parameters.AddWithValue("@Project_Name", projectName);
                    int count = (int)checkCommand.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        // Event handler for the back button
        private void Back_button_Click(object sender, EventArgs e)
        {
            //to go back to the freelancer page
            FreelancerDashboard freelancerDashboard = new FreelancerDashboard();
            freelancerDashboard.Show();
            //to hide the post bid page
            this.Hide();
        }

        // Event handler for the logout button
        private void Logout_button_Click(object sender, EventArgs e)
        {
            Main_Page main_Page = new Main_Page();
            this.Hide();
            MessageBox.Show("Logout Succeeded");
            main_Page.Show();
        }
    }
}
