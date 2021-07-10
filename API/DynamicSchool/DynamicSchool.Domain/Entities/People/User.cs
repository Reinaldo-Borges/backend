using DynamicSchool.Core.DomainObjects;

namespace DynamicSchool.Domain.Entities.People
{
    public class User : Entity
    {      
       
        public string Login { get; private set; }
        public string Password { get; private set; }
        public ProfileUser Profile { get; private set; }
        public Client Client { get; private set; }

        public User(string login, string password, ProfileUser profile, Client client)
        {           
            Login = login;
            Password = password;
            Profile = profile;
            Client = client;
        }

        private void Validate()
        {
            Assertion.HasValue(Login, "The property Login can't be void");
            Assertion.HasValue(Password, "The property Password can't be void");
            Assertion.IsNotNull(Profile, "The Profile can't be void");
            Assertion.IsNotNull(Client, "The Client can't be void");
        }

    }
}
