using Dapper;
using DynamicSchool.Domain.DTO.People;
using DynamicSchool.Domain.Entities.People;
using DynamicSchool.Domain.Inteface.Script.Query.People;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicSchool.Infra.Data.Data.Query.People
{
    public class QueryStudent : IQueryStudent
    {
        private readonly IDbConnection _connection;
        private readonly IDbTransaction _transaction;
        public QueryStudent(IDbConnection connection, IDbTransaction transaction)
        {
            _connection = connection;
            _transaction = transaction;
        }

        public async Task<StudentDTO> GetStudentById(Guid id)
        {
            var sql = @"SELECT
                            Id,
                            TipoEvento,
                            Mensagem,
                            DataCriacao,
                            DataEvento,
                            IdentificadorEvento,
                            IdentificadorEventoOrigem,
                            IdentificadorCorrelacao
                        FROM Evento
                            WHERE IdentificadorEvento = @IdentificadorEvento";

            var parametros = new { Id= id };

            return await _connection.QueryFirstAsync<StudentDTO>(sql, parametros, _transaction);
        }
    }
}
