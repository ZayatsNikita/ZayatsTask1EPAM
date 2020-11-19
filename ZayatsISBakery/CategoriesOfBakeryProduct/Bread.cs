using ProductsLib;
using System;
using System.Collections.Generic;

namespace BakeryLib.CategoriesOfBakeryProduct
{
    public class Bread : BakeryProduct, ICloneable
    {
        
        private int calorieCoefficient;


        public Bread()
        {
            markUpForSale = 100;
        }



        public override double GetCaloric()
        {
            return base.GetCaloric() * calorieCoefficient;
        }

        public override decimal GetPrice()
        {
            return base.GetPrice() * markUpForSale;
        }


        //public override int GetHashCode()
        //{
        //    return HashCode.Combine(base.GetHashCode(), Name, markUpForSale, calorieCoefficient);
        //}
        //public override bool Equals(object obj)
        //{
        //    if (obj is Bread p)
        //    {
        //        return (p.Name == Name && p.markUpForSale == markUpForSale && p.calorieCoefficient == calorieCoefficient);
        //    }
        //    else return false;
        //}

        public object Clone()
        {
            Bread bread =  new Bread();
            List <Product> products = this.listOfIngredients;
            foreach(Product p in products)
            {
                bread.listOfIngredients.Add(p);
            }
            return bread;
        }
    }
}
