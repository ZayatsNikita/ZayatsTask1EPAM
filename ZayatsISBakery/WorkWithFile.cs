using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using BakeryLib.CategoriesOfBakeryProduct;
using ProductsLib;

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
                Product product=null;
                array = null;
                BakeryProduct bakeryProduct=null;
                List<BakeryProduct> resultList= new List<BakeryProduct>();

                streamReader = new StreamReader(@"D:\Learn\EPAM\ZayatsTask1EPAM\ZayatsISBakery\text.txt");
                while(!(( getedString = streamReader.ReadLine())==null))
                {
                    try
                    {
                        bakeryProduct = Bakery.CreateBakeryProduct(getedString);
                        resultList.Add(bakeryProduct);
                    }
                    catch(Exception ex)
                    {
                        if(Product.TryParse(getedString, out product))
                        {
                            if (bakeryProduct != null)
                            {
                                bakeryProduct.AddProduct(product);
                            }
                        }
                    }
                }
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
