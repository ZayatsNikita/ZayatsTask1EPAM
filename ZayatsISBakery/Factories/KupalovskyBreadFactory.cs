using ProductsLib;
using System.Collections.Generic;
using BakeryLib.SubclassesOfCategoriesOfBakeryProducts.BreadSubClasses;

namespace BakeryLib.Factories
{
    class KupalovskyBreadFactory : IBakeryFactory
    {
        public BakeryProduct CreateBakeryProduct(List<IProduct> products)
        {
            return new KupalovskyBread() {NecessaryIngredients = products };
        }
    }
}
