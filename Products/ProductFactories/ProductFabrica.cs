using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using ProductsLib.ModelsOfProduct;
namespace ProductsLib
{

    public static class ProductFabrica
    {
        
        public static IProduct CreateProduct(string source, double weight)
        {
            switch (source)
            {
                case "Eggs":
                    return new Eggs() { ProductWeight = weight };
                case "Flour":
                    return new Flour() { ProductWeight = weight }; ;
                case "Meat":
                    return new Meat() { ProductWeight = weight }; ;
                case "Oil":
                    return new Oil() { ProductWeight = weight }; ;
                case "Salt":
                    return new Salt() { ProductWeight = weight }; ;
                case "SourСream":
                    return new SourСream() { ProductWeight = weight }; ;
                case "Water":
                    return new Water() { ProductWeight = weight }; ;
                default:
                    throw new ArgumentException("The specified string is not in the correct format");
            }
        }
    }
}
