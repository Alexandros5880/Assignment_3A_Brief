using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaynmentClasses;

namespace Store
{
    public interface IProduct
    {
        bool AddPaynmentMethod(Paynment paynment);
        bool RemovePaynmentMethod(Paynment paynment);
    }
}
