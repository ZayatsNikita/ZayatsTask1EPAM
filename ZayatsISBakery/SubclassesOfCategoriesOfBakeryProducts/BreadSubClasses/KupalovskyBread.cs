using System;
using System.Collections.Generic;
using System.Text;
using ProductsLib.ModelsOfProduct;
using ProductsLib;
using BakeryLib.CategoriesOfBakeryProduct;

namespace BakeryLib.SubclassesOfCategoriesOfBakeryProducts.BreadSubClasses
{
    public class KupalovskyBread  : Bread
    {
        public KupalovskyBread(List<Product> necessaryIngredients)
        {
            if (IsKupalovskyBread(necessaryIngredients))
                _necessaryIngredients = necessaryIngredients;
        }

        public static bool IsKupalovskyBread(List<Product> list)
        {
            if ((list?.Count ?? 0) == 4)
            {
                if (list.Find(x => x.GetType().Name == "Eggs") != null && list.Find(x => x.GetType().Name == "Flour") != null &&
                    list.Find(x => x.GetType().Name == "Oil") != null && list.Find(x => x.GetType().Name == "Salt") != null)
                    return true;
            }
            return false;
        }



        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType() || obj == null) return false;
            KupalovskyBread bread = (KupalovskyBread)obj;
            {//Проверить на ошибки
                for (int index = 0; index < (NecessaryIngredients?.Count ?? 0); index++)
                {
                    if (bread.NecessaryIngredients.Find(x => x.GetType().Name == NecessaryIngredients[index].GetType().Name).ProductWeight != NecessaryIngredients[index].ProductWeight)
                        return false;
                }
                return true;
            }
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
