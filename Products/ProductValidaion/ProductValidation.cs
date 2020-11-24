using ProductsLib.ModelsOfProduct;
using System;
namespace ProductsLib.ProductValidaion
{
    /// <summary>
    /// The class checks data for compliance with a specific product
    /// </summary>
    public class ProductValidation
    {
        static private Product[] _allProducts = new Product[] {new Eggs(10.0), new Flour(10.0),new Meat(10.0),new Oil(10.0), new Salt(10), new SourСream(10), new Water(10) };
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
                    return DataValidationForSpecificProduct(0,price, weight, calories);
                case "Flour":
                    return DataValidationForSpecificProduct(1, price, weight, calories);
                case "Meat":
                    return DataValidationForSpecificProduct(2, price, weight, calories);
                case "Oil":
                    return DataValidationForSpecificProduct(3, price, weight, calories);
                case "Salt":
                    return DataValidationForSpecificProduct(4, price, weight, calories);
                case "SourCream":
                    return DataValidationForSpecificProduct(5, price, weight, calories);
                case "Water":
                    return DataValidationForSpecificProduct(6, price, weight, calories);
                default:
                    return false;
            }
        }

        /// <summary>
        /// Compares the transmitted data with the data of the corresponding product
        /// </summary>
        /// <param name="num">Product index in the product array</param>
        /// <param name="price">Price of 1 kilogram of product</param>
        /// <param name="weight">Product weight</param>
        /// <param name="calories">number of calories in 1 kilogram of product</param>
        /// <returns>true if all data matches the data of the specified product, false otherwise</returns>
        static private bool DataValidationForSpecificProduct(int num, decimal price, double weight, double calories)
        {
            return (_allProducts[num].PricePerKilogram==price && _allProducts[num].CalorificPerKilogram==calories && weight >0);
        }
    }
}
