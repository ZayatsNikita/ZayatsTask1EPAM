using System;
using System.Collections.Generic;
using System.Text;
using BakeryLib.CategoriesOfBakeryProduct;

namespace BakeryLib.Interfaces
{
    interface IExpensiveBakery
    {
        public Cake CreateCake();
        public Pie CreatePie();
    }
}
