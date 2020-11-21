using ProductsLib;
using System;
using System.Collections.Generic;

namespace BakeryLib.CategoriesOfBakeryProduct
{
    public abstract class Bread : BakeryProduct
    {
        public Bread()
        {
            markUpForSale = 100;
        }
    }
}
