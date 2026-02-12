using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P00200355_DiaaMuhammadAbs_ADI_Code
{
    public partial class ClientDashboard : Form
    {
        public ClientDashboard()
        {
            InitializeComponent();
        }
        // Event handler for the logout button
        private void Logout_button_Click(object sender, EventArgs e)
        {
            Main_Page main_Page = new Main_Page();
            this.Hide();
            MessageBox.Show("Logout Succeeded.");
            main_Page.Show();
        }

        private void LeaveReview_button_Click(object sender, EventArgs e)
        {
            //to open the review page
            Review review = new Review();
            review.Show();
            //to hide the client page 
            this.Hide();
        }

        private void PostProject_button_Click(object sender, EventArgs e)
        {
            //to open the post project page
            AddProject addProject = new AddProject();
            addProject.Show();
            //to hide the client page
            this.Hide();
        }

        private void ViewBid_button_Click(object sender, EventArgs e)
        {
            //to open the view bid page
            ViewBids viewBids = new ViewBids();
            viewBids.Show();
            //to hide the client page
            this.Hide();
        }

        private void ViewFreelancer_button_Click(object sender, EventArgs e)
        {
            //to open the view freelancer page
            ViewFreelancer viewFreelancer = new ViewFreelancer();
            viewFreelancer.Show();
            //to hide the client page
            this.Hide();
        }

        private void ViewProject_button_Click_1(object sender, EventArgs e)
        {
            //to open the view project page
            ViewProject viewProject = new ViewProject();
            viewProject.Show();
            //to hide the client page
            this.Hide();
        }
    }
}
