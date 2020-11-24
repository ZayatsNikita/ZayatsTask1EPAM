using ProductsLib.ModelsOfProduct;

namespace ProductsLib.ProductFactories
{
    /// <summary>
    /// Factory class that creates Oil
    /// </summary>
    internal class OilFabrica : IProductFabrica
    {
        /// <summary>
        /// Creates a Oil object with the specified weight
        /// </summary>
        /// <param name="weight">weight assigned to the product</param>
        /// <returns>Oil</returns>
        /// <exception cref="System.ArgumentException">Throw if weight little then 0</exception>
        public static Product GetProduct(double weight)
        {
            return new Oil(weight);
        }
    }
}
