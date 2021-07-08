using Dapper;
using DynamicSchool.Domain.Entities.People;
using DynamicSchool.Domain.Intefaces.Command.People;
using System.Data;
using System.Threading.Tasks;

namespace DynamicSchool.Infra.Data.Data.Command.People
{
    public class CommandClient : ICommandClient
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
                ClientTypeId = client.clientType,
                ClientOrigin = client.ClientOrigin
            };

            _connection.Execute(sql, parametros, _transaction);
        }    
    }
}
