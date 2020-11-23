using ProductsLib;
using System.Collections.Generic;
using BakeryLib.SubclassesOfCategoriesOfBakeryProducts.BreadSubClasses;
using System;


namespace BakeryLib.Factories
{
    /// <summary>
    /// The class that creates Borodinsky Bread
    /// </summary>
    class BorodinskyBreadFactory : IBakeryFactory
    {
        /// <summary>
        /// Static method for creating Borodinsky Bread
        /// </summary>
        /// <param name="products">A list of ingredients with the specified parameters that will be placed in the product</param>
        /// <returns>BorodinskyBread</returns>
        /// <exception cref="System.ArgumentException">
        /// Thrown when an exception is thrown if the set of ingredients is incorrect
        /// </exception>
        public static BakeryProduct CreateBakeryProduct(List<Product> products)
        {
            try
            {
                return new BorodinskyBread(products);
            }
            catch (ArgumentException)
            {
                throw new ArgumentException();
            }
        }
    }
}
