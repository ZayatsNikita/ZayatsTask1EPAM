using System;
using System.Collections.Generic;
using System.Text;
using BakeryLib.CategoriesOfBakeryProduct;
using BakeryLib.Interfaces;

namespace BakeryLib
{
    class BakeryRealizator : IExpensiveBakery, ICheapBakery
    {
        public Bread CreateBread()
        {
            return null;
        }
        public Cake CreateCake()
        {
            throw new NotImplementedException();
        }

        public Pie CreatePie()
        {
            throw new NotImplementedException();
        }
    }
}
