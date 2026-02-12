using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P00200355_DiaaMuhammadAbs_ADI_Code
{
    public class Reviewfreelancer
    {
        public string FreelancerUsername { get; set; }
        public string Project_Name { get; set; }
        public string Rating { get; set; }
        public string Description { get; set; }
        public Reviewfreelancer(string FreelancerUsername, string Project_Name, string Rating, string Description) 
        {
            if ( FreelancerUsername == null)
            {
                throw new ArgumentNullException();
            }
            else if ( Project_Name == null) 
            {
                throw new ArgumentNullException();
            }
            else if ( Rating == null) 
            {
                throw new ArgumentNullException();
            }
            else if ( Description == null)
            {
                throw new ArgumentNullException();
            }
            else
            {
                this.FreelancerUsername = FreelancerUsername;
                this.Rating = Rating;
                this.Project_Name = Project_Name;
                this.Description = Description;
            }
        }
    }
}
