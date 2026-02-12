using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P00200355_DiaaMuhammadAbs_ADI_Code
{
    public class Client:User
    {
        public ContactDetails contactDetails { get; set; }
        public Client(string username, string password, ContactDetails contactDetails):base(username,password)
        {
            if (Username == null || Password == null || contactDetails == null)
            {
                throw new ArgumentNullException("Null");
            }
            else
            {
                this.contactDetails = contactDetails;
                this.Username = username;
                this.Password = password;
            }
        }
    }
}
