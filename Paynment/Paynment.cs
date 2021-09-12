using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public abstract class Paynment : IPaynment
    {
        public string Type { get; protected set; }
        public Paynment()
        {
            this.Type = this.GetType().Name;
        }
        public override string ToString()
        {
            return this.Type;
        }
    }
}
