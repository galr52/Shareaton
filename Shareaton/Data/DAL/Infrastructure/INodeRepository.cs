using System;
using Shareaton.Data.Models;

namespace Shareaton.Data.DAL.Infrastructure
{
    public interface INodeRepository : IGenericRepository<Node>
    {
        Node GetSingle(Guid id);
    }
}
