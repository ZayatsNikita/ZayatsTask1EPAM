using BakeryLib.CategoriesOfBakeryProduct;
using ProductsLib;
using System;
using System.Collections.Generic;



namespace BakeryLib.SubclassesOfCategoriesOfBakeryProducts.PieSubClasses
{
    public class YaltPie : Pie
    {
        public YaltPie(List<Product> necessaryIngredients)
        {
            if (IsYaltPie(necessaryIngredients))
                _necessaryIngredients = necessaryIngredients;
        }
        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType() || obj == null) return false;
            YaltPie pie = (YaltPie)obj;
            {//Проверить на ошибки
                for (int index = 0; index < (NecessaryIngredients?.Count ?? 0); index++)
                {
                    if (pie.NecessaryIngredients.Find(x => x.GetType().Name == NecessaryIngredients[index].GetType().Name).ProductWeight != NecessaryIngredients[index].ProductWeight)
                        return false;
                }
                return true;
            }
        }
        public static bool IsYaltPie(List<Product> list)
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
