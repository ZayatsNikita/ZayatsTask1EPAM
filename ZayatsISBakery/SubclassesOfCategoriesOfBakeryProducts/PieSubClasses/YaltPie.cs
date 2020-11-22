using BakeryLib.CategoriesOfBakeryProduct;
using ProductsLib;
using System;
using System.Collections.Generic;



namespace BakeryLib.SubclassesOfCategoriesOfBakeryProducts.PieSubClasses
{
    public class YaltPie : Pie
    {
        public override List<IProduct> NecessaryIngredients
        {
            get => _necessaryIngredients;
            set
            {
                if (IsYaltPie(value))
                    _necessaryIngredients = value;
                else throw new ArgumentException();
            }
        }
        public static bool IsYaltPie(List<IProduct> list)
        {
            if ((list?.Count ?? 0) == 5)
            {
                if (list.Find(x => x.GetType().Name == "Meat") != null && list.Find(x => x.GetType().Name == "Salt") != null
                    && list.Find(x => x.GetType().Name == "Flour") != null && list.Find(x => x.GetType().Name == "SourСream") != null
                    && list.Find(x => x.GetType().Name == "Oil") != null
                    )
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
            return "Yalt Pie" + base.ToString();
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(NecessaryIngredients, markUpForSale,typeof(YaltPie).Name);
        }
    }
}
