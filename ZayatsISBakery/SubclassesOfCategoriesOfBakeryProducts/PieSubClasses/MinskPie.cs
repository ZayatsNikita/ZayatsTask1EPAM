using BakeryLib.CategoriesOfBakeryProduct;
using ProductsLib;
using System;
using System.Collections.Generic;



namespace BakeryLib.SubclassesOfCategoriesOfBakeryProducts.PieSubClasses
{
    public class MinskPie : Pie
    {
        public MinskPie(List<Product> necessaryIngredients)
        {
            if (IsMinskPie(necessaryIngredients))
                _necessaryIngredients = necessaryIngredients;
        }
        public static bool IsMinskPie(List<Product> list)
        {
            if ((list?.Count ?? 0) == 4)
            {
                if (list.Find(x => x.GetType().Name == "Flour") != null && list.Find(x => x.GetType().Name == "Meat") != null
                    && list.Find(x => x.GetType().Name == "Water") != null && list.Find(x => x.GetType().Name == "Eggs") != null
                    )
                    return true;
            }
            return false;
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType() || obj == null) return false;
            MinskPie pie = (MinskPie)obj;
            {//Проверить на ошибки
                for (int index = 0; index < (NecessaryIngredients?.Count ?? 0); index++)
                {
                    if (pie.NecessaryIngredients.Find(x => x.GetType().Name == NecessaryIngredients[index].GetType().Name).ProductWeight != NecessaryIngredients[index].ProductWeight)
                        return false;
                }
                return true;
            }
        }
        public override string ToString()
        {
            return "Minsk Pie" + base.ToString();
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(NecessaryIngredients, markUpForSale, typeof(MinskPie).Name);
        }

    }
}
