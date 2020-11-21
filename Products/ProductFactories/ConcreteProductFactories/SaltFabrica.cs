using ProductsLib.ModelsOfProduct;


namespace ProductsLib.ProductFactories
{
    class SaltFabrica
    {
        public static IProduct GetProduct(double weight)
        {
            return new Salt() { ProductWeight = weight };
        }
    }
}
