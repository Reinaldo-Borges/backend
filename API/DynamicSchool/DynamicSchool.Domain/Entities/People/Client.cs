using DynamicSchool.Core.DomainObjects;
using DynamicSchool.Core.Enum;
using DynamicSchool.Domain.Inteface;
using System;

namespace DynamicSchool.Domain.Entities.People
{
    public abstract class Client : Entity, IAggregateRoot
    {
        protected abstract ClientTypeEnum clientType { get; }
        public string Name { get; private set; }
        public string Document { get; private set; }
        public string Email { get; private set; }
        public string Cellphone { get; private set; }
        public DateTime Birthday { get; private set; }    
       


        protected Client(string name, string document, string cellPhone, DateTime birthDate)
        {
      
            Name = name;
            Document = document;           
            Cellphone = cellPhone;
            Birthday = birthDate;

            Validate();
        }

        public virtual void Activate() => StatusEntity = StatusEntityEnum.Active;
        public virtual void Inactivate() => StatusEntity = StatusEntityEnum.Inactive;

        public Client SetEmail(string email)
        {
            Assertion.HasValue(email, "The property Email can't be void");

            Email = email;
            return this;
        }

        protected virtual void Validate()
        {
            Assertion.HasValue(Name, "The property Name can't be void");
            Assertion.HasValue(Document, "The property Document can't be void");
            Assertion.HasValue(Cellphone, "The property can't be void");   
    

        }


    }
}
