using System;

namespace ProductsLib.ModelsOfProduct
{
    /// <summary>
    /// Class describing Eggs
    /// </summary>
    public class Eggs : Product
    {
        /// <summary>
        /// Constructor of the Eggs class
        /// </summary>
        /// <param name="weight">product weight</param>
        /// <exception cref="System.ArgumentException">Throw when a negative weight is passed</exception>
        public Eggs(double weight)
        {
            ProductWeight = weight;
        }
        public override decimal PricePerKilogram => 2.22M;
        public override double CalorificPerKilogram => 155;

        public override object Clone()
        {
            return new Eggs(this.ProductWeight);
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
            return "Eggs " + base.ToString();
        }
    }
}
