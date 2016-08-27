using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shareaton.Data.Models
{
    public class UserShare : Share
    {
        public User SharedUser { get; set; }
    }
}