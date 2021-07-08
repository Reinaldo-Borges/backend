using DynamicSchool.Domain.Entities.People;
using DynamicSchool.Domain.Intefaces.Entities;

namespace DynamicSchool.Domain.Factories
{
    public interface IClientFactory
    {
        Client Buider(IClient client);
    }
}
