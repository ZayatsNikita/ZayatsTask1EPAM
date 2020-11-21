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
        public static bool IsDataValid(string source, decimal price, double weight, double calories)
        {
            switch (source)
            {
                case "Eggs":
                    return (Eggs.IsEggs(price, calories, weight));
                case "Flour":
                    return (Flour.IsFlour(price, calories, weight));
                case "Meat":
                    return (Meat.IsMeat(price, calories, weight));
                case "Oil":
                    return (Oil.IsOil(price, calories, weight));
                case "Salt":
                    return (Salt.IsSalt(price, calories, weight));
                case "SourСream":
                    return (SourСream.IsSourСream(price, calories, weight));
                case "Water":
                    return (Water.IsWater(price, calories, weight));
                default:
                    return false;
            }
        }
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
