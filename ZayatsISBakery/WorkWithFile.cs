using ProductsLib;
using System;
using System.Collections.Generic;
using System.IO;
using ProductsLib.ProductValidaion;
using BakeryLib.Validaion;


namespace BakeryLib
{
    public static class WorkWithFile
    {
        public static void GetData(out BakeryProduct[] array)
        {

            StreamReader streamReader;

            List<BakeryProduct> resultList = new List<BakeryProduct>();

            if (System.IO.File.Exists(@"D:\Learn\EPAM\ZayatsTask1EPAM.copy\ZayatsISBakery\text.txt"))
            {
                string getedString, baceryProduct = null;

                List<IProduct> keeper = new List<IProduct>();

                double weight = 0, calories = 0;
                decimal price = 0;

                streamReader = new StreamReader(@"D:\Learn\EPAM\ZayatsTask1EPAM.copy\ZayatsISBakery\text.txt");

                bool createList = false;

                while (!((getedString = streamReader.ReadLine()) == null))
                {
                    if (Validation.IsProduct(ref getedString))
                    {
                        if (keeper.Count != 0)
                        {
                            try
                            {
                                resultList.Add(Bakery.CreateBakeryProduct(baceryProduct, keeper));
                            }
                            catch (ArgumentException) { }
                            finally
                            {
                                keeper = new List<IProduct>();
                            }
                        }
                        baceryProduct = getedString;
                        createList = true;
                    }
                    else
                    {
                        if (createList)
                        {
                            if (Validation.IsIngredient(ref getedString, ref weight, ref calories, ref price))
                            {
                                try
                                {
                                    if (ProductValidation.IsDataValid(getedString, price, weight,calories))
                                        keeper.Add(ProductFabrica.CreateProduct(getedString,weight));
                                }
                                catch (NullReferenceException) { }
                                catch (ArgumentException) { }
                                catch { }
                            }
                        }
                    }
                }
                if (keeper.Count != 0)
                    resultList.Add(Bakery.CreateBakeryProduct(baceryProduct, keeper));
            }
            else
                throw new FileNotFoundException();
                array = resultList.ToArray();
           

        }
        
    }
}
