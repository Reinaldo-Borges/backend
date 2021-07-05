using System.Threading.Tasks;

namespace DynamicSchool.Domain.Inteface.UoW
{
    public interface IUnitOfWork
    {
        Task Commit();
    }
}
