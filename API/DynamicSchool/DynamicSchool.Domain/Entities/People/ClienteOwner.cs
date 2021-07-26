using DynamicSchool.Core.Enum;
using System;

namespace DynamicSchool.Domain.Entities.People
{
    public class ClienteOwner : Client
    { 
        public override ClientTypeEnum clientType => ClientTypeEnum.Owner;

       
        public ClienteOwner(string name, string document, string cellPhone, DateTime birthDate) 
            : base(name, document, cellPhone, birthDate)
        {

        }
    }
}
