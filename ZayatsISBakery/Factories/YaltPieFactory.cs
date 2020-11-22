﻿using ProductsLib;
using System.Collections.Generic;
using BakeryLib.SubclassesOfCategoriesOfBakeryProducts.PieSubClasses;

namespace BakeryLib.Factories
{
    class YaltPieFactory : IBakeryFactory
    {
        public static BakeryProduct CreateBakeryProduct(List<IProduct> products)
        {
            return new YaltPie() { NecessaryIngredients = products };
        }
    }
}