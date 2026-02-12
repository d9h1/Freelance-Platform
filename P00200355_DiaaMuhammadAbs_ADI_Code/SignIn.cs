using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace P00200355_DiaaMuhammadAbs_ADI_Code
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void Signup_linklabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //to open freelancer signup form
            Freelancer_SignUp freelancer_SignUp = new Freelancer_SignUp();
            freelancer_SignUp.Show();
            this.Hide();
        }
        //check box hide an show password
        private void ShowPassword_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            //when the checkbox is checked the password will appear
            if (ShowPassword_checkBox.Checked)
            {
                Password_textBox.UseSystemPasswordChar = false;
            }
            //when the checkbox is not checked the password will not appear 
            else
            {
                Password_textBox.UseSystemPasswordChar = true;
            }
        }

        private void Client_linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //to show client signup form
            Client_SignUp Client_SignUp = new Client_SignUp();
            Client_SignUp.Show();
            this.Hide();
        }

        private void Signin_button_Click(object sender, EventArgs e)
        {
            //to connect the database
            string connection = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\hanen\OneDrive\Desktop\uni\uni level 5\level 5-1 semester\Finl Assignments\P00200355_DiaaMuhammadAbs_ADI\P00200355_DiaaMuhammadAbs_ADI_Code\ADI_Project_Diaa.accdb"";Persist Security Info=True";
            string username = Username_textBox.Text;
            string password = Password_textBox.Text;
            //try: a code that is used to try
            try
            {
                using (OleDbConnection connections = new OleDbConnection(connection))
                {
                    connections.Open();

                    // Check for a match in the Client table first
                    string query = "SELECT COUNT(*) FROM Client WHERE Username = @Username AND Password = @Password";
                    OleDbCommand command = new OleDbCommand(query, connections);
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    int count = (int)command.ExecuteScalar();

                    if (count > 0)
                    {
                        // if the Client found, show ClientDashboard
                        ClientDashboard clientDashboard = new ClientDashboard();
                        clientDashboard.Show();
                        this.Hide();
                    }
                    else
                    {
                        // Check for a match in the Freelancer table
                        query = "SELECT COUNT(*) FROM Freelancer WHERE Username = @Username AND Password = @Password";
                        command = new OleDbCommand(query, connections);
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);

                        count = (int)command.ExecuteScalar();

                        if (count > 0)
                        {
                            // if the Freelancer found, show FreelancerDashboard
                            FreelancerDashboard freelancerDashboard = new FreelancerDashboard();
                            freelancerDashboard.Show();
                            this.Hide();
                        }
                        else
                        {
                            // No match found in either table, show invalid message
                            MessageBox.Show("Invalid Username or Password");
                        }
                    }
                }
            }
            // catch: a code that handles errors
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Username_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password_label_Click(object sender, EventArgs e)
        {

        }

        private void Password_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Username_label_Click(object sender, EventArgs e)
        {

        }

        private void Q_label_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
