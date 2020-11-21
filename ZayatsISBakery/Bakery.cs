using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using BakeryLib.Interfaces;
using BakeryLib.SubclassesOfCategoriesOfBakeryProducts.BreadSubClasses;
using System.Linq;
//using BakeryLib.SubclassesOfCategoriesOfBakeryProducts.BunSubClasses;
//using BakeryLib.SubclassesOfCategoriesOfBakeryProducts.PieSubClasses;
//using BakeryLib.SubclassesOfCategoriesOfBakeryProducts.CakeSubClasses;
using ProductsLib;

namespace BakeryLib
{
    class Bakery
    {
        ICheapBakery cheapBakery;
        IExpensiveBakery expensiveBakery;
        Bakery()
        {
            BakeryRealizator bakeryRealizator = new BakeryRealizator();
            cheapBakery = bakeryRealizator;
            expensiveBakery = bakeryRealizator;
        }
        Dictionary<BakeryProduct, int> listOfManufacturedProducts;

        public void AddProduct(BakeryProduct product, int count)
        {
            if (product != null)
                listOfManufacturedProducts.Add(product, count);
            else
                throw new ArgumentNullException();
        }


        

        public static BakeryProduct CreateBakeryProduct(string source, List<IProduct> products)
        {
            switch (source)
            {
                case "BorodinskyBread":
                    if (products.Intersect(BorodinskyBread.NecessaryIngredients).Count()== BorodinskyBread.NecessaryIngredients.Count && BorodinskyBread.NecessaryIngredients.Count== products.Count)
                    return new BorodinskyBread();
                    break;
                case "KupalovskyBread":
                    if (KupalovskyBread.NecessaryIngredients.Count == products.Count && products.Intersect(KupalovskyBread.NecessaryIngredients).Count() == KupalovskyBread.NecessaryIngredients.Count)
                        return new KupalovskyBread();
                    break;
            }
            throw new ArgumentException("The bakery doesn't bake product liki this");
        }
    }
}

