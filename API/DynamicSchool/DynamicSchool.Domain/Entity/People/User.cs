using System;

namespace DynamicSchool.Domain.Entity.People
{
    public class User : Person
    {      

        public Guid AggregateRootId { get; private set; }
        public string Login { get; private set; }
        public string Password { get; private set; }
        public Profile Profile { get; private set; }

        public User(string login, string password, Profile profile)
        {
            AggregateRootId = ;
            Login = login;
            Password = password;
            Profile = profile;
        }

    }
}
