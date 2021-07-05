using DynamicSchool.Core.DomainObjects;
using System;

namespace DynamicSchool.Domain.Entities.People
{
    public class Student : Entity
    {
        public string Name { get; private set; }     
        public string Email { get; private set; }
        public string CellPhone { get; private set; }
        public DateTime BirthDate { get; private set; } 
        public Client Client { get; private set; }

        public Student(string name, DateTime birthDate, Client client)
        {
            Name = name;
            BirthDate = birthDate;        
            Client = client;

            Validate();
        }

        public Student SetEmail(string email)
        {
            Assertion.HasValue(email, "The property Email can't be void");

            Email = email;
            return this;
        }

        public Student SetCellPhone(string cellPhone)
        {
            Assertion.HasValue(cellPhone, "The property CellPhone can't be void");

            CellPhone = cellPhone;
            return this;
        }

        private void Validate()
        {
            Assertion.HasValue(Name, "The property Name can't be void");
            Assertion.IsNotNull(Client, "The Client can't be null");           
        }
    }
}
