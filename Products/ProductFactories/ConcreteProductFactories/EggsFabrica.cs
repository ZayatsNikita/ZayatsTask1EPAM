using ProductsLib.ModelsOfProduct;

namespace ProductsLib.ProductFactories
{
    class EggsFabrica: IProductFabrica
    {
        public  static IProduct GetProduct(double weight)
        {
            return new Eggs() { ProductWeight = weight };
        }
    }
}



