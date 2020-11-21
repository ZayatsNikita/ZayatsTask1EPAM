using System;
using System.Text.RegularExpressions;
using System.Text;
namespace ProductsLib
{
    public abstract class IProduct
    {

        private double _productWeight;
        public abstract decimal PricePerKilogram { get; }

        public abstract double CalorificPerKilogram { get; }

        public double ProductWeight
        {
            get
            {
                return _productWeight;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The product weight is incorrect");
                }
                else
                {
                    _productWeight = value;
                }
            }
        }


    }
}
