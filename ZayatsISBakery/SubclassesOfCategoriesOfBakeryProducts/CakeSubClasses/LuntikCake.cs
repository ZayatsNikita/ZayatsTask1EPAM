﻿using BakeryLib.CategoriesOfBakeryProduct;
using ProductsLib;
using System;
using System.Collections.Generic;

namespace BakeryLib.SubclassesOfCategoriesOfBakeryProducts.CakeSubClasses
{
    /// <summary>
    /// Class describing LuntikCake
    /// </summary>
    public class LuntikCake : Cake
    {
        /// <summary>
        /// LuntikCake constructor
        /// </summary>
        /// <param name="necessaryIngredients">A list of ingredients with the specified parameters that will be placed in the product</param>
        /// <exception cref="System.ArgumentException">
        /// Thrown when an exception is thrown if the set of ingredients is incorrect
        /// </exception>
        public LuntikCake(List<Product> necessaryIngredients)
        {
            if (IsLunticCake(necessaryIngredients))
                _necessaryIngredients = necessaryIngredients;
            else throw new ArgumentException();
        }
        /// <summary>
        /// A static method that determines whether a set of ingredients matches a this bakery product
        /// </summary>
        /// <param name="list">Set of ingredients</param>
        /// <returns>True if it matches, otherwise false</returns>
        public static bool IsLunticCake(List<Product> list)
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
       
        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType() || obj == null) return false;
            LuntikCake cake = (LuntikCake)obj;
            {//Проверить на ошибки
                for (int index = 0; index < (IngredientsUsed?.Count ?? 0); index++)
                {
                    if (cake.IngredientsUsed.Find(x => x.GetType().Name == IngredientsUsed[index].GetType().Name).ProductWeight != IngredientsUsed[index].ProductWeight)
                        return false;
                }
                return true;
            }
        }
        
        public override string ToString()
        {
            return "Cake \"Luntic\"\n" + base.ToString();
        }
      
        public override int GetHashCode()
        {
            return HashCode.Combine(IngredientsUsed, markUpForSale, typeof(LuntikCake).Name);
        }

        public override object Clone()
        {
            List<Product> newIngridientList = new List<Product>(this.IngredientsUsed.Count);
            for (int index = 0; index < this.IngredientsUsed.Count; index++)
            {
                newIngridientList[index] = (Product)this.IngredientsUsed[index].Clone();
            }
            return new LuntikCake(newIngridientList);
        }
    }
}
