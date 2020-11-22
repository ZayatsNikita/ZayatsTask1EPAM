using ProductsLib.ModelsOfProduct;


namespace ProductsLib.ProductFactories
{
    class SaltFabrica
    {
        public static Product GetProduct(double weight)
        {
            return new Salt() { ProductWeight = weight };
        }
    }
}
