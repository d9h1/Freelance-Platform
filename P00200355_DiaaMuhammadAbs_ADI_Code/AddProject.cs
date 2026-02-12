using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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

            // Check if the client name exists in the Client database table
            if (!IsUsernameExists(Client_Name, connection))
            {
                MessageBox.Show("Client Name not found in the database. Please enter a valid Client Name");
                return;
            }

            try
            {
                // INSERT query for the Project database table
                string INSERTquery = $"INSERT INTO Project (Client_Name, Project_Name, Description, Timeline, budget, Project_type) VALUES ('{Client_Name}','{Project_Name}','{Description}','{Timeline}','{budget}', '{Project_type}')";

                // Retrieve the client username in the database and confirm that it is available.
                using (OleDbConnection c1 = new OleDbConnection(connection))
                {
                    c1.Open();

                    // Execute the insertion query
                    using (OleDbCommand c2 = new OleDbCommand(INSERTquery, c1))
                    {
                        c2.ExecuteNonQuery();
                    }

                    // Close the database connection
                    c1.Close();
                    MessageBox.Show("Your project has been posted successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while posting the project: {ex.Message}");
            }

            // Nullity if statement
            if (string.IsNullOrEmpty(Client_Name))
            {
                MessageBox.Show("Please choose your username");
            }
            else if (string.IsNullOrEmpty(Project_Name))
            {
                MessageBox.Show("Please set your project Name");
            }
            else if (string.IsNullOrEmpty(Description))
            {
                MessageBox.Show("Please write the project description");
            }
            else if (string.IsNullOrEmpty(Timeline))
            {
                MessageBox.Show("Please set the required submission date");
            }
            else if (string.IsNullOrEmpty(budget))
            {
                MessageBox.Show("Please set a budget");
            }
            else if (string.IsNullOrEmpty(Project_type))
            {
                MessageBox.Show("Project type is not selected");
            }
        }


        private bool IsUsernameExists(string username, string connection)
        {
            using (OleDbConnection c1 = new OleDbConnection(connection))
            {
                c1.Open();
                string checkUsernameQuery = "SELECT COUNT(*) FROM Client WHERE Username = @Username";
                using (OleDbCommand checkCommand = new OleDbCommand(checkUsernameQuery, c1))
                {
                    checkCommand.Parameters.AddWithValue("@Username", username);
                    int count = (int)checkCommand.ExecuteScalar();
                    return count > 0;
                }
            }
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
