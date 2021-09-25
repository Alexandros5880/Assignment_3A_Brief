using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Products.Products;

namespace Products
{
    public interface ICreateService<T> where T : class
    {
        T CreateProduct();
        bool Save(T product);
        bool Remove(T product);
    }
}
