using DynamicSchool.Core.DomainObjects;
using DynamicSchool.Core.Enum;
using System;

namespace DynamicSchool.Domain.Entities.People
{
    public class ClientSimple : Client
    {
        public override ClientTypeEnum clientType => ClientTypeEnum.Simple; 

        public ClientSimple(Guid clientOrigin, string name, string document, string cellPhone, DateTime birthDate) 
            : base(name, document, cellPhone, birthDate)
        {
            ClientOrigin = clientOrigin;

            Validate();
        }    

        protected override void Validate()
        {
            Assertion.IsNotNull(ClientOrigin, "The ClientOriginal cant be null");
        }




    }
}
