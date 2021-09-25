using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Products.CFS;
using Products.CFSModels;

namespace Products.Servicies
{
    public class FabricService : MakeItDisposable, ICreateService<Fabric>
    {
        public List<Fabric> Fabrics { get; private set; } = new List<Fabric>();
        public Fabric Create()
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
            fabric.Dispose();
            return this.Fabrics.Any(s => s.Id == fabric.Id) ? false : true;
        }
        public override void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    this.Fabrics.ForEach(f => f.Dispose());
                    this.Fabrics.Clear();
                    this.Fabrics = null;
                    base.Dispose(disposing);
                }
                this.disposedValue = true;
            }
        }
    }
}
