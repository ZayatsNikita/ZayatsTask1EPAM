using BakeryLib;
using System;
using System.IO;
using System.Collections.Generic;
using ProductsLib.ModelsOfProduct;
using ProductsLib;
using BakeryLib.SubclassesOfCategoriesOfBakeryProducts.BreadSubClasses;

namespace Task1ItemNumber10_14
{
    class Program
    {
        static void Main(string[] args)
        {
            BakeryForWorkingWithBakeryProducts bakery = new BakeryForWorkingWithBakeryProducts();


            BakeryProduct[] bakeries = null, bakeries1=null, bakeries2=null, bakeries3=null, bakeries4=null, bakeries5=null;
            try
            {
                WorkWithFile.GetData(out bakeries, @"..\..\..\..\text.txt");
            }
            catch(FileNotFoundException)
            {
                return;
            }
            try
            {
                //10. Sort by calorie content
                bakeries1 = bakery.SortByCalories(bakeries);

                //11. Sort by price content
                bakeries2 = bakery.SortByPrice(bakeries);

                //12. Search for products that are equal in cost and calorie content
                bakeries3 = bakery.FilterByPriceAndColories(bakeries, (bakeries[0] ?? new BorodinskyBread(new List<Product> { new Flour(1), new Water(1) })));


                //13. Search for products where the amount of use of a given ingredient is greater than the specified amount

                //The specified weight value
                double weight = 1.0;

                bakeries4 = bakery.FilterByIngridientWeight(bakeries, new Flour(weight));

                //14. Search for products where the number of ingredients is greater than the specified value
                bakeries5 = bakery.FilterByIngridientsCount(bakeries, 3);
            }
            catch (NullReferenceException) { }
        }
    }
}