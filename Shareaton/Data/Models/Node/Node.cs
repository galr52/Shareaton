using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shareaton.Data.Models
{
    public abstract class Node
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Location { get; set; }
        public virtual Node Parent { get; set; }
        [Column(TypeName = "DateTime2")]
        public DateTime Creation { get; set; }
        [Column(TypeName = "DateTime2")]
        public DateTime Modify { get; set; }
    }
}