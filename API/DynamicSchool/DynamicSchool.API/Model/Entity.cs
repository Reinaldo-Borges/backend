using DynamicSchool.Core.Enum;
using System;


namespace DynamicSchool.API.Model
{
    public class Entity
    {
        public Guid Id { get; protected set; }
        public DateTime DataCriacao { get; protected set; }
        public StatusEntityEnum StatusEntity { get; set; }
    }
}
