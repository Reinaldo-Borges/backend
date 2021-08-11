using DynamicSchool.Core.Enum;
using System;

namespace DynamicSchool.Domain.Entities.People
{
    public class ClientPartener : Client
    {
        public override ClientTypeEnum Type => ClientTypeEnum.Partener;

        public ClientPartener(string name, string document, string cellPhone, DateTime birthDate) 
            : base(name, document, cellPhone, birthDate)
        {
        }
    }
}
