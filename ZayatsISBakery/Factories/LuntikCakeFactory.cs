using ProductsLib;
using System.Collections.Generic;
using BakeryLib.SubclassesOfCategoriesOfBakeryProducts.CakeSubClasses;

namespace BakeryLib.Factories
{
    class LuntikCakeFactory : IBakeryFactory
    {
        public static BakeryProduct CreateBakeryProduct(List<IProduct> products)
        {
            return new LuntikCake() { NecessaryIngredients = products };
        }
    }
}
