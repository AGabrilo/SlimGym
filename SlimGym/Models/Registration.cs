using System;
using System.Collections.Generic;
using System.Text;

namespace SlimGym.Models
{
    public class Registration
    {
        public string Username { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
       // public DateTime DayOfBirth { get; set; }

        public Registration() { }
        public Registration(string Username, string Name, string Surname, string Email, string Password)
        {
            this.Username = Username;
            this.Name = Name;
            this.Surname = Surname;
            this.Email = Email;
            this.Password = Password;
          
        }

    }
}
