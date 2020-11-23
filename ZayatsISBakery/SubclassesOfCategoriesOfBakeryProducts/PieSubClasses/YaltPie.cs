using BakeryLib.CategoriesOfBakeryProduct;
using ProductsLib;
using System;
using System.Collections.Generic;



namespace BakeryLib.SubclassesOfCategoriesOfBakeryProducts.PieSubClasses
{
    /// <summary>
    /// Class describing YaltPie
    /// </summary>
    public class YaltPie : Pie
    {
        /// <summary>
        /// YaltPie constructor
        /// </summary>
        /// <param name="necessaryIngredients">A list of ingredients with the specified parameters that will be placed in the product</param>
        /// <exception cref="System.ArgumentException">
        /// Thrown when an exception is thrown if the set of ingredients is incorrect
        /// </exception>
        public YaltPie(List<Product> necessaryIngredients)
        {
            if (IsYaltPie(necessaryIngredients))
                _necessaryIngredients = necessaryIngredients;
            else throw new ArgumentException();
        }

        /// <summary>
        /// Determines whether the specified object is equal to the current object.
        /// </summary>
        /// <param name="obj">The object to compare with current object</param>
        /// <returns>true if the specified object is equal to the current object; otherwise, false.</returns>
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
        /// <summary>
        /// A static method that determines whether a set of ingredients matches a this bakery product
        /// </summary>
        /// <param name="list">Set of ingredients</param>
        /// <returns>True if it matches, otherwise falsereturns>
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
        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>A string that represents the current object.</returns>
        public override string ToString()
        {
            return "Yalt Pie" + base.ToString();
        }
        /// <summary>
        /// Serves as the default hash function.
        /// </summary>
        /// <returns>A hash code for the current object.</returns>
        public override int GetHashCode()
        {
            return HashCode.Combine(NecessaryIngredients, markUpForSale,typeof(YaltPie).Name);
        }
    }
}
