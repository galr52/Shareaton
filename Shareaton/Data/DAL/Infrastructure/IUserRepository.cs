using System;
using Shareaton.Data.Models;

namespace Shareaton.Data.DAL.Infrastructure
{
    public interface IUserRepository : IGenericRepository<User>
    {
        User GetSingle(Guid id);
    }
}
