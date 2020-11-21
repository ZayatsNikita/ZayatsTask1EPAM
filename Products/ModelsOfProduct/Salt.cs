using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsLib.ModelsOfProduct
{
    public class Salt : IProduct
    {
        private const decimal PricePerKilogramConst = 0.57M;
        private const double CalorificPerKilogramConst = 0;
        private const double ProductWeightConst = 0.3;
        public decimal PricePerKilogram => PricePerKilogramConst;

        public double CalorificPerKilogram => CalorificPerKilogramConst;

        public double ProductWeight => ProductWeightConst;
        
        public static bool IsSalt(decimal price, double colories, double weight)
        {
            return (price == PricePerKilogramConst && CalorificPerKilogramConst == colories && weight == ProductWeightConst);
        }
        public override bool Equals(object obj)
        {
            if (obj.GetType() == this.GetType())
            {
                IProduct product = (IProduct)obj;
                return IsSalt(product.PricePerKilogram, product.CalorificPerKilogram, product.ProductWeight);
            }
            return false;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(PricePerKilogramConst, CalorificPerKilogramConst, ProductWeightConst);
        }
        public override string ToString()
        {
            return ProductWeightConst.ToString() + " " + PricePerKilogramConst.ToString() + " " + CalorificPerKilogramConst.ToString();
        }
    }
}
