using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shareaton.Data.Models
{
    public class Group
    {
        public Guid Id { get; internal set; }
        public string Name { get; set; }
    }
}