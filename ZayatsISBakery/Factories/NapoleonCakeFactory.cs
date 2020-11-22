using ProductsLib;
using System.Collections.Generic;
using BakeryLib.SubclassesOfCategoriesOfBakeryProducts.CakeSubClasses;

namespace BakeryLib.Factories
{
    class NapoleonCakeFactory : IBakeryFactory
    {
        public static BakeryProduct CreateBakeryProduct(List<Product> products)
        {
            return new NapoleonCake(products);
        }
    }
}
