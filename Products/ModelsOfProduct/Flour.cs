using System;

namespace ProductsLib.ModelsOfProduct
{
    /// <summary>
    /// Class describing Flour
    /// </summary>
    public class Flour : Product
    {
        /// <summary>
        /// Constructor of the Flour class
        /// </summary>
        /// <param name="weight">product weight</param>
        /// <exception cref="System.ArgumentException">Throw when a negative weight is passed</exception>
        public Flour(double weight)
        {
            ProductWeight = weight;
        }
        public override decimal PricePerKilogram => 2.5M;

        public override double CalorificPerKilogram => 364;

        public override object Clone()
        {
            return new Flour(this.ProductWeight);
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
            return "Flour "+base.ToString();
        }
    }
}
