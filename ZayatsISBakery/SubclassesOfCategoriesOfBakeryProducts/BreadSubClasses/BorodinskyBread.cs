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
        public override List<IProduct> NecessaryIngredients 
        { 
            get =>_necessaryIngredients;
            set 
            {
                if (IsBorodinsky(value))
                    _necessaryIngredients = value;
                else throw new ArgumentException();
            }
        }
        public static bool IsBorodinsky(List<IProduct> list)
        {
            if((list?.Count ?? 0) == 2)
            {
                if (list.Find(x => x.GetType().Name == "Water")!=null && list.Find(x => x.GetType().Name == "Flour") != null)
                    return true;
            }
            return false;
        }

        public override double GetCaloric()
        {
            double res = 0;
            foreach (IProduct p in NecessaryIngredients)
            {
                res += (double)p.CalorificPerKilogram;
            }
            return res;
        }

        public override decimal GetPrice()
        {
            decimal res = 0;
            foreach (IProduct p in NecessaryIngredients)
            {
                res += p.PricePerKilogram;
            }
            return res+markUpForSale;
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
