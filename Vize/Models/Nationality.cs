﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vize.Models
{
    public class Nationality
    {
        public string Name { get; set; }
        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
