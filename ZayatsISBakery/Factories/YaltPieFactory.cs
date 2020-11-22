using ProductsLib;
using System.Collections.Generic;
using BakeryLib.SubclassesOfCategoriesOfBakeryProducts.PieSubClasses;

namespace BakeryLib.Factories
{
    class YaltPieFactory : IBakeryFactory
    {
        public static BakeryProduct CreateBakeryProduct(List<Product> products)
        {
            return new YaltPie(products);
        }
    }
}
