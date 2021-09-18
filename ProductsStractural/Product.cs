using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaynmentsStractural;

namespace ProductsStractural
{
    public abstract class Product
    {
        public string Type { get; set; }
        public int Id { get; set; }

        internal HashSet<Color> Colors { get; set; } = new HashSet<Color>();
        internal HashSet<Size> Sizes { get; set; } = new HashSet<Size>();
        internal HashSet<Fabric> Fabrics { get; set; } = new HashSet<Fabric>();
        internal HashSet<Paynment> Paynments { get; private set; } = new HashSet<Paynment>();
        private Paynment SelectedPaynment { get; set; }

        public Product()
        {
            this.Type = this.GetType().Name;
            this.LoadPaynments();
        }

        public Product(int id)
        {
            this.Id = id;
            this.Type = this.GetType().Name;
            this.LoadPaynments();
        }

        internal virtual void SetPaynment(int index)
        {
            this.SelectedPaynment = this.Paynments.ToList()[index];
        }

        internal virtual Paynment GetPaynment()
        {
            return this.SelectedPaynment;
        }

        internal virtual void LoadPaynments()
        {
            this.Paynments.Add(PaynmentsStractural.GetPaynment.GetPayPal());
            this.Paynments.Add(PaynmentsStractural.GetPaynment.GetDebitCard());
            this.Paynments.Add(PaynmentsStractural.GetPaynment.GetCreditCard());
            this.Paynments.Add(PaynmentsStractural.GetPaynment.GetCash());
            this.Paynments.Add(PaynmentsStractural.GetPaynment.GetWebPaynment());
        }

        public override string ToString()
        {
            if(this.SelectedPaynment != null)
            {
                return $"ID[{this.Id}] --> {this.Type} - {this.SelectedPaynment} ";
            }
            else
            {
                return $"ID[{this.Id}] --> {this.Type} ";
            }
        }
    }
}
