﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shareaton.Data.Models
{
    public class File : Node
    {
        public int Size { get; set; }
        public string Type { get; set; }
    }
}