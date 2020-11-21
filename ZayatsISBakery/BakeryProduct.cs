using System.Text.RegularExpressions;
using System.Text;
using System.Collections.Generic;
using ProductsLib;
using System;

namespace BakeryLib
{
    public abstract class BakeryProduct /*: IBakeryProductManager
*/    {
        //public override string ToString()
        //{
        //    StringBuilder result = new StringBuilder();
            
        //    result.Append($"Product: {this.GetType().Name};\n");

        //    int index;

        //    for (index = 0; index < NecessaryIngredients.Count; index++)
        //    {
        //        result.Append($"Ingredient {index}: {NecessaryIngredients[index].GetType().Name}; Weight: {NecessaryIngredients[index].ProductWeight};" +
        //            $";Colories: {NecessaryIngredients[index].CalorificPerKilogram * NecessaryIngredients[index].ProductWeight} Kkal, price: " +
        //            $"{(decimal)NecessaryIngredients[index].ProductWeight * NecessaryIngredients[index].PricePerKilogram}\n");
        //    }

        //    return result.ToString();
        //}
       
        protected decimal markUpForSale;
        protected List<IProduct> _necessaryIngredients;
        public abstract List<IProduct> NecessaryIngredients { get; set; }

        public abstract double GetCaloric();
        
        public abstract decimal GetPrice();
       
    }
}
