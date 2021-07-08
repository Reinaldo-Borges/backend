using DynamicSchool.Core.Enum;
using System;

namespace DynamicSchool.Domain.Intefaces.Entities
{
    public interface IClient
    {
        public Guid Id { get; set; }
        public string Document { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Cellphone { get; set; }
        public DateTime Birthday { get; set; }
        public ClientTypeEnum ClientTypeId { get; set; }
        public Guid? ClientOrigin { get; set; }
    }
}
