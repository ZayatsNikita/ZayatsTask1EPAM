using ProductsLib;
using System;
using System.Collections.Generic;
using System.IO;
using ProductsLib.ProductValidaion;
using BakeryLib.Validaion;


namespace BakeryLib
{   /// <summary>
    ///a class that allows you to load
    ///data about bakery products from a text file to an array
    /// </summary>
    public static class WorkWithFile
    {
        /// <summary>
        /// Static method that extracts data from a file
        /// </summary>
        /// <param name="array">Array where the extracted bakery products will be placed</param>
        /// <exception cref="System.FileNotFoundException">Thrown if you can't get access to the file</exception>
        /// <returns>Array with the received elements
        /// <para>If the baking data cannot be extracted from the file or a read
        /// error occurs from the file, a zero-length array is returned</para>
        /// </returns>
        public static void GetData(out BakeryProduct[] array)
        {

            StreamReader streamReader;

            List<BakeryProduct> resultList = new List<BakeryProduct>();
            array = new BakeryProduct[0];
            if (System.IO.File.Exists(@"D:\Learn\EPAM\ZayatsTask1EPAM.copy\ZayatsISBakery\text.txt"))
            {
                string getedString, baceryProduct = null;

                List<Product> keeper = new List<Product>();

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
                                keeper = new List<Product>();
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
