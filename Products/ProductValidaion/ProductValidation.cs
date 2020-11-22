using ProductsLib.ModelsOfProduct;
using System;
namespace ProductsLib.ProductValidaion
{
    public class ProductValidation
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
                case "SourCream":
                    return (SourСream.IsSourСream(price, calories, weight));
                case "Water":
                    return (Water.IsWater(price, calories, weight));
                default:
                    return false;
            }
            throw new NullReferenceException("String dosent set");
        }
    }
}
