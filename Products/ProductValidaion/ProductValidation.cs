using ProductsLib.ModelsOfProduct;
using System;
namespace ProductsLib.ProductValidaion
{
    /// <summary>
    /// The class checks data for compliance with a specific product
    /// </summary>
    public class ProductValidation
    {
        /// <summary>
        /// Static method wich checks data for compliance with a specific product
        /// </summary>
        /// <param name="source">Represents the product name</param>
        /// <param name="price">Represents the cost of 1 kg of product</param>
        /// <param name="weight">Represents the product weight</param>
        /// <param name="calories">Represents the caloric content of 1 kg of product</param>
        /// <returns>True if the data matches the product, false in other situations</returns>
        public static bool IsDataValid(string source, decimal price, double weight, double calories)
        {
            switch (source ?? "null")
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
            
        }
    }
}
