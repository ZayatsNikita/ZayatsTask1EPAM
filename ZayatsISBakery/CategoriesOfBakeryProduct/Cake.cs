using System;
using System.Collections.Generic;
using System.Text;
using ProductsLib;
namespace BakeryLib.CategoriesOfBakeryProduct 
{
    public class Cake : BakeryProduct, ICloneable
    {
        private int costOfServing;

         public Cake()
        {
            markUpForSale = 300;
        }




        public override double GetCaloric()
        {
            return base.GetCaloric();
        }

        public override decimal GetPrice()
        {
            return base.GetPrice() * markUpForSale + costOfServing;
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

        public object Clone()
        {
            Cake cake = new Cake();
            List<Product> products = this.listOfIngredients;
            foreach (Product p in products)
            {
                cake.listOfIngredients.Add(p);
            }
            return cake;
        }


    }
}

