using BakeryLib.CategoriesOfBakeryProduct;
using ProductsLib;
using System;
using System.Collections.Generic;



namespace BakeryLib.SubclassesOfCategoriesOfBakeryProducts.PieSubClasses
{
    /// <summary>
    /// Class describing MinskPie
    /// </summary>
    public class MinskPie : Pie
    {
        /// <summary>
        /// BorodinskyBread constructor
        /// </summary>
        /// <param name="necessaryIngredients">A list of ingredients with the specified parameters that will be placed in the product</param>
        /// <exception cref="System.ArgumentException">
        /// Thrown when an exception is thrown if the set of ingredients is incorrect
        /// </exception>
        public MinskPie(List<Product> necessaryIngredients)
        {
            if (IsMinskPie(necessaryIngredients))
                _necessaryIngredients = necessaryIngredients;
            else throw new ArgumentException();
        }
        /// <summary>
        /// A static method that determines whether a set of ingredients matches a this bakery product
        /// </summary>
        /// <param name="list">Set of ingredients</param>
        /// <returns>True if it matches, otherwise false</returns>
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
            return "Pie \"Minsk\"\n" + base.ToString();
        }
     
        public override int GetHashCode()
        {
            return HashCode.Combine(NecessaryIngredients, markUpForSale, typeof(MinskPie).Name);
        }

    }
}
