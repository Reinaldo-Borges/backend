﻿using DynamicSchool.Domain.Inteface.Repository;
using DynamicSchool.Domain.Inteface.UoW;
using DynamicSchool.Infra.Data.infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicSchool.Infra.Data.infrastructure.UoW
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly IDbConnection _context;
        private IDbTransaction _transaction;

        public UnitOfWork(IDbConnection context)
        {
            _context = context;            
        }

        private IPeopleRepository _peopleRepository;
        public IPeopleRepository PeopleRepository
        {
            get => _peopleRepository ?? (_peopleRepository = new PeopleRepository(_context, _transaction));
        }

        public IDisposable BeginTransaction()
        {
            _transaction?.Dispose();

            if (_context.State != ConnectionState.Open)
                _context.Open();

            _transaction = _context.BeginTransaction(IsolationLevel.ReadCommitted);

            return this;
        }

        public void Commit()
        {
            _transaction?.Commit();
        }

        public void Dispose()
        {
            if (_transaction != null)
            {
                _transaction.Dispose();
                _transaction = null;
            }
        }

        public void RollBack()
        {
            _transaction?.Rollback();
        }
    }
}
