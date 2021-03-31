using System.Threading;
using System.Threading.Tasks;
using AccountAPI.Core.Domains.Entities;
using Microsoft.EntityFrameworkCore;

namespace AccountAPI.Infrastructures.EFCore
{
    interface IApplicationDbContext
    {
        DbSet<Account> Accounts { get; set; }
        
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
