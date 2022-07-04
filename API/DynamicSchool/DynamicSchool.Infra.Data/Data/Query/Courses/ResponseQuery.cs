using Dapper;
using DynamicSchool.Domain.DTO.Course;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace DynamicSchool.Infra.Data.Data.Query.Courses
{
    public class ResponseQuery
    {
        private readonly IDbConnection _connection;
        private readonly IDbTransaction _transaction;

        public ResponseQuery(IDbConnection connection, IDbTransaction transaction)
        {
            _connection = connection;
            _transaction = transaction;
        }

        public async Task<IEnumerable<ResponseDTO>> List(Guid questionId)
        {
            var sql = @"select 	                        
	                        r.Id,
	                        r.Description,
	                        r.IsTrue,
	                        r.NumberOrder,
	                        r.Reason,
                            r.CreationDate,
                            r.QuestionId
                        from Response r  
                        where r.QuestionId = @Id
                        order by r.CreationDate desc";

            var parametros = new
            {
                Id = questionId
            };

            return await _connection.QueryAsync<ResponseDTO>(sql, parametros, _transaction);
        }
    }
}
