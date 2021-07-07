using DynamicSchool.Domain.DTO.People;
using System;
using System.Threading.Tasks;

namespace DynamicSchool.Domain.Inteface.Script.Query.People
{
    public interface IQueryStudent
    {
        Task<StudentDTO> GetStudentById(Guid id);
    }
}
