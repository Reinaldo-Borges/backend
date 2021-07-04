using DynamicSchool.Domain.Enum;
using System;

namespace DynamicSchool.Domain.Entity.People
{
    public class ClientSingle : Client
    {
        protected override ClientTypeEnum clientType => ClientTypeEnum.Single;
        public Client ClientOriginal { get; private set; }
       

        public ClientSingle(Client clientOriginal, string name, string document, string cellPhone, DateTime birthDate) 
            : base(name, document, cellPhone, birthDate)
        {
            Validate();
        }    

        protected override void Validate()
        {
        }


    }
}
