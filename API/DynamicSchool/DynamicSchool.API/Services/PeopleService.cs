using DynamicSchool.API.Interfaces;
using DynamicSchool.Core.Enum;
using DynamicSchool.Domain.DTO.People;
using DynamicSchool.Domain.Entities.People;
using DynamicSchool.Domain.Factories;
using DynamicSchool.Domain.Inteface.UoW;
using DynamicSchool.Domain.Intefaces.Entities;
using System;
using System.Threading.Tasks;

namespace DynamicSchool.API.Services
{
    public class PeopleService : IPeopleService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IClientFactory _factory;

        public PeopleService(IUnitOfWork unitOfWork, IClientFactory factory)
        {
            _unitOfWork = unitOfWork;
            _factory = factory;
        }

        public async Task<ClientDTO> GetClientById(Guid id)
        {
            var client = await _unitOfWork.PeopleRepository.GetClientById(id);
            _unitOfWork.Commit();

            return client;                        
        }

        public async Task Add(IClient client)
        {
            var clientBuilt = _factory.Buider(client);

            await _unitOfWork.PeopleRepository.Add(clientBuilt);
            _unitOfWork.Commit();

        }

        public async Task Modify(IClient client)
        {
            var clientBuilt = _factory.Buider(client);

            await _unitOfWork.PeopleRepository.Modify(clientBuilt);
            _unitOfWork.Commit();
        }

        public async Task ChangeStatus(Guid id, bool status)
        {

            //await _unitOfWork.PeopleRepository.ChangeStatus(id, status);
            //_unitOfWork.Commit();

        }

        public async Task Add(Teacher teacher)
        {
            await _unitOfWork.PeopleRepository.Add(teacher);
            _unitOfWork.Commit();
        }

        public async Task Add(Student student)
        {
            await _unitOfWork.PeopleRepository.Add(student);
            _unitOfWork.Commit();
        }
    }
}
