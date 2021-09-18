using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsStractural
{
    internal interface ICloth
    {
        void SetBrand(string brand);
        string GetBrand();

        void SetColor(int index);
        Color GetColor();

        void SetSize(int index);
        Size GetSize();

        void SetFabric(int index);
        Fabric GetFabric();

        string ToString();
    }
}
