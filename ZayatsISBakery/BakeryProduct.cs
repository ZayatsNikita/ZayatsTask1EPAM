using ProductsLib;
using System;
using System.Collections.Generic;
using System.Text;

namespace BakeryLib
{
    /// <summary>
    /// This class is the basic one for all bakery products and describes their main functionality
    /// </summary>
    public abstract class BakeryProduct: ICloneable
    {

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            int index;

            for (index = 0; index < IngredientsUsed.Count; index++)
            {
                result.Append($"{IngredientsUsed[index]}\n");
            }
            return result.ToString();
        }
        
        /// <summary>
        /// Stores the mark-up value for a product group
        /// </summary>
        protected decimal markUpForSale;

        protected List<Product> _necessaryIngredients;

        /// <summary>
        /// Property used for getting a list of ingredients that are in the product
        /// </summary>
        public virtual List<Product> IngredientsUsed { get=> _necessaryIngredients; }

        /// <summary>
        /// Calculates the number of calories that are contained in a bakery product
        /// </summary>
        /// <returns>
        /// Total calories of incoming products
        /// </returns>
        /// <exception cref="System.NullReferenceException">Thrown when the list of ingredients is not specified</exception>
        public virtual double GetCaloric()
        {
            if (IngredientsUsed == null)
                throw new NullReferenceException();
            double res = 0;
            foreach(Product p in IngredientsUsed)
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
        /// <exception cref="System.NullReferenceException">Thrown when the list of ingredients is not specified</exception>
        public virtual decimal GetPrice()
        {
            if (IngredientsUsed == null)
                throw new NullReferenceException();
            decimal res = 0;
            foreach (Product p in IngredientsUsed)
            {
                res += p.PricePerKilogram * (decimal)p.ProductWeight;
            }
            return res + markUpForSale;
        }

        public abstract object Clone();
    }
}
