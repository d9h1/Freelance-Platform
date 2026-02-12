using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P00200355_DiaaMuhammadAbs_ADI_Code
{
    public class Project
    {
        //set and get methods
        string ID { get; set; }
        string Client_Name { get; set; }
        string Project_Name { get; set; }
        string Description { get; set; }
        string budget { get; set; }
        string Timeline { get; set; }
        string Project_type { get; set; }
        string Working_condition { get; set; }
        public Project(int ID, string Client_Name, string Project_Name, string Description, string budget, string Timeline, string Project_type, string Working_condition)
        {
            if (ID == null)
            {
                throw new ArgumentNullException();
            }
            else if (Client_Name == null)
            {
                throw new ArgumentNullException();
            }
            else if (Project_Name == null)
            {
                throw new ArgumentNullException();
            }
            else if (Description == null)
            {
                throw new ArgumentNullException();
            }
            else if (budget == null) 
            {
                throw new ArgumentException();
            }
            else if (Timeline == null)
            {
                throw new ArgumentNullException();
            }
            else if(Project_type == null)
            {
                throw new ArgumentNullException();
            }
            else if(Working_condition == null)
            {
                throw new ArgumentNullException();
            }
            else
            {
                this.Client_Name = Client_Name;
                this.Project_Name = Project_Name;
                this.Description = Description;
                this.budget = budget;
                this.Timeline = Timeline;
                this.Project_type = Project_type;
                this.Working_condition = Working_condition;
            }
        }
    }
}
