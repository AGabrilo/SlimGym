using System;
using System.Collections.Generic;
using System.Text;

namespace SlimGym.Models
{
    //ovo sam samo nešto probala za mijenjanje lozinke u profilu...
    public class PasswordCheck
    {
        public string Password { get; set; }
        public string NewPassword { get; set; }
        public string RepeatPassword { get; set; }
         PasswordCheck() { }
        public PasswordCheck(string Password,string NewPassword,string RepeatPassword) 
        {
            this.Password = Password;
            this.NewPassword = NewPassword;
            this.RepeatPassword = RepeatPassword;
        }
        public bool CheckRepeatedPassword()
        {
            if (this.NewPassword.Equals(RepeatPassword))
                return true;
            else
                return false;
        }
    }
}
