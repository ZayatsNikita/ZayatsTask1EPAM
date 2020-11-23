using ProductsLib.ModelsOfProduct;


namespace ProductsLib.ProductFactories
{
    /// <summary>
    /// Factory class that creates SourСream
    /// </summary>
    class SourСreamFabrica
    {
        /// <summary>
        /// Creates a SourСream object with the specified weight
        /// </summary>
        /// <param name="weight">weight assigned to the product</param>
        /// <returns>SourСream</returns>
        /// <exception cref="System.ArgumentException">Throw if weight little then 0</exception>
        public static Product GetProduct(double weight)
        {
            return new SourСream() { ProductWeight = weight };
        }
    }
}
