using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P00200355_DiaaMuhammadAbs_ADI_Code
{
    public class Bid
    {
        //set and get methods
        public string ID { get; set; }
        public string FreelancerUsername { get; set; }
        public string Project_Name { get; set; }
        public string Description { get; set; }
        string Submission_Date { get; set; }
        string Price { get; set; }
        string Status { get; set; }
        public Bid(int ID,string FreelancerUsername, string Project_Name, string Description, string Submission_Date, string Price, string Status)
        {
            if (ID == null) throw new ArgumentNullException();
            else if (FreelancerUsername == null) throw new ArgumentNullException();
            else if (Project_Name == null) throw new ArgumentNullException();
            else if (Description == null) throw new ArgumentNullException();
            else if (Submission_Date == null) throw new ArgumentNullException();
            else if (Price == null) throw new ArgumentOutOfRangeException();
            else if (Status == null) throw new ArgumentNullException();
            else
            {
                this.FreelancerUsername = FreelancerUsername;
                this.Project_Name = Project_Name;
                this.Description = Description;
                this.Submission_Date = Submission_Date;
                this.Price = Price;
                this.Status = Status;
            }
        }


    }
}
