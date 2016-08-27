using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shareaton.Data.Models.Nova
{
    public class Source
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public int Classification { get; set; }
        public int LinkedTriangleId { get; set; }
        public int Clearance { get; set; }
        public bool IsFlexible { get; set; }
        public bool HasPermission { get; set; }
    }
}