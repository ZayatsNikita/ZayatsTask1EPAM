using ProductsLib.ModelsOfProduct;


namespace ProductsLib.ProductFactories
{
    class MeatFabrica
    {
        public static IProduct GetProduct(double weight)
        {
            return new Meat() { ProductWeight = weight };
        }
    }
}
