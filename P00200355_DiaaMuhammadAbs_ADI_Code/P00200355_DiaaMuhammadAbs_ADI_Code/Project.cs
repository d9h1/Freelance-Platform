using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P00200355_DiaaMuhammadAbs_ADI_Code
{
    public class Project
    {
        string ProjectName { get; set; }
        double budget { get; set; }
        DateTime deadline { get; set; }
        string Description { get; set; }
        public Project(string projectName, double budget, DateTime deadline, string Description)
        {
            if (projectName == null)
            {
                throw new ArgumentNullException();
            }
            else if (budget <= 0) 
            {
                throw new ArgumentException();
            }
            else if (deadline == null)
            {
                throw new ArgumentNullException();
            }
            else if (Description == null)
            {
                throw new ArgumentNullException();
            }
            else
            {
                this.ProjectName = projectName;
                this.budget = budget;
                this.deadline = deadline;
                this.Description = Description;
            }
        }
    }
}
