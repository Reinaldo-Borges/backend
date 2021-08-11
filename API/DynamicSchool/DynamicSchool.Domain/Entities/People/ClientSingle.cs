using DynamicSchool.Core.DomainObjects;
using DynamicSchool.Core.Enum;
using System;

namespace DynamicSchool.Domain.Entities.People
{
    public class ClientSimple : Client
    {
        public override ClientTypeEnum Type => ClientTypeEnum.Simple; 

        public ClientSimple(Guid clientOrigin, string name, string document, string cellPhone, DateTime birthDate) 
            : base(name, document, cellPhone, birthDate)
        {
            ClientOrigin = clientOrigin;

            Validate();
        }    

        private void Validate()
        {
            Assertion.IsNotNull(ClientOrigin, "The ClientOrigin can't be null");
        }




    }
}
