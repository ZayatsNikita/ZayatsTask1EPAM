using System;

namespace ProductsLib.ModelsOfProduct
{
    /// <summary>
    /// Class describing Meat
    /// </summary>
    public class Meat : Product
    {
        /// <summary>
        /// Constructor of the Meat class
        /// </summary>
        /// <param name="weight">product weight</param>
        /// <exception cref="System.ArgumentException">Throw when a negative weight is passed</exception>
        public Meat(double weight)
        {
            ProductWeight = weight;
        }

        public override decimal PricePerKilogram => 6.42M;

        public override double CalorificPerKilogram => 242;

        public override object Clone()
        {
            return new Meat(this.ProductWeight);
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
            return "Meat " + base.ToString();
        }
    }
}
