using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shareaton.Models
{
    public class User
    {
        public Guid Id { get; set; } = Guid.NewGuid();
    }
}