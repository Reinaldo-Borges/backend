using DynamicSchool.Core.Enum;
using System;

namespace DynamicSchool.Core.DomainObjects
{
    public abstract class Entity
    {
        public Guid Id { get; protected set; }
        public DateTime CreationDate { get;  set; }
        public StatusEntityEnum StatusEntity { get; set; }

        protected Entity()
        {
            Id =  Guid.NewGuid();
            CreationDate = new DateTime();
        }  


    }
}
