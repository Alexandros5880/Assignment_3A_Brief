using PaynmentsStractural;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsStractural
{
    public enum ColorValues { RED, ORANGE, YELLOW, GREEN, BLUE, INDIGO, VIOLET }
    public enum SizeValues { XXXS, XXS, XS, S, M, L, XL, XXL, XXXL }
    public enum FabricValues { WOOL, COTTON, POLYESTER, RAYON, LINEN, CASHMERE, SILK }
    public enum ProductPaynments { PAYPAL, DEBITCARD, CREDITCARD, CASH, WEBPAYNMENT }

    public class ProductGenerator
    {
        public Product CreateTShirt(int id, string brand)
        {
            return new TShirt(id);
        }

        public void SetBrand(Product product, string brand)
        {
            switch (product.Type)
            {
                case "TShirt":
                    ((Cloth)product).SetBrand(brand);
                    break;
                case "Cloth":
                    ((Cloth)product).SetBrand(brand);
                    break;
                default:
                    break;
            }
        }
        public string GetBrand(Product product)
        {
            switch (product.Type)
            {
                case "TShirt":
                    return ((Cloth)product).GetBrand();
                case "Cloth":
                    return ((Cloth)product).GetBrand();
                default:
                    return "";
            }
        }

        public void SetColor(Product product, int index)
        {
            switch(product.Type)
            {
                case "TShirt":
                    ((Cloth)product).SetColor(index);
                    break;
                case "Cloth":
                    ((Cloth)product).SetColor(index);
                    break;
                default:
                    break;
            }
        }
        public Dictionary<string, string> GetColor(Product product)
        {
            switch (product.Type)
            {
                case "TShirt":
                    Color color = ((Cloth)product).GetColor();
                    Dictionary<string, string> c_dict = new Dictionary<string, string>();
                    c_dict.Add(color.Name, color.Hex);
                    return c_dict;
                case "Cloth":
                    color = ((Cloth)product).GetColor();
                    c_dict = new Dictionary<string, string>();
                    c_dict.Add(color.Name, color.Hex);
                    return c_dict;
                default:
                    return null;
            }
        }

        public void SetSize(Product product, int index)
        {
            switch (product.Type)
            {
                case "TShirt":
                    ((Cloth)product).SetSize(index);
                    break;
                case "Cloth":
                    ((Cloth)product).SetSize(index);
                    break;
                default:
                    break;
            }
        }
        public string GetSize(Product product)
        {
            switch (product.Type)
            {
                case "TShirt":
                    return ((Cloth)product).GetSize().Name;
                case "Cloth":
                    return ((Cloth)product).GetSize().Name;
                default:
                    return "";
            }
        }

        public void SetFabric(Product product, int index)
        {
            switch (product.Type)
            {
                case "TShirt":
                    ((Cloth)product).SetFabric(index);
                    break;
                case "Cloth":
                    ((Cloth)product).SetFabric(index);
                    break;
                default:
                    break;
            }
        }
        public string GetFabric(Product product)
        {
            switch (product.Type)
            {
                case "TShirt":
                    return ((Cloth)product).GetFabric().Name;
                case "Cloth":
                    return ((Cloth)product).GetFabric().Name;
                default:
                    return "";
            }
        }

        public void SetPaynment(Product product, int index)
        {
            product.SetPaynment(index);
        }
        public string GetPaynment(Product product)
        {
            return ((Cloth)product).GetPaynment().ToString();
        }

    }
}
