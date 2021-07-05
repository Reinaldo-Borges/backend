using DynamicSchool.Domain.Inteface.UoW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicSchool.Infra.Data.infrastructure.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        public Task Commit()
        {
            throw new NotImplementedException();
        }
    }
}
