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
    public partial class Review : Form
    {
        string FreelancerName, Description;
        public Review()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] Evaluation = { "1-Bad", "2-Satisfactory", "3-Good", "4-Very Good", "5-Outstanding" };
            comboBox1.Items.Add(Evaluation);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            Description = richTextBox1.Text;
        }

        private void Submit_button_Click(object sender, EventArgs e)
        {
            // Database connection
            string connection = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\hanen\OneDrive\Desktop\uni\uni level 5\level 5-1 semester\Finl Assignments\P00200355_DiaaMuhammadAbs_ADI\P00200355_DiaaMuhammadAbs_ADI_Code\ADI_Project_Diaa.accdb"";Persist Security Info=True";
            // Retrieve review details from form fields
            string Freelancer_name = Name_textBox.Text;
            string Evaluation = comboBox1.Text;
            string Description = richTextBox1.Text;
            //Insert query 
            string query = $"INSERT INTO Review VALUES ('{Freelancer_name}','{Evaluation}','{Description}')";
            // Retrieve the freelancer username in the database and confirm that it is available.
            using (OleDbConnection c1 = new OleDbConnection(connection))
            {
                c1.Open();

                string checkUsernameQuery = "SELECT COUNT(*) FROM Freelancer WHERE Username = @Username";
                using (OleDbCommand checkCommand = new OleDbCommand(checkUsernameQuery, c1))
                {
                    checkCommand.Parameters.AddWithValue("@Username", Name_textBox.Text);
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
                    MessageBox.Show("Your rewiew has been send successfully.");
                }
            }
            // Nullity if statement
            if (FreelancerName == null)
            {
                MessageBox.Show("You must fill Freelancer Name");
            }
            else if (comboBox1 == null)
            {
                MessageBox.Show("Evaluation is empty");
            }
            else
            {
                
            }
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            ClientDashboard clientDashboard = new ClientDashboard();
            this.Hide();
            clientDashboard.Show();
        }

        private void ViewBid_button_Click(object sender, EventArgs e)
        {
            //to open the view bids page
            ViewBids viewBids = new ViewBids();
            viewBids.Show();
            //to hide the review page
            this.Hide();
        }

        private void ViewFreelancer_button_Click(object sender, EventArgs e)
        {
            //to open the view freelancer page
            ViewFreelancer viewFreelancer = new ViewFreelancer();
            viewFreelancer.Show();
            //to hide the review page
            this.Hide();
        }

        private void PostProject_button_Click(object sender, EventArgs e)
        {
            //to open the post project page
            AddProject addProject = new AddProject();
            addProject.Show();
            //to hide the review page
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            FreelancerName = Name_textBox.Text;
        }
    }
}
