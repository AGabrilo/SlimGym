using System;
using System.Collections.Generic;
using System.Text;

namespace SlimGym.Models
{
   public class ProfileData
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public char Gender { get; set; }
        public string Contact { get; set; }

        public ProfileData() { }
        public ProfileData(string Name, string Surname, string Email, string Username, string Password,char Gender,string Contact)
        {
            this.Username = Username;
            this.Name = Name;
            this.Surname = Surname;
            this.Email = Email;
            this.Password = Password;
            this.Gender = Gender;
            this.Contact = Contact;

        }
        
        
    }
}
