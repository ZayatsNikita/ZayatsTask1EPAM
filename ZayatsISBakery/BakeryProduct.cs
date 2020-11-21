using System.Text.RegularExpressions;
using System.Text;
using System.Collections.Generic;
using ProductsLib;
using System;

namespace BakeryLib
{
    public abstract class BakeryProduct : IBakeryProductManager
    {
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

        //    for (index = 0; index < AdditionalIngredients.Count; index++)
        //    {
        //        result.Append($"Ingredient {index+ NecessaryIngredients.Count}: {NecessaryIngredients[index].GetType().Name}; Weight: {NecessaryIngredients[index].ProductWeight};" +
        //            $";Colories: {NecessaryIngredients[index].CalorificPerKilogram * NecessaryIngredients[index].ProductWeight} Kkal, price: " +
        //            $"{(decimal)NecessaryIngredients[index].ProductWeight * NecessaryIngredients[index].PricePerKilogram}\n");
        //    }
        //    return result.ToString();
        //}
       
        public decimal markUpForSale;

        public abstract double GetCaloric();
        //{
        //    double res = 0;
        //    foreach (Product p in NecessaryIngredients)
        //    {
        //        res += (double)p.CalorificPerKilogram;
        //    }
        //    return res;
        //}
        public abstract decimal GetPrice();
        //{
        //    decimal res = 0;
        //    foreach (Product p in NecessaryIngredients)
        //    {
        //        res += p.PricePerKilogram;
        //    }
        //    return res;
        //}

        //public abstract void AddNecessaryIngredients(params Product[] products);
        //{
        //    if (products != null)
        //    {
        //        foreach(Product p in products)
        //        {
        //            if(p!=null)
        //                NecessaryIngredients?.Add(p);
        //        }
        //    }
                
        //}
      
    }
}
