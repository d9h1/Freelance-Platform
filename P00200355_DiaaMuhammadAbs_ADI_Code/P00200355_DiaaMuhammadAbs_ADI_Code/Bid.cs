using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P00200355_DiaaMuhammadAbs_ADI_Code
{
    public class Bid
    {
        public string projectName { get; set; }
        public DateTime Submission { get; set; }
        public string Proposal { get; set; } // description
        public double Price { get; set; }
        public Bid(string projectName, DateTime Submission, string Proposal, double Price)
        {
            if (projectName == null) throw new ArgumentNullException();
            else if (Submission == null) throw new ArgumentNullException();
            else if (Proposal == null) throw new ArgumentNullException();
            else if (Price <= 0) throw new ArgumentOutOfRangeException();
            else
            {
                this.projectName = projectName;
                this.Submission = Submission;
                this.Proposal = Proposal;
                this.Price = Price;
            }
        }


    }
}
