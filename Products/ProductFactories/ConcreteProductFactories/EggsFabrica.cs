using ProductsLib.ModelsOfProduct;

namespace ProductsLib.ProductFactories
{
    /// <summary>
    /// Factory class that creates Eggs
    /// </summary>
    internal class EggsFabrica : IProductFabrica
    {
        /// <summary>
        /// Creates a Eggs object with the specified weight
        /// </summary>
        /// <param name="weight">weight assigned to the product</param>
        /// <returns>Eggs</returns>
        /// <exception cref="System.ArgumentException">Throw if weight little then 0</exception>
        public static Product GetProduct(double weight)
        {
            return new Eggs(weight);
        }
    }
}



