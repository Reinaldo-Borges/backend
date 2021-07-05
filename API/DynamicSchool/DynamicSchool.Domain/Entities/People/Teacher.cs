using DynamicSchool.Core.DomainObjects;
using DynamicSchool.Core.Enum;
using System;

namespace DynamicSchool.Domain.Entities.People
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

            Validate();
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
            Assertion.HasValue(Name, "The property Name can't be void");
            Assertion.HasValue(Document, "The property Document can't be void");
            Assertion.HasValue(Email, "The property Email can't be void");
            Assertion.HasValue(CellPhone, "The property CellPhone can't be void");           
            Assertion.HasValue(Resume, "The property CellPhone can't be void");  
            Assertion.IsNotNull(Client, "The Client can't be void");
        }
    }
}
