using System;
using System.Threading.Tasks;

namespace AccountAPI.Core.Interfaces.Handlers
{
    public interface IAccountNotificationHandler
    {
        Task<bool> ProcessNotificationAsync(string accountCode);
    }
}
