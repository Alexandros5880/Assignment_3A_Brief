﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    class Size
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Size(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}