using ProductsLib;
using System;
using System.Collections.Generic;
using System.IO;

namespace BakeryLib
{
    public static class WorkWithFile
    {
        public static void GetData(out BakeryProduct[] array)
        {
            StreamReader streamReader;
            if (System.IO.File.Exists(@"D:\Learn\EPAM\ZayatsTask1EPAM\ZayatsISBakery\text.txt"))
            {
                string getedString;
                array = null;
                BakeryProduct bakeryProduct=null;
                List<BakeryProduct> resultList= new List<BakeryProduct>();

                streamReader = new StreamReader(@"D:\Learn\EPAM\ZayatsTask1EPAM\ZayatsISBakery\text.txt");

                //Filling in the list
                while (!(( getedString = streamReader.ReadLine())==null))
                {
                    try
                    {
                        bakeryProduct = Bakery.CreateBakeryProduct(getedString);
                        resultList.Add(bakeryProduct);
                    }
                    catch(Exception ex)
                    {
                            if (bakeryProduct != null)
                            {
                                try
                                {
                                    bakeryProduct.AddProduct(ProductFabrica.CreateProduct(getedString));
                                }
                                catch(NullReferenceException except)
                                { }
                                catch(ArgumentException except)
                                { }
                            }
                        }
                }

                //Checking recipes with zero ingredients
                for (int index = 0; index < resultList.Count; index++)
                {
                    if (resultList[index].listOfIngredients.Count == 0)
                        resultList.Remove(resultList[index]);
                    index--;
                }

                //Transferring data from a list to an array
                if (resultList.Count!=0)
                {
                    array = new BakeryProduct[resultList.Count];
                    for (int index = 0; index < resultList.Count; index++)
                    {
                        array[index] = resultList[index];
                    }
                }

                streamReader.Close();
            }
            else throw new NullReferenceException();
        }
        
    }
}
