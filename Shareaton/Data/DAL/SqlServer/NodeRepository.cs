using Shareaton.Data.DAL.Infrastructure;
using Shareaton.Data.Models;
using System;
using System.Linq;

namespace Shareaton.Data.DAL.SqlServer
{
    public class NodeRepository : GenericRepository<DbAccess, Node>, INodeRepository
    {
        public Node GetSingle(Guid id)
        {
            var query = Context.Nodes.FirstOrDefault(x => x.Id == id);
            return query;
        }
    }
}