using System;

namespace DynamicSchool.Domain.Entity.People
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
    }
}
