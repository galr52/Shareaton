using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shareaton.Data.Models
{
    public class GroupShare : Share
    {
        public Group SharedGroup { get; set; }
    }
}