using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shareaton.Data.Models
{
    public abstract class Share
    {
        public User Owner { get; set; }
        public Node Node { get; set; }
    }
}