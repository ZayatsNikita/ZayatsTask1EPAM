using ProductsLib;
using System.Collections.Generic;
using BakeryLib.SubclassesOfCategoriesOfBakeryProducts.BreadSubClasses;



namespace BakeryLib.Factories
{
    class BorodinskyBreadFactory : IBakeryFactory
    {
        public BakeryProduct CreateBakeryProduct(List<IProduct> products)
        {
            return new BorodinskyBread() { NecessaryIngredients = products };
        }
    }
}
