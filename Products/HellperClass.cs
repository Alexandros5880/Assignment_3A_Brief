using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products
{
    public static class HellperClass
    {
        public static string GenerateID()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
