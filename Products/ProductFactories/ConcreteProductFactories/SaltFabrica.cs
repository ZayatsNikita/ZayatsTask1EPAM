using ProductsLib.ModelsOfProduct;


namespace ProductsLib.ProductFactories
{
    /// <summary>
    /// Factory class that creates Salt
    /// </summary>
    class SaltFabrica
    {
        /// <summary>
        /// Creates a Salt object with the specified weight
        /// </summary>
        /// <param name="weight">weight assigned to the product</param>
        /// <returns>Salt</returns>
        /// <exception cref="System.ArgumentException">Throw if weight little then 0</exception>
        public static Product GetProduct(double weight)
        {
            return new Salt() { ProductWeight = weight };
        }
    }
}
