using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AccountAPI.Core.Domains;
using Microsoft.EntityFrameworkCore;

namespace AccountAPI.Infrastructure.Repositories
{
    interface IApplicationDbContext
    {
        DbSet<Account> Accounts { get; set; }
        
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
