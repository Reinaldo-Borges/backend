using System.Collections.Generic;

namespace DynamicSchool.Domain.Entities.People
{
    public class ClientType
    {
        public short Id { get; set; }
        public string Description { get; set; }
   
        public ICollection<Client> Clients { get; } = new List<Client>();
    }
}
