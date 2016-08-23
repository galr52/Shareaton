using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shareaton.Models
{
    public abstract class Node
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public virtual Node Parent { get; set; }
        public DateTime Creation { get; set; }
        public DateTime Modify { get; set; }
    }
}