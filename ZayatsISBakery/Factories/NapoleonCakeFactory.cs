using BakeryLib.SubclassesOfCategoriesOfBakeryProducts.CakeSubClasses;
using ProductsLib;
using System;
using System.Collections.Generic;
namespace BakeryLib.Factories
{
    /// <summary>
    /// The class that creates Napoleon Cake
    /// </summary>
    class NapoleonCakeFactory : IBakeryFactory
    {
        /// <summary>
        /// Static method for creating Napoleon Cake
        /// </summary>
        /// <param name="products">A list of ingredients with the specified parameters that will be placed in the product</param>
        /// <returns>NapoleonCake</returns>
        /// <exception cref="System.ArgumentException">
        /// Thrown when an exception is thrown if the set of ingredients is incorrect
        /// </exception>
        public static BakeryProduct CreateBakeryProduct(List<Product> products)
        {
            try 
            { 
                return new NapoleonCake(products);
            }
            catch (ArgumentException)
            {
                throw new ArgumentException();
            }
        }
    }
}
