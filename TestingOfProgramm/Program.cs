using System;
using BakeryLib.CategoriesOfBakeryProduct;
using ProductsLib;
using BakeryLib;
using ProductsLib.ModelsOfProduct;
using System.Collections.Generic;
using BakeryLib.SubclassesOfCategoriesOfBakeryProducts.BreadSubClasses;

namespace TestingOfProgramm
{
    class Program
    {
        static void Main(string[] args)
        {
            Bakery bakery = new Bakery();

            BakeryProduct[] bakeries = null, bakeries1, bakeries2;
            WorkWithFile.GetData(out bakeries);

            bakeries1 = new BakeryProduct[bakeries.Length];
            bakeries2 = new BakeryProduct[bakeries.Length];

            Array.Copy(bakeries, bakeries1, bakeries.Length);
            Array.Copy(bakeries, bakeries2, bakeries.Length);


            bakeries1 = bakery.SortByCalories(bakeries1);
            bakeries2 = bakery.SortByPrice(bakeries2);

            BakeryProduct[] equalsBakeryProduct = bakery.FilterByPriceAndColories(bakeries, new KupalovskyBread() 
            {NecessaryIngredients =new List<IProduct>()
            {
                new Eggs() {ProductWeight=0.1},
                new Flour(){ProductWeight=0.1},
                new Oil(){ ProductWeight=0.1},
                new Salt(){ProductWeight=0.3}
            }
            });

            BakeryProduct[] ingredientWeightBakeryProduct = bakery.FilterByIngridientWeight(bakeries, new Flour() {ProductWeight = 1.0 });

            BakeryProduct[] ingredientCountBakeryProduct = bakery.FilterByIngridientsCount(bakeries,3);

            Console.WriteLine("hello");
        }
    }
}
