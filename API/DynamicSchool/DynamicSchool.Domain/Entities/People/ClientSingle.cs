using DynamicSchool.Core.DomainObjects;
using DynamicSchool.Core.Enum;
using System;

namespace DynamicSchool.Domain.Entities.People
{
    public class ClientSimple : Client
    {
        protected override ClientTypeEnum clientType => ClientTypeEnum.Simple;
        public Client ClientOrigin { get; private set; }
       

        public ClientSimple(Client clientOriginal, string name, string document, string cellPhone, DateTime birthDate) 
            : base(name, document, cellPhone, birthDate)
        {
            Validate();
        }    

        protected override void Validate()
        {
            Assertion.IsNotNull(ClientOrigin, "The ClientOriginal cant be null");
        }


    }
}
