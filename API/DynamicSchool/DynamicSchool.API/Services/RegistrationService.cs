using DynamicSchool.API.Interfaces;
using DynamicSchool.Domain.Entities.Registrations;
using DynamicSchool.Domain.Inteface.UoW;
using System.Threading.Tasks;

namespace DynamicSchool.API.Services
{
    public class RegistrationService : IRegistrationService
    {
        private readonly IUnitOfWork _unitOfWork;

        public RegistrationService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task Add(Registration registration)
        {
            await _unitOfWork.RegistrationRepository.Add(registration);
            _unitOfWork.Commit();
        }
    }
}
