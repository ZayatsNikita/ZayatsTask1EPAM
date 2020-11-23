using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsLib.ModelsOfProduct
{
    /// <summary>
    /// Class describing Water
    /// </summary>
    public class Water : Product
    {
        private const decimal PricePerKilogramConst = 0.46M;
        private const double CalorificPerKilogramConst = 0;
  
        public override decimal PricePerKilogram => PricePerKilogramConst;
        public override double CalorificPerKilogram => CalorificPerKilogramConst;

        /// <summary>
        /// This method checks the product for matching parameters
        /// </summary>
        /// <param name="price">Describes the price of 1 kg of the product</param>
        /// <param name="colories">Describes the number of calories in 1 kg of the product</param>
        /// <param name="weight">Describes the weight of the product</param>
        /// <returns>True if these parameters match the product</returns>
        public static bool IsWater(decimal price, double colories, double weight)
        {
            return (price == PricePerKilogramConst && CalorificPerKilogramConst == colories && weight >0);
        }
        
        public override string ToString()
        {
            return base.ToString();
        }
        public override bool Equals(object obj)
        {
            if (obj.GetType() == this.GetType())
            {
                Product product = (Product)obj;
                return ProductWeight == product.ProductWeight;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(PricePerKilogramConst, CalorificPerKilogramConst, ProductWeight);
        }
    }
}
