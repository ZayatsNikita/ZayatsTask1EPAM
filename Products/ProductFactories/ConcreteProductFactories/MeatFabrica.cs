using ProductsLib.ModelsOfProduct;


namespace ProductsLib.ProductFactories
{
    class MeatFabrica
    {
        public static Product GetProduct(double weight)
        {
            return new Meat() { ProductWeight = weight };
        }
    }
}
