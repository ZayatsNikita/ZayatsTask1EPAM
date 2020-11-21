using ProductsLib.ModelsOfProduct;

namespace ProductsLib.ProductFactories
{
    class OilFabrica : IProductFabrica
    {
        public static IProduct GetProduct(double weight)
        {
            return new Oil() { ProductWeight = weight };
        }
    }
}
