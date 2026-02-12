using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P00200355_DiaaMuhammadAbs_ADI_Code
{
    public partial class AddProject : Form
    {
        
        public AddProject()
        {
            InitializeComponent();
        }
        // Event handler for the back button
        private void Back_button_Click(object sender, EventArgs e)
        {
            //to go back to the Client page
            ClientDashboard clientDashboard = new ClientDashboard();
            //to hide the post project page
            this.Hide();
            //to show the ClientDashboard form
            clientDashboard.Show();
        }

        private void PostProject_button_Click(object sender, EventArgs e)
        {
            // Database connection
            string connection = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\hanen\OneDrive\Desktop\uni\uni level 5\level 5-1 semester\Finl Assignments\P00200355_DiaaMuhammadAbs_ADI\P00200355_DiaaMuhammadAbs_ADI_Code\ADI_Project_Diaa.accdb"";Persist Security Info=True";
            // Retrieve project details from form fields
            string Client_Name = username_textBox.Text;
            string Project_Name = projectName_textBox.Text;
            string Description = Description_richTextBox.Text;
            string Timeline = Deadline_dateTimePicker1.Text;
            string budget = Budget_textBox.Text;
            string Project_type = ProjectType_comboBox.Text;
            //Insert query 
            string query = $"INSERT INTO Project (Client_Name, Project_Name, Description, Timeline, budget, Project_type) VALUES ('{Client_Name}','{Project_Name}','{Description}','{Timeline}','{budget}', '{Project_type}')";
            // Retrieve the client's username in the database and confirm that it is available.
            using (OleDbConnection c1 = new OleDbConnection(connection))
            {
                c1.Open();

                string checkUsernameQuery = "SELECT COUNT(*) FROM Client WHERE Username = @Username";
                using (OleDbCommand checkCommand = new OleDbCommand(checkUsernameQuery, c1))
                {
                    checkCommand.Parameters.AddWithValue("@Username", username_textBox.Text);
                    int count = (int)checkCommand.ExecuteScalar();
                    // Execute the insertion query
                    OleDbCommand c2 = new OleDbCommand(query, c1);
                    c2.ExecuteNonQuery();
                    if (count == 0)
                    {
                        MessageBox.Show("Username not found in the database.");
                        return;
                    }
                    // Close the database connection
                    c1.Close();
                    MessageBox.Show("Your project has been posted successfully.");

                    
                }
            }
            // Nullity if statement
            if (Client_Name == null)
            {
                MessageBox.Show("username is null");
            }
            else if (Project_Name == null)
            {
                MessageBox.Show("Project Name is null");
            }
            else if (Description == null)
            {
                MessageBox.Show("Description is null");
            }
            else if (Timeline == null)
            {
                MessageBox.Show("Deadline is null");
            }
            else if (budget == null)
            {
                MessageBox.Show("budget is null");
            }
            else if (Project_type == null)
            {
                MessageBox.Show("Project type is not selected");
            }
        }

        private void LeaveReview_button_Click(object sender, EventArgs e)
        {
            //to open the review page
            Review review = new Review();
            review.Show();
            //to hide the post project page
            this.Hide();
        }

        private void ViewBid_button_Click(object sender, EventArgs e)
        {
            //to open the view bid page
            ViewBids viewBids = new ViewBids();
            viewBids.Show();
            //to hide the post project page 
            this.Hide();
        }

        private void ViewFreelancer_button_Click(object sender, EventArgs e)
        {
            //to open the view freelancer page
            ViewFreelancer viewFreelancer = new ViewFreelancer();
            viewFreelancer.Show();
            //to hide the post project page 
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
