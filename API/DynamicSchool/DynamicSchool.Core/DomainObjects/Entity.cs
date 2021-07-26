using DynamicSchool.Core.Enum;
using System;

namespace DynamicSchool.Core.DomainObjects
{
    public abstract class Entity
    {
        public Guid Id { get; protected set; }
        public DateTime CreationDate { get;  set; }
        public virtual StatusEntityEnum StatusEntity { get; set; }

        protected Entity()
        {
            Id =  Guid.NewGuid();
            CreationDate = new DateTime();
        }   
        
        public T SetId<T>(Guid id) where T : Entity
        {
            if (id != Guid.Empty) Id = id;
            return this as T;
        }

    }
}
