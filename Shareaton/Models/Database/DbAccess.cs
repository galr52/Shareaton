using Shareaton.Models.Nova;
using System.Data.Entity;

namespace Shareaton.Models.Database
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