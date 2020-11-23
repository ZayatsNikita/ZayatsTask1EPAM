using BakeryLib;
using System;
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


            BakeryProduct[] bakeries = null, bakeries1, bakeries2, bakeries3=null, bakeries4=null, bakeries5=null;
            WorkWithFile.GetData(out bakeries);

            bakeries1=new BakeryProduct[bakeries.Length];
            bakeries2 = new BakeryProduct[bakeries.Length];

            Array.Copy(bakeries, bakeries1, bakeries.Length);
            Array.Copy(bakeries, bakeries2, bakeries.Length);

            try
            {
                //10. Sort by calorie content
                bakeries1 = bakery.SortByCalories(bakeries1);

                //11. Sort by price content
                bakeries2 = bakery.SortByPrice(bakeries2);

                //12. Search for products that are equal in cost and calorie content
                bakeries3 = bakery.FilterByPriceAndColories(bakeries, (bakeries[0] ?? new BorodinskyBread(new List<Product> { new Flour() { ProductWeight = 1 }, new Water() { ProductWeight = 1 } })));


                //13. Search for products where the amount of use of a given ingredient is greater than the specified amount

                //The specified weight value
                double weight = 1.0;

                bakeries4 = bakery.FilterByIngridientWeight(bakeries, new Flour() { ProductWeight = weight });

                //14. Search for products where the number of ingredients is greater than the specified value
                bakeries5 = bakery.FilterByIngridientsCount(bakeries, 3);
            }
            catch (NullReferenceException) { }
        }
    }
}