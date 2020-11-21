using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsLib.ModelsOfProduct
{
    public class Flour : IProduct
    {
        private const decimal PricePerKilogramConst = 2.5M;
        private const double CalorificPerKilogramConst = 364;
        private const double ProductWeightConst = 0.1;
        public decimal PricePerKilogram => PricePerKilogramConst;

        public double CalorificPerKilogram => CalorificPerKilogramConst;

        public double ProductWeight => ProductWeightConst;
        public static bool IsFlour(decimal price, double colories, double weight)
        {
            return (price == PricePerKilogramConst && CalorificPerKilogramConst == colories && weight == ProductWeightConst);
        }
        public override bool Equals(object obj)
        {
            if (obj.GetType() == this.GetType())
            {
                IProduct product = (IProduct)obj;
                return IsFlour(product.PricePerKilogram, product.CalorificPerKilogram, product.ProductWeight);
            }
            return false;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(PricePerKilogramConst, CalorificPerKilogramConst, ProductWeightConst); ;
        }
        
        public override string ToString()
        {
            return ProductWeightConst.ToString() + " " + PricePerKilogramConst.ToString() + " " + CalorificPerKilogramConst.ToString();
        }
    }
}
