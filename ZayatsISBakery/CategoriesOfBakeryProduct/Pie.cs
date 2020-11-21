using ProductsLib;
using System;
using System.Collections.Generic;

namespace BakeryLib.CategoriesOfBakeryProduct
{
    public class Pie : BakeryProduct
    {

        public Pie()
        {
            markUpForSale = 400;
        }

        public override double GetCaloric()
        {
            return 1;
        }

        public override decimal GetPrice()
        {
            return 1;
        }

    }
}
