using DynamicSchool.Domain.Enum;
using DynamicSchool.Domain.Inteface;
using System;

namespace DynamicSchool.Domain.Entity.People
{
    public class Client : Entity, IAggregateRoot
    {
        public string Name { get; private set; }
        public string Document { get; private set; }
        public string Email { get; private set; }
        public string CellPhone { get; private set; }
        public DateTime BirthDate { get; private set; }
        public bool Status { get; set; }
        public ClientTypeEnum ClientType { get; private set; }


        public Client(ClientTypeEnum clientType, string name, string document, string email, string cellPhone, DateTime birthDate)
        {
            ClientType = clientType;
            Name = name;
            Document = document;
            Email = email;
            CellPhone = cellPhone;
            BirthDate = birthDate;

            Validar();
        }

        public void Activate() => Status = true;
        public void Inactivate() => Status = false;

        public void Validar()
        {

        }


    }
}
