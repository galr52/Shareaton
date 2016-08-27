using Shareaton.Data.DAL.Infrastructure;
using Shareaton.Data.Models;
using System;
using System.Linq;

namespace Shareaton.Data.DAL.SqlServer
{
    public class UserRepository : GenericRepository<DbAccess, User>, IUserRepository
    {
        public User GetSingle(Guid id)
        {
            var query = Context.Users.FirstOrDefault(x => x.Id == id);
            return query;
        }
    }
}