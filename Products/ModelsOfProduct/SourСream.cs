using System;

namespace ProductsLib.ModelsOfProduct
{
    /// <summary>
    /// Class describing SourСream
    /// </summary>
    public class SourСream : Product
    {
        /// <summary>
        /// Constructor of the SourСream class
        /// </summary>
        /// <param name="weight">product weight</param>
        /// <exception cref="System.ArgumentException">Throw when a negative weight is passed</exception>
        public SourСream(double weight)
        {
            ProductWeight = weight;
        }
        public override decimal PricePerKilogram => 6.82M;
        public override double CalorificPerKilogram => 275.3;

        public override object Clone()
        {
            return new SourСream(this.ProductWeight);
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
            return HashCode.Combine(PricePerKilogram, CalorificPerKilogram, ProductWeight);
        }
        public override string ToString()
        {
            return "SourСream "+base.ToString();
        }
    }
}
