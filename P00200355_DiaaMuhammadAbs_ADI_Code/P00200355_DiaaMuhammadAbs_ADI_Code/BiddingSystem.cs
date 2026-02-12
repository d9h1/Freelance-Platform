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
                MessageBox.Show("Project Name not found in the database. Please enter a valid Project Name.");
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
                    MessageBox.Show("Your project has been posted successfully.");

                    if (count == 0)
                    {
                        MessageBox.Show("Username not found in the database.");
                        return;
                    }
                }
            }

            // Nullity if statement
            if (Username == null)
            {
                MessageBox.Show(" username is Null");
            }
            else if (Project_Name == null)
            {
                MessageBox.Show("Project Name is Null");
            }
            else if (Description == null)
            {
                MessageBox.Show("Description is Null");
            }
            else if (Submission_Date == null)
            {
                MessageBox.Show("Submission Date is Empty");
            }
            else if (Price == null)
            {
                MessageBox.Show("Price is Empty");
            }
            else
            {
                // Other code to handle non-null cases if needed...
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

        // Event handler for the View Project button
        private void ViewProject_button_Click(object sender, EventArgs e)
        {
            //to open the view project page
            ViewProject viewproject = new ViewProject();
            viewproject.Show();
            //to hide the post bid page
            this.Hide();
        }

        // Event handler for the View bid button
        private void ViewBid_button_Click(object sender, EventArgs e)
        {
            //to open the view bids page
            ViewFreelancerWork viewFreelancerWork = new ViewFreelancerWork();
            viewFreelancerWork.Show();
            //to hide the post bid page
            this.Hide();
        }

        // Event handler for the logout button
        private void Logout_button_Click(object sender, EventArgs e)
        {
            Main_Page main_Page = new Main_Page();
            this.Hide();
            MessageBox.Show("Logout Succeeded.");
            main_Page.Show();
        }
    }
}
