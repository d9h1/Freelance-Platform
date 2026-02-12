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
        public Review()
        {
            InitializeComponent();
        }

        private void Submit_button_Click(object sender, EventArgs e)
        {
            // Database connection
            string connection = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\hanen\OneDrive\Desktop\uni\uni level 5\level 5-1 semester\Finl Assignments\P00200355_DiaaMuhammadAbs_ADI\P00200355_DiaaMuhammadAbs_ADI_Code\ADI_Project_Diaa.accdb"";Persist Security Info=True";
            // Retrieve review details from form fields
            string Freelancer_name = Name_textBox.Text;
            string Evaluation = comboBox1.Text;
            string Description = richTextBox1.Text;
            //Insert query for review database table
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
            if (string.IsNullOrEmpty(Freelancer_name))
            {
                MessageBox.Show("You must fill Freelancer Name");
            }
            else if (string.IsNullOrEmpty(Evaluation))
            {
                MessageBox.Show("Evaluation is empty");
            }
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            //to go back to the Client page
            ClientDashboard clientDashboard = new ClientDashboard();
            //to hide the review page
            this.Hide();
            //to show the ClientDashboard form
            clientDashboard.Show();
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
