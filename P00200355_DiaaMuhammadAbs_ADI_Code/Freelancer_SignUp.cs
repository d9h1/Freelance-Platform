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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace P00200355_DiaaMuhammadAbs_ADI_Code
{
    public partial class Freelancer_SignUp : Form
    {

        private void Back_button_Click(object sender, EventArgs e)
        {
            //to go back to the signin form
            SignIn c1 = new SignIn();
            c1.Show();
            //to hide the post bid page
            this.Hide();
        }

        public Freelancer_SignUp()
        {
            InitializeComponent();
        }

        private void ShowPassword_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassword_checkBox.Checked)
            {
                //when the checkbox is checked the password and the confirm password will appear
                Password_textBox.UseSystemPasswordChar = false;
                ConfirmPassword_textBox.UseSystemPasswordChar = false;
            }
            else
            {
                //when the checkbox is not checked the password and the confirm password will not appear 
                Password_textBox.UseSystemPasswordChar = true;
                ConfirmPassword_textBox.UseSystemPasswordChar = true;

            }
        }

        private void Signup_button_Click(object sender, EventArgs e)
        {
            // Database connection
            string connection = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\hanen\OneDrive\Desktop\uni\uni level 5\level 5-1 semester\Finl Assignments\P00200355_DiaaMuhammadAbs_ADI\P00200355_DiaaMuhammadAbs_ADI_Code\ADI_Project_Diaa.accdb"";Persist Security Info=True";
            // Retrieve signup details from form fields
            string Username = Username_textBox.Text;
            string Password = Password_textBox.Text;
            string Skills = Skills_textBox.Text;
            string Portfolio = Portfolio_richTextBox.Text;
            string Expertise = Expertise_richTextBox.Text;
            string Past_work = PastWork_richTextBox.Text;
            // INSERT query 
            string query = $"INSERT INTO Freelancer VALUES ('{Username}','{Password}','{Skills}','{Portfolio}','{Expertise}','{Past_work}')";
            string Confirm_password = ConfirmPassword_textBox.Text;
            // Nullity if statement
            if (string.IsNullOrEmpty(Username))
            {
                MessageBox.Show("Please set a new username");
            }
            // password length if statement
            else if (Password.Length < 8 || Password.Length > 12)
            {
                MessageBox.Show("Password Must be between 8 and 12");
            }
            // check if the Password and Confirm_password are the same if statement
            else if (Password != Confirm_password)
            {
                MessageBox.Show("Passwords dont match");

            }
            // check if the password has one uppercase and one lowercase char
            else if (!Password.Any(Char.IsUpper) || !Password.Any(Char.IsLower))
            {
                MessageBox.Show("Password must have 1 Uppercase and Lowercase Letter");
            }
            // Nullity if statement
            else if (string.IsNullOrEmpty(Password) || string.IsNullOrEmpty(Confirm_password))
            {
                MessageBox.Show("Please set a new password");
            }
            else if (string.IsNullOrEmpty(Skills))
            {
                MessageBox.Show("Please write your skills");
            }
            else if (string.IsNullOrEmpty(Portfolio))
            {
                MessageBox.Show("Please write your portfolio");
            }
            else if (string.IsNullOrEmpty(Expertise))
            {
                MessageBox.Show("Please write your expertise");
            }
            else if (string.IsNullOrEmpty(Past_work))
            {
                MessageBox.Show("Please write your Past work");
            }
            else
            {

                // Check if the username already exists
                if (IsUsernameUnique(Username))
                {
                    // Username is unique, proceed with the insertion
                    try
                    {
                        OleDbConnection c1 = new OleDbConnection(connection);
                        c1.Open();

                        // Execute the insertion query
                        OleDbCommand c2 = new OleDbCommand(query, c1);
                        c2.ExecuteNonQuery();

                        // Close the connection
                        c1.Close();
                        MessageBox.Show("Saved");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    // Username already exists, show an error message
                    MessageBox.Show("Username already exists. Please choose a different username.");
                }
            }
        }

        private bool IsUsernameUnique(string username)
        {
            // Database connection
            string connection = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\hanen\OneDrive\Desktop\uni\uni level 5\level 5-1 semester\Finl Assignments\P00200355_DiaaMuhammadAbs_ADI\P00200355_DiaaMuhammadAbs_ADI_Code\ADI_Project_Diaa.accdb"";Persist Security Info=True";
            // SELECT query from client and freelancer database table
            string query = $"SELECT COUNT(*) FROM Freelancer WHERE Username = '{username}'";
            string query2 = $"SELECT COUNT(*) FROM Client WHERE Username = '{username}'";

            try
            {
                using (OleDbConnection c3 = new OleDbConnection(connection))
                {
                    c3.Open();

                    using (OleDbCommand command1 = new OleDbCommand(query, c3))
                    {
                        int count1 = (int)command1.ExecuteScalar();

                        using (OleDbCommand command2 = new OleDbCommand(query2, c3))
                        {
                            int count2 = (int)command2.ExecuteScalar();

                            // If the username is found in either table, return false
                            return count1 == 0 && count2 == 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
