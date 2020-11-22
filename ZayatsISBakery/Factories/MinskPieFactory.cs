using ProductsLib;
using System.Collections.Generic;
using BakeryLib.SubclassesOfCategoriesOfBakeryProducts.PieSubClasses;

namespace BakeryLib.Factories
{
    class MinskPieFactory : IBakeryFactory
    {
        public static BakeryProduct CreateBakeryProduct(List<IProduct> products)
        {
            return new MinskPie() { NecessaryIngredients = products };
        }
    }
}
