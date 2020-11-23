using System;
using System.Collections.Generic;
using System.Linq;
using BakeryLib.SubclassesOfCategoriesOfBakeryProducts.BreadSubClasses;
using BakeryLib.SubclassesOfCategoriesOfBakeryProducts.PieSubClasses;
using BakeryLib.SubclassesOfCategoriesOfBakeryProducts.CakeSubClasses;
using BakeryLib.Factories;
using ProductsLib;


namespace BakeryLib
{
    /// <summary>
    /// Сlass of the main bakery that bakes baked goods,
    /// and performs manipulations 
    /// with them
    /// </summary>
    public class Bakery
    {
        /// <summary>
        /// Sorts the array with bakery products in ascending order of price
        /// </summary>
        /// <param name="bakeryProducts">array for sorting</param>
        /// <returns>sorted array</returns>
        public BakeryProduct[] SortByPrice(BakeryProduct[] bakeryProducts)
        {
            return  bakeryProducts.OrderBy(x=>x.GetPrice()).ToArray();
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
        public BakeryProduct[] SortByCalories(BakeryProduct[] bakeryProducts)
        {
            return bakeryProducts.OrderBy(x=>x.GetCaloric()).ToArray();
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
        public BakeryProduct[] FilterByPriceAndColories(BakeryProduct[] bakeryProducts, BakeryProduct product)
        {
            return bakeryProducts.Where(x=> (x.GetPrice() == product.GetPrice()) && x.GetCaloric() == product.GetCaloric()).ToArray();
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
        public BakeryProduct[] FilterByIngridientWeight(BakeryProduct[] bakeryProducts, Product product)
        {
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
        public BakeryProduct[] FilterByIngridientsCount(BakeryProduct[] bakeryProducts, int countOfIngreedient)
        {
            return bakeryProducts.Where(x => x.NecessaryIngredients.Count > countOfIngreedient).ToArray();
        }


        /// <summary>
        /// Creates new bakery products, according to the received parameters
        /// </summary>
        /// <param name="source">A string that contains the name of the 
        /// bakery product in the specified format<para>[The name of a specific product][Type of the product]</para><example>for example: YaltPie</example></param>
        /// <param name="products">List of ingredients</param>
        /// <returns>1 bakery product</returns>
        /// <remarks>The list of transmitted ingredients must match what is needed for a particular bakery 
        /// product, and the product itself must be known to the bakery
        /// <para>All bakery products that are created are inheritors of the BakeryProduct class</para>
        /// </remarks>
        /// <exception cref="System.ArgumentException">Thrown when the passed string does not match any 
        /// instance of the bakery product, or if the list of ingredients does not match the list of 
        /// ingredients of the product</exception>
        public static BakeryProduct CreateBakeryProduct(string source, List<Product> products)
        {
            switch (source)
            {
                case "BorodinskyBread":
                    if(BorodinskyBread.IsBorodinsky(products))
                    return BorodinskyBreadFactory.CreateBakeryProduct(products);
                    break;
                case "KupalovskyBread":
                    if(KupalovskyBread.IsKupalovskyBread(products))
                        return KupalovskyBreadFactory.CreateBakeryProduct(products);
                    break;
                case "LuntikCake":
                    if (LuntikCake.IsLunticCake(products))
                        return LuntikCakeFactory.CreateBakeryProduct(products);
                    break;
                case "NapoleonCake":
                    if (NapoleonCake.IsNapoleonCake(products))
                        return NapoleonCakeFactory.CreateBakeryProduct(products);
                    break;
                case "MinskPie":
                    if (MinskPie.IsMinskPie(products))
                        return MinskPieFactory.CreateBakeryProduct(products);
                    break;
                case "YaltPie":
                    if (YaltPie.IsYaltPie(products))
                        return YaltPieFactory.CreateBakeryProduct(products);
                    break;
            }
            throw new ArgumentException("The bakery doesn't bake product liki this");

        }
    }
}

