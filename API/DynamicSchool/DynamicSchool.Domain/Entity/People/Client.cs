using DynamicSchool.Domain.Enum;
using DynamicSchool.Domain.Inteface;
using System;

namespace DynamicSchool.Domain.Entity.People
{
    public abstract class Client : Entity, IAggregateRoot
    {
        protected abstract ClientTypeEnum clientType { get; }
        public string Name { get; private set; }
        public string Document { get; private set; }
        public string Email { get; private set; }
        public string CellPhone { get; private set; }
        public DateTime BirthDate { get; private set; }        


        protected Client(string name, string document, string cellPhone, DateTime birthDate)
        {
      
            Name = name;
            Document = document;           
            CellPhone = cellPhone;
            BirthDate = birthDate;

            Validate();
        }

        public virtual void Activate() => StatusEntity = StatusEntityEnum.Active;
        public virtual void Inactivate() => StatusEntity = StatusEntityEnum.Inactive;

        public Client SetEmail(string email)
        {
            //Validar

            Email = email;
            return this;
        }

        protected virtual void Validate()
        {

        }


    }
}
