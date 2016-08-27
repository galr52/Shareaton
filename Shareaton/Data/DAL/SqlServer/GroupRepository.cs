using Shareaton.Data.DAL.Infrastructure;
using Shareaton.Data.Models;
using System;
using System.Linq;

namespace Shareaton.Data.DAL.SqlServer
{
    public class GroupRepository : GenericRepository<DbAccess, Group>, IGroupRepository
    {
        public Group GetSingle(Guid id)
        {
            var query = Context.Groups.FirstOrDefault(x => x.Id == id);
            return query;
        }
    }
}