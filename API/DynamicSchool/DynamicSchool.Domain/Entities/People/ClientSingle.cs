using DynamicSchool.Core.DomainObjects;
using DynamicSchool.Core.Enum;
using System;

namespace DynamicSchool.Domain.Entities.People
{
    public class ClientSingle : Client
    {
        protected override ClientTypeEnum clientType => ClientTypeEnum.Simple;
        public Client ClientOriginal { get; private set; }
       

        public ClientSingle(Client clientOriginal, string name, string document, string cellPhone, DateTime birthDate) 
            : base(name, document, cellPhone, birthDate)
        {
            Validate();
        }    

        protected override void Validate()
        {
            Assertion.IsNotNull(ClientOriginal, "The ClientOriginal cant be null");
        }


    }
}
