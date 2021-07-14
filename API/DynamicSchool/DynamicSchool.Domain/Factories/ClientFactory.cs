using DynamicSchool.Core.DomainObjects;
using DynamicSchool.Core.Enum;
using DynamicSchool.Domain.Entities.People;
using DynamicSchool.Domain.Intefaces.Entities;

namespace DynamicSchool.Domain.Factories
{
    public class ClientFactory : IClientFactory
    {
        public Client Buider(IClient client)
        {
            switch (client.ClientTypeId)
            {
                case ClientTypeEnum.Owner :
                    return new ClienteOwner(client.Name, client.Document, client.Cellphone, client.Birthday)
                        .SetId<ClienteOwner>(client.Id)
                        .SetEmail(client.Email);                        
                case ClientTypeEnum.Partener :
                    return new ClientPartener(client.Name, client.Document, client.Cellphone, client.Birthday)
                        .SetId<ClientPartener>(client.Id)
                        .SetEmail(client.Email);
                case ClientTypeEnum.Simple :
                    return new ClientSimple(client.ClientOrigin.Value, client.Name, client.Document, client.Cellphone, client.Birthday)
                        .SetId<ClientSimple>(client.Id)
                        .SetEmail(client.Email);
                default:
                    throw new DomainException("There is not such type of client");                     
            }
        }
    }
}
