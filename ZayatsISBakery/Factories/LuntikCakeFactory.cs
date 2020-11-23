using ProductsLib;
using System.Collections.Generic;
using BakeryLib.SubclassesOfCategoriesOfBakeryProducts.CakeSubClasses;
using System;
namespace BakeryLib.Factories
{
    /// <summary>
    /// The class that creates Luntik Cake
    /// </summary>
    class LuntikCakeFactory : IBakeryFactory
    {
        /// <summary>
        /// Static method for creating Luntik Cake
        /// </summary>
        /// <param name="products">A list of ingredients with the specified parameters that will be placed in the product</param>
        /// <returns>LuntikCake</returns>
        /// <exception cref="System.ArgumentException">
        /// Thrown when an exception is thrown if the set of ingredients is incorrect
        /// </exception>
        public static BakeryProduct CreateBakeryProduct(List<Product> products)
        {
            try
            {
                return new LuntikCake(products);
            }
            catch(ArgumentException)
            {
                throw new ArgumentException();
            }
        }
    }
}
