using ProductsLib;
using System.Collections.Generic;
using System.Text;

namespace BakeryLib
{
    public abstract class BakeryProduct 
    {
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            int index;

            for (index = 0; index < NecessaryIngredients.Count; index++)
            {
                result.Append($"Ingredient {index}: {NecessaryIngredients[index].GetType().Name}; Weight: {NecessaryIngredients[index].ProductWeight};" +
                    $";Colories: {NecessaryIngredients[index].CalorificPerKilogram * NecessaryIngredients[index].ProductWeight} Kkal, price: " +
                    $"{(decimal)NecessaryIngredients[index].ProductWeight * NecessaryIngredients[index].PricePerKilogram}\n");
            }

            return result.ToString();
        }

        protected decimal markUpForSale;

        protected List<Product> _necessaryIngredients;
        public virtual List<Product> NecessaryIngredients { get=> _necessaryIngredients; }

        public virtual double GetCaloric()
        { 
            double res = 0;
            foreach(Product p in NecessaryIngredients)
            {
                res += p.CalorificPerKilogram * p.ProductWeight;
            }
            return res;
        }
        
        public virtual decimal GetPrice()
        {
            decimal res = 0;
            foreach (Product p in NecessaryIngredients)
            {
                res += p.PricePerKilogram * (decimal)p.ProductWeight;
            }
            return res + markUpForSale;
        }
       
    }
}
