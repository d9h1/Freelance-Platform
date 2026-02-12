using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P00200355_DiaaMuhammadAbs_ADI_Code
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public User(string username, string password)
        {
            if (username == null || password == null)
            {
                throw new ArgumentNullException("Null values whether in username or password");
            }
            else
            {
                this.Username = username;
                this.Password = password;
            }
        }
    }
}
