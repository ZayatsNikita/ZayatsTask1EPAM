using ProductsLib.ModelsOfProduct;

namespace ProductsLib.ProductFactories
{
    /// <summary>
    /// Factory class that creates Flour
    /// </summary>
    internal class FlourFabrica : IProductFabrica
    {
        /// <summary>
        /// Creates a flour object with the specified weight
        /// </summary>
        /// <param name="weight">weight assigned to the product</param>
        /// <returns>Flour</returns>
        /// <exception cref="System.ArgumentException">Throw if weight little then 0</exception>
        public static Product GetProduct(double weight)
        {
            return new Flour(weight);
        }
    }
}
