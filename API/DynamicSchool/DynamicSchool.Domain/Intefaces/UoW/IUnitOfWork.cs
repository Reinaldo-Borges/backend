using DynamicSchool.Domain.Inteface.Repository;
using System;

namespace DynamicSchool.Domain.Inteface.UoW
{
    public interface IUnitOfWork
    {
        IPeopleRepository PeopleRepository { get; }

        IDisposable BeginTransaction();
        void Commit();
        void RollBack();

    }
}
