using System;
namespace ProductsLib.ProductFactories
{
    /// <summary>
    /// Interface for creating Products
    /// </summary>
    interface IProductFabrica
    {
        /// <summary>
        /// a method that creates Products objects and is intended for implementation in other classes
        /// </summary>
        /// <param name="weight">Parameter that reflects the weight set for the product</param>
        /// <returns>Product</returns>
        public static Product GetProduct(double weight) => throw new NullReferenceException(); 
    }
}
