using BakeryLib.CategoriesOfBakeryProduct;
using ProductsLib;
using System;
using System.Collections.Generic;
using System.Linq;
using ProductsLib.ModelsOfProduct;

namespace BakeryLib.SubclassesOfCategoriesOfBakeryProducts.BreadSubClasses
{
    public class BorodinskyBread : Bread
    {
        public static List<IProduct> NecessaryIngredients { get; } = new List<IProduct>() { new Water(), new Flour()};
        


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
            return "Borodinsky" + base.ToString();
        }
        

        public override int GetHashCode()
        {
            return HashCode.Combine(NecessaryIngredients, markUpForSale);
        }

    }
}
