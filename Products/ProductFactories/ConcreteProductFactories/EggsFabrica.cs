using ProductsLib.ModelsOfProduct;

namespace ProductsLib.ProductFactories
{
    class EggsFabrica: IProductFabrica
    {
        public  static Product GetProduct(double weight)
        {
            return new Eggs() { ProductWeight = weight };
        }
    }
}



