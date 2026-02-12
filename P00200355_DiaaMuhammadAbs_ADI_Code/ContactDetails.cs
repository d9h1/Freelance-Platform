using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P00200355_DiaaMuhammadAbs_ADI_Code
{
    public class ContactDetails
    {
        public string Phone_number {  get; set; }
        public string Email { get; set; }
        public ContactDetails(string phoneNumber, string Email)
        {
            if (Phone_number == null || Email == null)
            {
                throw new ArgumentNullException("null");
            }
            else
            {
                this.Phone_number = Phone_number;
                this.Email = Email;

            }
        }
    }
    
}
