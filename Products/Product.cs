using System;
using System.Text.RegularExpressions;
using System.Text;
namespace ProductsLib
{
    /// <summary>
    /// Base class for Products
    /// </summary>
    public abstract class Product
    {

        private double _productWeight;
        /// <summary>The PricePerKilogram property represents price per kilogram of product</summary>
        public abstract decimal PricePerKilogram { get; }
        /// <summary> The CalorificPerKilogram property represents numbers of calories per kilogram of product</summary>
        public abstract double CalorificPerKilogram { get; }
        /// <summary>The ProductWeight property represents the weight of product.</summary>
        /// <exception cref="System.ArgumentException">Throw when a negative weight is passed</exception>
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

        public override string ToString()
        {
            return $"{this.GetType().Name}: Weight: {this.ProductWeight}; Calories: {this.CalorificPerKilogram * this.ProductWeight} Kkal; Price:{(decimal)this.ProductWeight * this.PricePerKilogram}";
        }
    }
}
