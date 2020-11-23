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
            if (source == null)
                throw new NullReferenceException();
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

