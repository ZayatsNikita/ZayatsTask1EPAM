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
                if (IsLunticCake(value))
                    _necessaryIngredients = value;
                else throw new ArgumentException();
            }
        }
        public static bool IsLunticCake(List<IProduct> list)
        {
            if ((list?.Count ?? 0) == 3)
            {
                if (list.Find(x => x.GetType().Name == "Salt") != null && list.Find(x => x.GetType().Name == "Eggs") != null
                    && list.Find(x => x.GetType().Name == "Water") != null
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
            return "Napoleon cake" + base.ToString();
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(NecessaryIngredients, markUpForSale, typeof(LuntikCake).Name);
        }
    }
}
