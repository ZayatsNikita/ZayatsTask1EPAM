﻿using ProductsLib.ModelsOfProduct;

namespace ProductsLib.ProductFactories
{
    class FlourFabrica : IProductFabrica
    {
        public static IProduct GetProduct(double weight)
        {
            return new Flour() {ProductWeight=weight };
        }
    }
}
