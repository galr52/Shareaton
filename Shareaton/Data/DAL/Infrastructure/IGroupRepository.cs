using System;
using Shareaton.Data.Models;

namespace Shareaton.Data.DAL.Infrastructure
{
    public interface IGroupRepository : IGenericRepository<Group>
    {
        Group GetSingle(Guid id);
    }
}
