using DynamicSchool.Core.DomainObjects;
using DynamicSchool.Core.Enum;
using System;

namespace DynamicSchool.Domain.Entities.People
{
    public class Student : Entity
    {
        public string Name { get; private set; }     
        public string Email { get; private set; }
        public string CellPhone { get; private set; }     
        public Guid ClientId { get; private set; }
        public Client Client { get; private set; }

        public Student() { }

        public Student(string name, Guid clientOrigin)
        {
            Name = name;
            ClientId = clientOrigin;

            Validate();
        }

        public Student SetEmail(string email)
        {
            Email = email;
            return this;
        }

        public Student SetCellPhone(string cellPhone)
        {
            CellPhone = cellPhone;
            return this;
        }

        private void Validate()
        {
            Assertion.HasValue(Name, "The property Name can't be void");       
            Assertion.IsTrue(ClientId != Guid.Empty, "The property ClientId can't be void");
        }

        public  void Activate() => StatusEntity = StatusEntityEnum.Active;
        public  void Inactivate() => StatusEntity = StatusEntityEnum.Inactive;
    }
}
