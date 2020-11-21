using ProductsLib.ModelsOfProduct;


namespace ProductsLib.ProductFactories
{
    class SourСreamFabrica
    {
        public static IProduct GetProduct(double weight)
        {
            return new SourСream() { ProductWeight = weight };
        }
    }
}
