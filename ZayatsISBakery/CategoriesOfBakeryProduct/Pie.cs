using ProductsLib;
using System;
using System.Collections.Generic;

namespace BakeryLib.CategoriesOfBakeryProduct
{
    public abstract class Pie : BakeryProduct
    {

        public Pie()
        {
            markUpForSale = 400;
        }
    }
}
