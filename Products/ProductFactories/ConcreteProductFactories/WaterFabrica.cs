using ProductsLib.ModelsOfProduct;

namespace ProductsLib.ProductFactories
{
    class WaterFabrica : IProductFabrica
    {
        public static Product GetProduct(double weight)
        {
            return new Water() { ProductWeight = weight };
        }
    }
}
