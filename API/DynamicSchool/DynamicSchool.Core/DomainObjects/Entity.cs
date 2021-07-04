using DynamicSchool.Core.Enum;
using System;

namespace DynamicSchool.Core.DomainObjects
{
    public abstract class Entity
    {
        public Guid Id { get; protected set; }
        public DateTime DataCriacao { get; protected set; }
        public StatusEntityEnum StatusEntity { get; set; }

        protected Entity()
        {
            Id = Guid.NewGuid();
            DataCriacao = new DateTime();
        }  


    }
}
