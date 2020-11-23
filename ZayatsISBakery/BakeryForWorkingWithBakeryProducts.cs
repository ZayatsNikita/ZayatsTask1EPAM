using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using ProductsLib;

namespace BakeryLib
{
    public class BakeryForWorkingWithBakeryProducts
    {
        /// <summary>
        /// Sorts the array with bakery products in ascending order of price
        /// </summary>
        /// <param name="bakeryProducts">array for sorting</param>
        /// <returns>sorted array</returns>
        /// <exception cref="System.NullReferenceException">Thrown when the array is set to zero</exception>
        public BakeryProduct[] SortByPrice(BakeryProduct[] bakeryProducts)
        {
            if (bakeryProducts == null)
                throw new NullReferenceException();
            return bakeryProducts.OrderBy(x => x.GetPrice()).ToArray();
            #region quickSort
            //int i = left, j = right;
            //BakeryProduct tmp;
            //decimal avgPrice=0;
            //for(int index=left;index<right;index++)
            //{
            //    avgPrice += bakeryProducts[index].GetPrice();
            //}
            //avgPrice /= (right - left + 1);
            //while(i<=j)
            //{
            //    while (bakeryProducts[i].GetPrice() < avgPrice)
            //        i++;
            //    while (bakeryProducts[j].GetPrice() > avgPrice)
            //        j--;
            //    if(i<=j)
            //    {
            //        tmp = bakeryProducts[i];
            //        bakeryProducts[i] = bakeryProducts[j];
            //        bakeryProducts[j] = tmp;
            //        i++;
            //        j--;
            //    }
            //}
            //if (left < j)
            //    SortByPrice(bakeryProducts,left,j);
            //if(i<right)
            //    SortByPrice(bakeryProducts, i, right);
            #endregion
        }
        /// <summary>
        /// Sorts the array with bakery products in ascending order of calories
        /// </summary>
        /// <param name="bakeryProducts">array for sorting</param>
        /// <returns>sorted array</returns>
        /// <exception cref="System.NullReferenceException">Thrown when the array is set to zero</exception>
        public BakeryProduct[] SortByCalories(BakeryProduct[] bakeryProducts)
        {
            if (bakeryProducts == null)
                throw new NullReferenceException();
            return bakeryProducts.OrderBy(x => x.GetCaloric()).ToArray();
        }
        /// <summary>
        /// finds in the array all bakery products equal to the given value and calorie content
        /// </summary>
        /// <param name="bakeryProducts">the array to search</param>
        /// <param name="product">The bakery item that the array instances are compared to</param>
        /// <returns>array of elements that match the transmitted product by price and calorie content.
        /// <para>If there are no matching elements, returns an array of zero length</para>
        /// </returns>
        /// <remarks>
        /// Only those elements whose cost and caloric content completely match the cost and caloric 
        /// content of the specified product are selected
        /// </remarks>
        /// <exception cref="System.NullReferenceException">Thrown when the array is set to zero</exception>
        public BakeryProduct[] FilterByPriceAndColories(BakeryProduct[] bakeryProducts, BakeryProduct product)
        {
            if (bakeryProducts == null)
                throw new NullReferenceException();
            return bakeryProducts.Where(x => (x.GetPrice() == product.GetPrice()) && x.GetCaloric() == product.GetCaloric()).ToArray();
        }
        /// <summary>
        /// finds all bakery products in the array where the weight of the ingredient 
        /// is greater than the weight of the specified ingredient
        /// </summary>
        /// <param name="bakeryProducts">the array to search</param>
        /// <param name="product">The bakery item that the array instances are compared to</param>
        /// <returns>Array of elements that meet the condition
        /// <para>If there are no matching elements, returns an array of zero length</para>
        /// </returns>
        /// <exception cref="System.NullReferenceException">Thrown when the array is set to zero</exception>
        public BakeryProduct[] FilterByIngridientWeight(BakeryProduct[] bakeryProducts, Product product)
        {
            if (bakeryProducts == null)
                throw new NullReferenceException();
            var result = from bProduct in bakeryProducts
                         from ingredient in bProduct.NecessaryIngredients
                         where ingredient.GetType() == product.GetType()
                         where ingredient.ProductWeight > product.ProductWeight
                         select bProduct;
            return result.ToArray();
        }
        /// <summary>
        /// Finds all bakery products with more than the specified number of ingredients
        /// </summary>
        /// <param name="bakeryProducts">the array to search</param>
        /// <param name="countOfIngreedient">The number of ingredients in a bakery product must be greater than this number</param>
        /// <returns>
        /// Массив элементов, удовлетворяющих условию
        /// <para>If there are no matching elements, returns an array of zero length</para>
        /// </returns>
        /// <exception cref="System.NullReferenceException">Thrown when the array is set to zero</exception>
        public BakeryProduct[] FilterByIngridientsCount(BakeryProduct[] bakeryProducts, int countOfIngreedient)
        {
            if (bakeryProducts == null)
                throw new NullReferenceException();
            return bakeryProducts.Where(x => x.NecessaryIngredients.Count > countOfIngreedient).ToArray();
        }

    }
}
