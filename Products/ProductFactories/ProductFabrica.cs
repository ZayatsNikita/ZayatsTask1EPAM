using ProductsLib.ProductFactories;
using System;

namespace ProductsLib
{
    /// <summary>
    /// A class containing specific products inside the factory
    /// </summary>
    public static class ProductFabrica
    {
        /// <summary>
        /// Static method for creating specific products
        /// </summary>
        /// <param name="source">parameter that reflects the name of the product</param>
        /// <param name="weight">parameter that reflects the weight of the product</param>
        /// <returns>Product obect</returns>
        /// <exception cref="System.ArgumentException">It is thrown when the factory does not know this product</exception>
        public static Product CreateProduct(string source, double weight)
        {
            switch (source)
            {
                case "Eggs":
                    return EggsFabrica.GetProduct(weight);
                case "Flour":
                    return FlourFabrica.GetProduct(weight);
                case "Meat":
                    return MeatFabrica.GetProduct(weight);
                case "Oil":
                    return OilFabrica.GetProduct(weight);
                case "Salt":
                    return SaltFabrica.GetProduct(weight);
                case "SourCream":
                    return SourСreamFabrica.GetProduct(weight);
                case "Water":
                    return WaterFabrica.GetProduct(weight);
                default:
                    throw new ArgumentException("The specified string is not in the correct format");
            }
        }
    }
}
