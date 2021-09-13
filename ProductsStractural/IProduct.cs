using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaynmentsStractural;

namespace ProductsStractural
{
    public interface IProduct
    {
        bool AddPaynmentMethod(Paynment paynment);
        bool RemovePaynmentMethod(Paynment paynment);
    }
}
