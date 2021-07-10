using DynamicSchool.Core.Enum;
using DynamicSchool.Domain.Intefaces.Entities;
using System;

namespace DynamicSchool.API.Model.Response
{
    public class ClientRequest : IClient
    {
        public Guid Id { get;  set; }
        public string Document { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Cellphone { get; set; }
        public DateTime Birthday { get; set; }
        public ClientTypeEnum ClientTypeId { get; set; }
        public Guid? ClientOrigin { get; set; }        
        public DateTime DataCriacao { get; set; }
        public bool StatusEntity { get; set; }

    }
}
