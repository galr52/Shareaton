using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shareaton.Data.Models
{
    public class User
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Color { get; set; }
        public string UniqueId { get; set; }
        public string Hierarchy { get; set; }
        public virtual Usage Usage { get; set; }
        public DateTime Last_Seen { get; set; }
        // Lazy laoding
        public virtual Folder Root_Folder { get; set; }
        public virtual List<Node> Shared_Nodes { get; set; }
        public virtual List<Node> Groups { get; set; }
    }
}