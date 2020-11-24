using BakeryLib.SubclassesOfCategoriesOfBakeryProducts.BreadSubClasses;
using ProductsLib;
using System;
using System.Collections.Generic;
namespace BakeryLib.Factories
{
    /// <summary>
    /// The class that creates Kupalovsky Bread
    /// </summary>
    class KupalovskyBreadFactory : IBakeryFactory
    {
        /// <summary>
        /// Static method for creating Kupalovsky Bread
        /// </summary>
        /// <param name="products">A list of ingredients with the specified parameters that will be placed in the product</param>
        /// <returns>Kupalovsky Bread</returns>
        /// <exception cref="System.ArgumentException">
        /// Thrown when an exception is thrown if the set of ingredients is incorrect
        /// </exception>
        public static BakeryProduct CreateBakeryProduct(List<Product> products)
        {
            try
            {
                return new KupalovskyBread(products);
            }
            catch (ArgumentException)
            {
                throw new ArgumentException();
            }
        }
    }
}
