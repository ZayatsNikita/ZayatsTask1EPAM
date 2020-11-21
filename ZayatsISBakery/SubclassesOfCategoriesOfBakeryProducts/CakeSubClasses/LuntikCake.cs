using BakeryLib.CategoriesOfBakeryProduct;
using ProductsLib;
using System;
using System.Collections.Generic;

namespace BakeryLib.SubclassesOfCategoriesOfBakeryProducts.CakeSubClasses
{
    class LuntikCake : Cake
    {
        public override List<IProduct> NecessaryIngredients
        {
            get => _necessaryIngredients;
            set
            {
                if (IsBorodinsky(value))
                    _necessaryIngredients = value;
                else throw new ArgumentException();
            }
        }
        public static bool IsBorodinsky(List<IProduct> list)
        {
            if ((list?.Count ?? 0) == 2)
            {
                if (list.Find(x => x.GetType().Name == "Water") != null && list.Find(x => x.GetType().Name == "Flour") != null)
                    return true;
            }
            return false;
        }

        public override double GetCaloric()
        {
            double res = 0;
            foreach (IProduct p in NecessaryIngredients)
            {
                res += p.CalorificPerKilogram * p.ProductWeight;
            }
            return res;
        }

        public override decimal GetPrice()
        {
            decimal res = 0;
            foreach (IProduct p in NecessaryIngredients)
            {
                res += p.PricePerKilogram * (decimal)p.ProductWeight;
            }
            return res + markUpForSale;
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
