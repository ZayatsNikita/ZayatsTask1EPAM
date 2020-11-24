using System;
namespace ProductsLib
{
    /// <summary>
    /// Base class for Products
    /// </summary>
    public abstract class Product: ICloneable
    {

        private double _productWeight;
        /// <summary>The PricePerKilogram property represents price per kilogram of product</summary>
        public abstract decimal PricePerKilogram { get; }
        /// <summary> The CalorificPerKilogram property represents numbers of calories per kilogram of product</summary>
        public abstract double CalorificPerKilogram { get; }
        /// <summary>The ProductWeight property represents the weight of product.</summary>
        /// <exception cref="System.ArgumentException">Throw when a negative weight is passed</exception>
        public virtual double ProductWeight
        {
            get
            {
                return _productWeight;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("An attempt was made to assign a negative or null weight to the product");
                }
                else
                {
                    _productWeight = value;
                }
            }
        }

        public abstract object Clone();

        public override string ToString()
        {
            return $"{this.ProductWeight} kg  {this.PricePerKilogram} p {this.CalorificPerKilogram} kkal";
        }

    }
}
