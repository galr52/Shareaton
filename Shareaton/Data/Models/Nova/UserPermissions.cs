using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shareaton.Data.Models.Nova
{
    public class UserPermissions
    {
        public int Classification { get; set; }
        public string DisplayName { get; set; }

        public UserTrianglePermissions[] TrianglesAllow { get; set; }
    }
}