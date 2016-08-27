using Shareaton.Data.Models;
using Shareaton.Data.Models.Nova;
using System.Data.Entity;

namespace Shareaton.Data.DAL.SqlServer
{
    public class DbAccess : DbContext
    {
        public DbSet<Node> Nodes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Source> NoveSource { get; set; }
        public DbAccess()
            : base("SheratonConnectionString")
        // : base("DebugDB")
        {
        }
    }
}