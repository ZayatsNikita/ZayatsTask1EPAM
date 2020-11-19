using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using BakeryLib.CategoriesOfBakeryProduct;
using ProductsLib;

namespace BakeryLib
{
    class WorkWithFile
    {
        StreamReader streamReader;
        StreamWriter StreamWriter;

        public void GetData()
        {
            if (System.IO.File.Exists("data.txt"))
            {
                string getedString;
                Product product=null;
                BakeryProduct bakeryProduct=null;


                streamReader = new StreamReader("data.txt");
                while(!(( getedString = streamReader.ReadLine())==null))
                {
                    try
                    {
                        bakeryProduct = Bakery.CreateBakeryProduct(getedString);
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
            }
            else throw new NullReferenceException();
        }
        public void SetData()
        {
            if (System.IO.File.Exists("data.txt"))
            {
                streamReader = new StreamReader("data.txt");

            }
            else throw new NullReferenceException();
        }
    }
}
