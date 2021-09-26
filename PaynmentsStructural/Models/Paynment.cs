using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PaynmentsStractural
{
    public abstract class Paynment : IPaynment
    {
        public string Type { get; protected set; }
        internal static List<System.Type> All { get; private set; } = typeof(Paynment).Assembly.GetTypes().Where(type => type.IsSubclassOf(typeof(Paynment)) && !type.IsAbstract).ToList();
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
