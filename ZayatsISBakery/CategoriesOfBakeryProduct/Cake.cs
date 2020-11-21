using System;
using System.Collections.Generic;
using System.Text;
using ProductsLib;
namespace BakeryLib.CategoriesOfBakeryProduct 
{
    public abstract class Cake : BakeryProduct
    {
        private int costOfServing;
         public Cake()
        {
            markUpForSale = 300;
        }
    }
}

