using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsLib.ModelsOfProduct
{
    public class Oil : IProduct
    {
        private const decimal PricePerKilogramConst = 3.21M;
        private const double CalorificPerKilogramConst = 717;
        private const double ProductWeightConst = 0.1;
        public decimal PricePerKilogram => PricePerKilogramConst;

        public double CalorificPerKilogram => CalorificPerKilogramConst;

        public double ProductWeight => ProductWeightConst;
        public static bool IsOil(decimal price, double colories, double weight)
        {
            return (price == PricePerKilogramConst && CalorificPerKilogramConst == colories && weight == ProductWeightConst);
        }
        public override bool Equals(object obj)
        {
            if (obj.GetType() == this.GetType())
            {
                IProduct product = (IProduct)obj;
                return IsOil(product.PricePerKilogram, product.CalorificPerKilogram, product.ProductWeight);
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
