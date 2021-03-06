﻿using BakeryLib.CategoriesOfBakeryProduct;
using ProductsLib;
using System;
using System.Collections.Generic;

namespace BakeryLib.SubclassesOfCategoriesOfBakeryProducts.BreadSubClasses
{
    /// <summary>
    /// Class describing KupalovskyBread
    /// </summary>
    public class KupalovskyBread  : Bread
    {
        /// <summary>
        /// KupalovskyBread constructor
        /// </summary>
        /// <param name="necessaryIngredients">A list of ingredients with the specified parameters that will be placed in the product</param>
        /// <exception cref="System.ArgumentException">
        /// Thrown when an exception is thrown if the set of ingredients is incorrect
        /// </exception>
        public KupalovskyBread(List<Product> necessaryIngredients)
        {
            if (IsKupalovskyBread(necessaryIngredients))
                _necessaryIngredients = necessaryIngredients;
            else throw new ArgumentException();
        }

        /// <summary>
        /// A static method that determines whether a set of ingredients matches a this bakery product
        /// </summary>
        /// <param name="list">Set of ingredients</param>
        /// <returns>True if it matches, otherwise false</returns>
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

        public override object Clone()
        {
            List<Product> newIngridientList = new List<Product>(this.IngredientsUsed.Count);
            for (int index = 0; index < this.IngredientsUsed.Count; index++)
            {
                newIngridientList[index] = (Product)this.IngredientsUsed[index].Clone();
            }
            return new KupalovskyBread(newIngridientList);
        }


        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType() || obj == null) return false;
            KupalovskyBread bread = (KupalovskyBread)obj;
            {//Проверить на ошибки
                for (int index = 0; index < (IngredientsUsed?.Count ?? 0); index++)
                {
                    if (bread.IngredientsUsed.Find(x => x.GetType().Name == IngredientsUsed[index].GetType().Name).ProductWeight != IngredientsUsed[index].ProductWeight)
                        return false;
                }
                return true;
            }
        }


        public override string ToString()
        {
            return "Bread \"Kupalovsky\"\n" + base.ToString();
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(IngredientsUsed, markUpForSale);
        }
    }
}
