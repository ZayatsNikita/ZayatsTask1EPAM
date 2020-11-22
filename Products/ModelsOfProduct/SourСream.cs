using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsLib.ModelsOfProduct
{
    public class SourСream : Product
    {
        private const decimal PricePerKilogramConst = 6.82M;
        private const double CalorificPerKilogramConst = 275.3;

        public override decimal PricePerKilogram => PricePerKilogramConst;
        public override double CalorificPerKilogram => CalorificPerKilogramConst;


        public static bool IsSourСream(decimal price, double colories,double weight)
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
            return ProductWeight.ToString() + " " + PricePerKilogramConst.ToString() + " " + CalorificPerKilogramConst.ToString();
        }
    }
}
