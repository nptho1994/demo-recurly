using System;
using Microsoft.EntityFrameworkCore;

namespace AccountAPI.Infrastructures.EFCore
{
    public class DbFactory : IDisposable
    {
        private bool disposed;
        private Func<ApplicationDbContext> instanceFunc;
        private DbContext dbContext;
        public DbContext DbContext => dbContext ??= instanceFunc.Invoke();

        public DbFactory(Func<ApplicationDbContext> dbContextFactory)
        {
            instanceFunc = dbContextFactory;
        }

        public void Dispose()
        {
            if (!disposed && dbContext != null)
            {
                disposed = true;
                dbContext.Dispose();
            }
        }
    }

}
