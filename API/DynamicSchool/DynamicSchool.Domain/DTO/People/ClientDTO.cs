using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicSchool.Domain.DTO.People
{
    public class ClientDTO
    {
        public Guid Id { get; set; }
        public string Document { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Cellphone { get; set; }
        public DateTime Birthday { get; set; }
        public int ClientTypeId { get; set; }
        //public Guid ClientOrigin { get; set; }
    }
}
