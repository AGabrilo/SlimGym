using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace SlimGym.Models
{
    public class ProfileListView
    {
        public ObservableCollection<ProfileModel> ProfileCollector { get; set; }
        public ProfileListView()
        {
            ProfileCollector = new ObservableCollection<ProfileModel>()
            {
            new ProfileModel(){id=1,ProfileData="Name",UserDetail="Maja"},
            new ProfileModel(){id=2,ProfileData="Surname",UserDetail="Majic"},
            new ProfileModel(){id=3,ProfileData="Email",UserDetail="majamajic@gmail.com" },
            new ProfileModel(){id=4,Image = "/images/edit.png",ProfileData="Username",UserDetail="MajaM5" },
            new ProfileModel(){id=5,Image = "/images/edit.png",ProfileData="Password",UserDetail="********"},
            new ProfileModel(){id=6,ProfileData="Gender",UserDetail="F" },
            new ProfileModel(){id=7,ProfileData="Contact" ,UserDetail="+385 993248686"},
            new ProfileModel(){id=8,ProfileData="Date of birth",UserDetail="25.5.1990" },

            };


        
        }
    }
}
