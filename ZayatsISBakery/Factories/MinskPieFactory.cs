using BakeryLib.SubclassesOfCategoriesOfBakeryProducts.PieSubClasses;
using ProductsLib;
using System;
using System.Collections.Generic;

namespace BakeryLib.Factories
{
    /// <summary>
    /// The class that creates Minsk Pie
    /// </summary>
    class MinskPieFactory : IBakeryFactory
    {
        /// <summary>
        /// Static method for creating Minsk Pie
        /// </summary>
        /// <param name="products">A list of ingredients with the specified parameters that will be placed in the product</param>
        /// <returns>MinskPie</returns>
        /// <exception cref="System.ArgumentException">
        /// Thrown when an exception is thrown if the set of ingredients is incorrect
        /// </exception>
        public static BakeryProduct CreateBakeryProduct(List<Product> products)
        {
            try
            {
                return new MinskPie(products);
            }
            catch (ArgumentException)
            {
                throw new ArgumentException();
            }
        }
    }
}
