using Dapper;
using DynamicSchool.Domain.Entities.People;
using System;
using System.Data;
using System.Threading.Tasks;

namespace DynamicSchool.Infra.Data.Data.Command.People
{
    public class CommandClient 
    {
        private readonly IDbConnection _connection;
        private readonly IDbTransaction _transaction;

        public CommandClient(IDbConnection connection, IDbTransaction transaction)
        {
            _connection = connection;
            _transaction = transaction;
        }

        public async Task Add(Client client)
        {
            var sql = @"INSERT INTO dbo.Client
                               (Id, ClientDocument, Name, Email, Cellphone, Birthday, ClientTypeId, ClientOrigin)
                         VALUES
                               (@Id, @ClientDocument, @Name, @Email, @Cellphone, @Birthday, @ClientTypeId, @ClientOrigin)";

            var parametros = new {
                Id = client.Id,
                ClientDocument = client.Document,
                Name = client.Name,
                Email = client.Email,
                CellPhone = client.Cellphone,
                Birthday = client.Birthday,
                ClientTypeId = client.Type,
                ClientOrigin = client.ClientOrigin
            };

            _connection.Execute(sql, parametros, _transaction);
        }

        public async Task Modify(Client client)
        {
            var sql = @"UPDATE Client
                               set ClientDocument = @ClientDocument, 
                                   Name =  @Name, 
                                   Email = @Email, 
                                   Cellphone = @Cellphone, 
                                   Birthday = @Birthday
                        WHERE Id = @Id";

            var parametros = new
            {
                Id = client.Id,
                ClientDocument = client.Document,
                Name = client.Name,
                Email = client.Email,
                CellPhone = client.Cellphone,
                Birthday = client.Birthday,
                Status = client.StatusEntity
            };

            _connection.Execute(sql, parametros, _transaction);
        }

        public async Task ChangeStatus(Guid id, bool status)
        {
            var sql = @"UPDATE Client
                               set Status = @Status
                        WHERE Id = @Id";

            //Fazer uma tabela historico do status

            var parametros = new
            {
                Status = status,
                Id = id
            };

            _connection.Execute(sql, parametros, _transaction);
        }

    }
}
