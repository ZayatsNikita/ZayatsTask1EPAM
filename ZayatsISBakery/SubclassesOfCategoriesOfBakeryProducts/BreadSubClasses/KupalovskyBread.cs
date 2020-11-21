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
        public override List<IProduct> NecessaryIngredients
        {
            get => _necessaryIngredients;
            set
            {
                if (IsKupalovskyBread(value))
                    _necessaryIngredients = value;
                else throw new ArgumentException();
            }
        }
        public static bool IsKupalovskyBread(List<IProduct> list)
        {
            if ((list?.Count ?? 0) == 4)
            {
                if (list.Find(x => x.GetType().Name == "Eggs") != null && list.Find(x => x.GetType().Name == "Flour") != null &&
                    list.Find(x => x.GetType().Name == "Oil") != null && list.Find(x => x.GetType().Name == "Salt") != null)
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
            return res + markUpForSale;
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
