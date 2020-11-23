using ProductsLib;
using System.Collections.Generic;

namespace BakeryLib.Factories
{
    /// <summary>
    /// Interface for creating product-specific factories
    /// </summary>
    interface IBakeryFactory
    {
        /// <summary>
        /// Method that should create the BakeryProduct object
        /// </summary>
        /// <returns>null</returns>
        public static BakeryProduct CreateBakeryProduct(List<Product> products)=>null;
    }
}

