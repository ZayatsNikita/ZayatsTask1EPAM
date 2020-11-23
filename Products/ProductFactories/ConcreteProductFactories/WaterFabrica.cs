using ProductsLib.ModelsOfProduct;

namespace ProductsLib.ProductFactories
{
    /// <summary>
    /// Factory class that creates Water
    /// </summary>
    class WaterFabrica : IProductFabrica
    {
        /// <summary>
        /// Creates a Water object with the specified weight
        /// </summary>
        /// <param name="weight">weight assigned to the product</param>
        /// <returns>Water</returns>
        /// <exception cref="System.ArgumentException">Throw if weight little then 0</exception>
        public static Product GetProduct(double weight)
        {
            return new Water() { ProductWeight = weight };
        }
    }
}
