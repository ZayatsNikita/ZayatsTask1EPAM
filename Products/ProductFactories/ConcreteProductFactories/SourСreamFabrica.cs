using ProductsLib.ModelsOfProduct;


namespace ProductsLib.ProductFactories
{
    class SourСreamFabrica
    {
        public static Product GetProduct(double weight)
        {
            return new SourСream() { ProductWeight = weight };
        }
    }
}
