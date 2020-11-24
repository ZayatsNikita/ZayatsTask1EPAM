using BakeryLib.SubclassesOfCategoriesOfBakeryProducts.PieSubClasses;
using ProductsLib;
using System;
using System.Collections.Generic;
namespace BakeryLib.Factories
{
    /// <summary>
    /// The class that creates Yalt Pie
    /// </summary>
    class YaltPieFactory : IBakeryFactory
    {
        /// <summary>
        /// Static method for creating Yalt Pie
        /// </summary>
        /// <param name="products">A list of ingredients with the specified parameters that will be placed in the product</param>
        /// <returns>Yalt Pie</returns>
        /// <exception cref="System.ArgumentException">
        /// Thrown when an exception is thrown if the set of ingredients is incorrect
        /// </exception>
        public static BakeryProduct CreateBakeryProduct(List<Product> products)
        {
            try 
            { 

            return new YaltPie(products);
            }
            catch (ArgumentException)
            {
                throw new ArgumentException();
            }
        }
    }
}
