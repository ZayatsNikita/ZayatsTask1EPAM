using System;
using System.Collections.Generic;
using System.Text;
using ProductsLib.ModelsOfProduct;
using ProductsLib;
using BakeryLib.CategoriesOfBakeryProduct;

namespace BakeryLib.SubclassesOfCategoriesOfBakeryProducts.BreadSubClasses
{
    class KupalovskyBread  : Bread
    {
        public static List<IProduct> NecessaryIngredients { get; } = new List<IProduct>() { new Eggs(), new Flour(), new Oil(), new Salt()};

        public override double GetCaloric()
        {
            return 10;
            ///return base.GetCaloric();
        }

        public override decimal GetPrice()
        {
            return 20;
            //return base.GetPrice();
        }












        public override string ToString()
        {
            return "Kupalovsky" + base.ToString();
        }


        public override int GetHashCode()
        {
            return HashCode.Combine(NecessaryIngredients, markUpForSale);
        }
    }
}
