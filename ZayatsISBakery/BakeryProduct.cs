using ProductsLib;
using System.Collections.Generic;
using System.Text;

namespace BakeryLib
{
    /// <summary>
    /// This class is the basic one for all bakery products and describes their main functionality
    /// </summary>
    public abstract class BakeryProduct 
    {
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            int index;

            for (index = 0; index < NecessaryIngredients.Count; index++)
            {
                result.Append($"Ingredient {index}: {NecessaryIngredients[index].ToString()}\n");
            }

            return result.ToString();
        }
        
        /// <summary>
        /// Stores the mark-up value for a product group
        /// </summary>
        protected decimal markUpForSale;

        /// <summary>
        /// list of ingredients
        /// </summary>
        protected List<Product> _necessaryIngredients;

        /// <summary>
        /// Property used for getting a list of ingredients that are in the product
        /// </summary>
        public virtual List<Product> NecessaryIngredients { get=> _necessaryIngredients; }

        /// <summary>
        /// Calculates the number of calories that are contained in a bakery product
        /// </summary>
        /// <returns>
        /// Total calories of incoming products
        /// </returns>
        public virtual double GetCaloric()
        { 
            double res = 0;
            foreach(Product p in NecessaryIngredients)
            {
                res += p.CalorificPerKilogram * p.ProductWeight;
            }
            return res;
        }

        /// <summary>
        /// Calculates the cost of a bakery product
        /// </summary>
        /// <returns>
        /// Total price of incoming products
        /// </returns>
        /// <remarks>
        /// The product markup is also added to the cost of all ingredients
        /// </remarks>
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
