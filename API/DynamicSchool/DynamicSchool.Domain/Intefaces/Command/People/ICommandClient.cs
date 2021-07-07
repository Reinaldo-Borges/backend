using DynamicSchool.Domain.Entities.People;
using System.Threading.Tasks;

namespace DynamicSchool.Domain.Intefaces.Command.People
{
    public interface ICommandClient
    {
        Task Add(Client client);
    }
}
