using DynamicSchool.Domain.Enum;
using System;

namespace DynamicSchool.Domain.Entity.People
{
    public class Teacher : Entity
    {
        public string Name { get; private set; }
        public string Document { get; private set; }
        public string Email { get; private set; }
        public string CellPhone { get; private set; }
        public DateTime BirthDate { get; private set; }
        public string Resume { get; private set; }
        public Client Client { get; private set; }

        public Teacher(string name, string document, string email, string cellPhone, DateTime birthDate, Client client)
        {
            Name = name;
            Document = document;
            Email = email;
            CellPhone = cellPhone;
            BirthDate = birthDate;     
            Client = client;
        }
        public void Activate() => StatusEntity = StatusEntityEnum.Active;
        public void Inactivate() => StatusEntity = StatusEntityEnum.Inactive;

        public Teacher SetResume(string resume)
        {
            Resume = resume;
            return this;
        }

        public void Validate()
        {

        }
    }
}
