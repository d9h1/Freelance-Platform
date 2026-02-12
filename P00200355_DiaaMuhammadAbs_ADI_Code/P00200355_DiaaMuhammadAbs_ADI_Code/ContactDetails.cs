using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P00200355_DiaaMuhammadAbs_ADI_Code
{
    public class ContactDetails
    {
        public string PhoneNumber {  get; set; }
        public string Email { get; set; }
        public ContactDetails(string phoneNumber, string email)
        {
            if (phoneNumber == null || email == null)
            {
                throw new ArgumentNullException("null");
            }
            else
            {
                this.PhoneNumber = phoneNumber;
                this.Email = email;

            }
        }
    }
    
}
