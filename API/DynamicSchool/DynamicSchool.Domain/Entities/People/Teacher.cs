using DynamicSchool.Core.DomainObjects;
using DynamicSchool.Core.Enum;
using System;

namespace DynamicSchool.Domain.Entities.People
{
    public class Teacher : Entity
    {
        public string Name { get; private set; }
        public virtual string Document { get;  set; }
        public string Email { get; private set; }
        public string Cellphone { get; private set; }
        public DateTime BirthDay { get; private set; }
        public string Resume { get; private set; }
        public Guid ClientOrigin { get; private set; }
        public Client Client { get; set; }

        public Teacher() { }

        public Teacher(string name, string document, string cellPhone, DateTime birthDay, Guid clientOrigin)
        {
            Name = name;
            Document = document;          
            Cellphone = cellPhone;
            BirthDay = birthDay;
            ClientOrigin = clientOrigin;

            Validate();
        }
        public void Activate() => StatusEntity = StatusEntityEnum.Active;
        public void Inactivate() => StatusEntity = StatusEntityEnum.Inactive;

        public Teacher SetResume(string resume)
        {
            Resume = resume;
            return this;
        }

        public Teacher SetEmail(string email)
        {
            Email = email;
            return this;
        }

        public void Validate()
        {
            Assertion.HasValue(Name, "The property Name can't be void");
            Assertion.HasValue(Document, "The property Document can't be void");          
            Assertion.HasValue(Cellphone, "The property CellPhone can't be void");
            Assertion.IsTrue(ClientOrigin != Guid.Empty, "The property ClientOrigin can't be void");
        }
    }
}
