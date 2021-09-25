using Products.CFSModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products
{
    public class Color : MakeItDisposable
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Hex { get; set; }
    }
}
