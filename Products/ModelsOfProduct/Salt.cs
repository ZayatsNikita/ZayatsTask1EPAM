using System;

namespace ProductsLib.ModelsOfProduct
{
    /// <summary>
    /// Class describing Salt
    /// </summary>
    public class Salt : Product
    {
        /// <summary>
        /// Constructor of the Salt class
        /// </summary>
        /// <param name="weight">product weight</param>
        /// <exception cref="System.ArgumentException">Throw when a negative weight is passed</exception>

        public Salt(double weight)
        {
            ProductWeight = weight;
        }


        public override decimal PricePerKilogram => 0.57M;
        public override double CalorificPerKilogram => 0;

        public override object Clone()
        {
            return new Salt(this.ProductWeight);
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
            return "Salt "+ base.ToString();
        }
    }
}
