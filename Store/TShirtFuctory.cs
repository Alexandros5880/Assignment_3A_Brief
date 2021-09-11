using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class TShirtFuctory : ProductFuctory
    {
        public override Product GetProduct()
        {
            Color color = new Color(1, "Green", "#23FF00");
            Size size = new Size(1, "M");
            Fabric fabric = new Fabric(1,"WOOL");
            return new TShirt("NOTYCA", color, size, fabric);
        }
    }
}
