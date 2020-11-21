using ProductsLib;
using System.Collections.Generic;
using BakeryLib.SubclassesOfCategoriesOfBakeryProducts.CakeSubClasses;

namespace BakeryLib.Factories
{
    class NapoleonCakeFactory : IBakeryFactory
    {
        public BakeryProduct CreateBakeryProduct(List<IProduct> products)
        {
            return new NapoleonCake() { NecessaryIngredients = products };
        }
    }
}
