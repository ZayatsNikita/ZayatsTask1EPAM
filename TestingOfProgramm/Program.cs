using System;
using BakeryLib.CategoriesOfBakeryProduct;
using ProductsLib;
using BakeryLib;
using BakeryLib.Interfaces;
using System.Linq;

namespace TestingOfProgramm
{
    class Program
    {
        static void Main(string[] args)
        {
            BakeryProduct[] bakeries = null, bakeries1,bakeries2;
            WorkWithFile.GetData(out bakeries);
            
            bakeries1 = new BakeryProduct[bakeries.Length];
            bakeries2 = new BakeryProduct[bakeries.Length];

            Array.Copy(bakeries,bakeries1,bakeries.Length);
            Array.Copy(bakeries,bakeries2,bakeries.Length);

            //bakeries1.OrderBy(x => x.GetPrice);
        }
    }
}
