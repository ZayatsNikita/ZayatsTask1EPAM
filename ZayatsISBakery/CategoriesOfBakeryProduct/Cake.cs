using System;
using System.Collections.Generic;
using System.Text;
using ProductsLib;
namespace BakeryLib.CategoriesOfBakeryProduct 
{
    public class Cake : BakeryProduct
    {
        private int costOfServing;

         public Cake()
        {
            markUpForSale = 300;
        }




        public override double GetCaloric()
        {
            return 1;
        }

        public override decimal GetPrice()
        {
            return 2;
        }


        //public override int GetHashCode()
        //{
        //    return HashCode.Combine(base.GetHashCode(), Name, markUpForSale, costOfServing);
        //}
        //public override bool Equals(object obj)
        //{
        //    if (obj is Cake p)
        //    {
        //        return (p.Name == Name && p.markUpForSale == markUpForSale && p.costOfServing == costOfServing);
        //    }
        //    else return false;
        //}

        //public object Clone()
        //{
        //    Cake cake = new Cake();
        //    List<Product> products = this.NecessaryIngredients;
        //    foreach (Product p in products)
        //    {
        //        cake.NecessaryIngredients.Add(p);
        //    }
        //    return cake;
        //}


    }
}

