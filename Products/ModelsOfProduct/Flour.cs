using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsLib.ModelsOfProduct
{
    class Flour : Product
    {
        private const decimal PricePerKilogramConst = 2.5M;
        private const double CalorificPerKilogramConst = 364;
        private const double ProductWeightConst = 0.1;
        public override decimal PricePerKilogram => PricePerKilogramConst;

        public override double CalorificPerKilogram => CalorificPerKilogramConst;

        public override double ProductWeight => ProductWeightConst;

        public override bool Equals(object obj)
        {
            switch (obj)
            {
                case ProductInfo pInfo:
                    {
                        return ((pInfo.name == typeof(Cream).Name || pInfo.name == "Мука") && pInfo.price == PricePerKilogram && pInfo.colories == CalorificPerKilogram && pInfo.weight == ProductWeightConst);
                    }
                case Product product:
                    {
                        return (product.GetType().Name == typeof(Cream).Name && product.PricePerKilogram == PricePerKilogram && product.CalorificPerKilogram == CalorificPerKilogram && product.ProductWeight == ProductWeightConst);
                    }
                default:
                    return false;
            }
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
