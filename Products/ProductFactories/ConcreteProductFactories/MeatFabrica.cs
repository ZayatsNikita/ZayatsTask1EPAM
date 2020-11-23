using ProductsLib.ModelsOfProduct;


namespace ProductsLib.ProductFactories
{
    /// <summary>
    /// Factory class that creates Meat
    /// </summary>
    class MeatFabrica
    {
        /// <summary>
        /// Creates a Meat object with the specified weight
        /// </summary>
        /// <param name="weight">weight assigned to the product</param>
        /// <returns>Meat</returns>
        /// <exception cref="System.ArgumentException">Throw if weight little then 0</exception>
        public static Product GetProduct(double weight)
        {
            return new Meat() { ProductWeight = weight };
        }
    }
}
