using ProductsLib;
using System.Collections.Generic;
using BakeryLib.SubclassesOfCategoriesOfBakeryProducts.BreadSubClasses;



namespace BakeryLib.Factories
{
    class BorodinskyBreadFactory : IBakeryFactory
    {
        public static BakeryProduct CreateBakeryProduct(List<Product> products)
        {
            return new BorodinskyBread(products);
        }
    }
}
