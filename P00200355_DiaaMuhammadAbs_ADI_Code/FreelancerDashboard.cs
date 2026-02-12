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
    public partial class FreelancerDashboard : Form
    {
        public FreelancerDashboard()
        {
            InitializeComponent();
        }

        private void Bid_button_Click(object sender, EventArgs e)
        {
            //to open the post bid page
            BiddingSystem biddingSystem = new BiddingSystem();
            biddingSystem.Show();
            //to hide the freelancer page 
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

        private void ViewProject_button_Click(object sender, EventArgs e)
        {
            //to open the view project page
            ViewProject viewProject = new ViewProject();
            viewProject.Show();
            //to hide the freelancer page 
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //to open the view project page
            ViewFreelancerWork freelancerWork = new ViewFreelancerWork();
            freelancerWork.Show();
            //to hide the freelancer page 
            this.Hide();
        }
    }
}
