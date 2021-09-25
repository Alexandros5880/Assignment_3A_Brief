using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Products.CFS;

namespace Products.Servicies
{
    public class FabricService : ICreateService<Fabric>
    {
        public List<Fabric> Fabrics { get; private set; } = new List<Fabric>();
        public Fabric CreateProduct()
        {
            Fabric fabric = new Fabric();
            fabric.Id = HellperClass.GenerateID();
            return fabric;
        }
        public bool Save(Fabric fabric)
        {
            this.Fabrics.Add(fabric);
            return this.Fabrics.Any(s => s.Id == fabric.Id);
        }
        public bool Remove(Fabric fabric)
        {
            this.Fabrics.Remove(fabric);
            return this.Fabrics.Any(s => s.Id == fabric.Id) ? false : true;
        }
    }
}
