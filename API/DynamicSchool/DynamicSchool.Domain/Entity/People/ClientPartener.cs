using DynamicSchool.Domain.Enum;
using System;

namespace DynamicSchool.Domain.Entity.People
{
    public class ClientPartener : Client
    {
        protected override ClientTypeEnum clientType => ClientTypeEnum.Partener;

        public ClientPartener(string name, string document, string cellPhone, DateTime birthDate) 
            : base(name, document, cellPhone, birthDate)
        {
        }


    }
}
