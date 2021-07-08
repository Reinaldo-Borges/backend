using DynamicSchool.API.Interfaces;
using DynamicSchool.Domain.DTO.People;
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
            using (_unitOfWork.BeginTransaction())
            {
                var client = await _unitOfWork.PeopleRepository.GetClientById(id);
                _unitOfWork.Commit();

                return client;
            }            
        }

        public async Task Add(IClient client)
        {
            var clientBuilt = _factory.Buider(client);

            using (_unitOfWork.BeginTransaction())
            {
                await _unitOfWork.PeopleRepository.Add(clientBuilt);
                _unitOfWork.Commit();            
            }
        }
    }
}
