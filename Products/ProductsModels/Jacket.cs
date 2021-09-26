﻿using Products.CFS;
using Products.Products;
using Products.Servicies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.ProductsModels
{
    public class Jacket : Clothes
    {
        public static ColorService ColorsService { get; private set; } = new ColorService();
        public static FabricService FabricsService { get; private set; } = new FabricService();
        public Color SelectedColor { get; set; }
        public Fabric SelectedFabric { get; set; }
        public override void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    this.SelectedColor.Dispose();
                    this.SelectedFabric.Dispose();
                    base.Dispose(disposing);
                }
                this.disposedValue = true;
            }
        }
    }
}
