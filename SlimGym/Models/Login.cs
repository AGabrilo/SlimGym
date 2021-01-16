using System;
using System.Collections.Generic;
using System.Text;

namespace SlimGym.Models
{
    public class Login
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        //constructors
        public Login() { }
        public Login(string Username, string Password)
        {
            this.Username = Username;
            this.Password = Password;
        }

        
        public bool CheckInformation()
        {
            if (!this.Username.Equals("Petra") && !this.Password.Equals("pd123"))
                return false;
            else
                return true;
        }
    }
}
