using System;
namespace ProductsLib.ProductFactories
{
    interface IProductFabrica
    {
        public static IProduct GetProduct(double weight) => throw new NullReferenceException(); 
    }
}
