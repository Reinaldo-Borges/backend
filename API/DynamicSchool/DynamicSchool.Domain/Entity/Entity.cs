using DynamicSchool.Domain.Enum;
using System;

namespace DynamicSchool.Domain.Entity
{
    public abstract class Entity
    {
        public Guid Id { get; protected set; }
        public DateTime DataCriacao { get; set; }
        public StatusEntityEnum StatusEntity { get; set; }

        protected Entity()
        {
            Id = Guid.NewGuid();
        }
    }
}
