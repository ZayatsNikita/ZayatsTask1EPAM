using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsLib.ModelsOfProduct
{
    /// <summary>
    /// Class describing Flour
    /// </summary>
    public class Flour : Product
    {
        private const decimal PricePerKilogramConst = 2.5M;
        private const double CalorificPerKilogramConst = 364;
       
        
        
        public override decimal PricePerKilogram => PricePerKilogramConst;

        public override double CalorificPerKilogram => CalorificPerKilogramConst;

        public static bool IsFlour(decimal price, double colories, double weight)
        {
            return (price == PricePerKilogramConst && CalorificPerKilogramConst == colories && weight >0);
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

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
