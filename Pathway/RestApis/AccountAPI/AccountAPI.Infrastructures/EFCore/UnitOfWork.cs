﻿using System.Threading.Tasks;
using AccountAPI.Core.Interfaces.Repositories;

namespace AccountAPI.Infrastructures.EFCore
{
    public class UnitOfWork : IUnitOfWork
    {
        private DbFactory _dbFactory;

        public UnitOfWork(DbFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public Task<int> CommitAsync()
        {
            return _dbFactory.DbContext.SaveChangesAsync();
        }
    }

}
