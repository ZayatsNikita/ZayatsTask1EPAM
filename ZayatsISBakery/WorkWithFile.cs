using ProductsLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Reflection;
using System.Linq;

namespace BakeryLib
{
    public static class WorkWithFile
    {
        public static void GetData(out BakeryProduct[] array)
        {
            Regex productRegex = new Regex(@"(?<Product>[a-zA-Z]+)\s+(?<ProductType>[a-zA-Z]+|[""a-zA-Z""]+)\s+(?<CountOfProduct>\d+)+\s+pieces{1}");
            Regex ingreedientRegex = new Regex(@"(?<Params>\S+)\s+(?<Weight>\d+[,.]\d+|\d+)\s+kg\s+(?<Price>\d+[,.]\d+|\d+)\s+[pr$]\s+(?<Power>\d+[,.]\d+|\d+)\s+(kkal){1}");
            StreamReader streamReader;

            List<BakeryProduct> resultList = new List<BakeryProduct>();

            if (System.IO.File.Exists(@"D:\Learn\EPAM\ZayatsTask1EPAM\ZayatsISBakery\text.txt"))
            {
                string getedString, baceryProduct = null;

                List<IProduct> keeper = new List<IProduct>();

                double weight = 0, calories = 0;
                decimal price = 0;

                streamReader = new StreamReader(@"D:\Learn\EPAM\ZayatsTask1EPAM.copy\ZayatsISBakery\text.txt");

                bool createList = false;

                while (!((getedString = streamReader.ReadLine()) == null))
                {
                    if (IsProduct(ref getedString, productRegex))
                    {
                        if (keeper.Count != 0)
                        {
                            resultList.Add(Bakery.CreateBakeryProduct(baceryProduct, keeper));
                            keeper = new List<IProduct>();
                        }
                        baceryProduct = getedString;
                        createList = true;
                    }

                    else
                    {
                        if (createList)
                        {
                            if (IsIngredient(ref getedString, ingreedientRegex, ref weight, ref calories, ref price))
                            {
                                try
                                {
                                    if (ProductFabrica.IsDataValid(getedString, price, weight,calories))
                                        keeper.Add(ProductFabrica.CreateProduct(getedString,weight));
                                }
                                catch (NullReferenceException) { }
                                catch (ArgumentException) { }
                                catch { }
                            }
                            else
                            {
                            }
                        }

                    }

                    
                }
                if (keeper.Count != 0)
                    resultList.Add(Bakery.CreateBakeryProduct(baceryProduct, keeper));
            }
            else
                throw new FileNotFoundException();
            if (resultList.Count != 0)
                array = resultList.ToArray();
            else
                array = null;

        }
        public static bool IsProduct(ref string source, Regex regex)
        {
            Match match1 = regex.Match(source);
            if (match1.Success)
            {
                source = match1.Groups["ProductType"].Value.Replace("\"","")+match1.Groups["Product"].Value;
                Console.WriteLine(match1.Groups["Product"].Value + "   " + match1.Groups["ProductType"].Value + "  " + match1.Groups["CountOfProduct"]);
                return true;
            }
            return false;
        }
        public static bool IsIngredient(ref string source, Regex regex, ref double weight, ref double colories, ref decimal price)
        {
            Match match2 = regex.Match(source);
            {
                if(match2.Success)
                {
                    source = match2.Groups["Params"].Value;
                    weight = Double.Parse(match2.Groups["Weight"].Value);
                    colories = Double.Parse(match2.Groups["Power"].Value);
                    price = Decimal.Parse(match2.Groups["Price"].Value);
                    return true;
                }
            }
                return false;
            
        }

    }
}
