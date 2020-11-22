using BakeryLib.CategoriesOfBakeryProduct;
using ProductsLib;
using System;
using System.Collections.Generic;

namespace BakeryLib.SubclassesOfCategoriesOfBakeryProducts.CakeSubClasses
{
    public class NapoleonCake : Cake
    {
        public NapoleonCake(List<Product> necessaryIngredients)
        {
            if (IsNapoleonCake(necessaryIngredients))
                _necessaryIngredients = necessaryIngredients;
        }
        public static bool IsNapoleonCake(List<Product> list)
        {
            if ((list?.Count ?? 0) == 2)
            {
                if (list.Find(x => x.GetType().Name == "SourСream") != null && list.Find(x => x.GetType().Name == "Eggs") != null)
                    return true;
            }
            return false;
        }
        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType() || obj == null) return false;
            NapoleonCake cake = (NapoleonCake)obj;
            {
                for (int index = 0; index < (NecessaryIngredients?.Count ?? 0); index++)
                {
                    if (cake.NecessaryIngredients.Find(x => x.GetType().Name == NecessaryIngredients[index].GetType().Name).ProductWeight != NecessaryIngredients[index].ProductWeight)
                        return false;
                }
                return true;
            }
        }
        public override string ToString()
        {
            return "Napoleon cake" + base.ToString();
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(NecessaryIngredients, markUpForSale, typeof(NapoleonCake).Name);
        }
    }
}
