using DynamicSchool.API.Interfaces;
using DynamicSchool.Domain.DTO.People;
using DynamicSchool.Domain.Inteface.UoW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DynamicSchool.API.Services
{
    public class PeopleService : IPeopleService
    {
        private readonly IUnitOfWork _unitOfWork;

        public PeopleService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
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
    }
}
