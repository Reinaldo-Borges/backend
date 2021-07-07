using Dapper;
using DynamicSchool.Domain.DTO.People;
using DynamicSchool.Domain.Intefaces.Query.People;
using System;
using System.Data;
using System.Threading.Tasks;

namespace DynamicSchool.Infra.Data.Data.Query.People
{
    public class QueryClient : IQueryClient
    {
        private readonly IDbConnection _connection;
        private readonly IDbTransaction _transaction;
        public QueryClient(IDbConnection connection, IDbTransaction transaction)
        {
            _connection = connection;
            _transaction = transaction;
        }

        public async Task<ClientDTO> GetClientById(Guid id)
        {
            var sql = @"SELECT Id
                              ,ClientDocument as Document
                              ,Name
                              ,Email
                              ,Cellphone
                              ,Birthday
                              ,ClientTypeId
                              ,ClientOrigin
                          FROM Client
                        WHERE Id = @Id";

            var parametros = new { Id = id };

            return await _connection.QueryFirstAsync<ClientDTO>(sql, parametros, _transaction);            
        }
        
        
    }
}
