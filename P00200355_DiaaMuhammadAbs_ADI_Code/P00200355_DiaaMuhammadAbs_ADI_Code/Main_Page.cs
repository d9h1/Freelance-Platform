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
    public partial class Main_Page : Form
    {
        public Main_Page()
        {
            InitializeComponent();
        }

        private void Client_button_Click(object sender, EventArgs e)
        {
            //to open the Sign in page
            SignIn s2 = new SignIn();
            s2.Show();
            //to close the Main page when we open the sign in page
            this.Hide();
            
        }

        private void Freelancer_button_Click(object sender, EventArgs e)
        {
            //to open the Sign in page
            SignIn s1 = new SignIn();
            s1.Show();
            //to hide the Main page when we open the sign in page
            this.Hide();
        }
    }
}
