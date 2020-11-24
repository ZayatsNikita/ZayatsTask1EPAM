using System;

namespace ProductsLib.ModelsOfProduct
{
    /// <summary>
    /// Class describing Water
    /// </summary>
    public class Water : Product
    {
        /// <summary>
        /// Constructor of the Water class
        /// </summary>
        /// <param name="weight">product weight</param>
        /// <exception cref="System.ArgumentException">Throw when a negative weight is passed</exception>
        public Water(double weight)
        {
            ProductWeight = weight;
        }
        public override decimal PricePerKilogram => 0.46M;
        public override double CalorificPerKilogram => 0;

        public override object Clone()
        {
            return new Water(this.ProductWeight);
        }
        public override string ToString()
        {
            return "Water "+base.ToString();
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
    }
}
