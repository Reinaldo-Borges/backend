using System;

namespace DynamicSchool.Domain.Entity.People
{
    public class User : Entity
    {      
       
        public string Login { get; private set; }
        public string Password { get; private set; }
        public Profile Profile { get; private set; }
        public Client Client { get; private set; }

        public User(string login, string password, Profile profile, Client client)
        {           
            Login = login;
            Password = password;
            Profile = profile;
            Client = client;
        }

    }
}
