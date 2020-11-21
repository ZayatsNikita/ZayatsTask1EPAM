﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsLib.ModelsOfProduct
{
    public class Meat : IProduct
    {
        private const decimal PricePerKilogramConst = 6.42M;
        private const double CalorificPerKilogramConst = 242;

        public override decimal PricePerKilogram => PricePerKilogramConst;

        public override double CalorificPerKilogram => CalorificPerKilogramConst;

        public static bool IsMeat(decimal price, double colories, double weight)
        {
            return (price == PricePerKilogramConst && CalorificPerKilogramConst == colories && weight>0);
        }



        public override bool Equals(object obj)
        {
            if (obj.GetType() == this.GetType())
            {
                IProduct product = (IProduct)obj;
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
