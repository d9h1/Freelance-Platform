using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P00200355_DiaaMuhammadAbs_ADI_Code
{
    public class Freelancer:User
    {
        public string skills {  get; set; }
        public string expertise { get; set; }
        public string portfolio {  get; set; }
        public string Past_work { get; set; }
        public Freelancer(string username, string password, string skills, string expertise, string portfolio, string past_work) : base(username, password)
        {
            if (username == null || password == null || skills == null || expertise == null || portfolio == null || Past_work == null)
            {
                throw new ArgumentNullException("Null");
            }
            else
            {
                this.skills = skills;
                this.expertise = expertise;
                this.portfolio = portfolio;
                this.Past_work = past_work;
            }
            Past_work = past_work;
        }
    }
}
