using ProductsLib;
using System;
using System.Collections.Generic;

namespace BakeryLib.CategoriesOfBakeryProduct
{
    public class Pie : BakeryProduct, ICloneable
    {

        private int priceCoeficient;

        public Pie()
        {
            markUpForSale = 400;
        }

        public override double GetCaloric()
        {
            return base.GetCaloric();
        }
        
        public override decimal GetPrice()
        {
            return base.GetPrice() * markUpForSale * (decimal)priceCoeficient;
        }

        //public override int GetHashCode()
        //{
        //    return HashCode.Combine(base.GetHashCode(), Name, markUpForSale, priceCoeficient);
        //}
        //public override bool Equals(object obj)
        //{
        //    if (obj is Pie p)
        //    {
        //        return (p.Name == Name && p.markUpForSale == markUpForSale && p.priceCoeficient == priceCoeficient);
        //    }
        //    else return false;
        //}

        public object Clone()
        {
            Pie pie = new Pie();
            List<Product> products = this.listOfIngredients;
            foreach (Product p in products)
            {
                pie.listOfIngredients.Add(p);
            }
            return pie;
        }
    }
}
