using DynamicSchool.Core.DomainObjects;
using DynamicSchool.Core.Enum;
using DynamicSchool.Domain.Inteface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DynamicSchool.Domain.Entities.People
{
    public class Client : Entity, IAggregateRoot
    {
        [NotMapped]
        public virtual ClientTypeEnum Type { get; }
        public string Name { get; private set; }
        public string Document { get; private set; }
        public string Email { get; private set; }
        public string Cellphone { get; private set; }
        public DateTime Birthday { get; private set; }
        public Guid? ClientOrigin { get; protected set; }
       // public ICollection<Teacher> Teachers { get; } = new List<Teacher>();

        public virtual short ClientTypeId { get; set; }        

        public virtual ClientType ClientType { get; set; }

        protected Client() { ClientTypeId = ((short)Type); }

        protected Client(string name, string document, string cellPhone, DateTime birthDate)
        {
            ClientTypeId = ((short)Type);

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

        private void Validate()
        {
            Assertion.HasValue(Name, "The property Name can't be void");
            Assertion.HasValue(Document, "The property Document can't be void");
            Assertion.HasValue(Cellphone, "The property can't be void");       

        }
    }
}
