using System;
namespace ProductsLib.ProductFactories
{
    interface IProductFabrica
    {
        public static Product GetProduct(double weight) => throw new NullReferenceException(); 
    }
}
