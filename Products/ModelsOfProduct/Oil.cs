using System;

namespace ProductsLib.ModelsOfProduct
{
    /// <summary>
    /// Class describing Oil
    /// </summary>
    public class Oil : Product
    {

        /// <summary>
        /// Constructor of the Oil class
        /// </summary>
        /// <param name="weight">product weight</param>
        /// <exception cref="System.ArgumentException">Throw when a negative weight is passed</exception>

        public Oil(double weight)
        {
            ProductWeight = weight;
        }

        public override double CalorificPerKilogram => 717;
        public override decimal PricePerKilogram => 3.21M;
        public override bool Equals(object obj)
        {
            if (obj.GetType() == this.GetType())
            {
                Product product = (Product)obj;
                return ProductWeight == product.ProductWeight;
            }
            return false;
        }

        public override object Clone()
        {
            return new Meat(this.ProductWeight);
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(PricePerKilogram, CalorificPerKilogram, ProductWeight);
        }
        public override string ToString()
        {
            return "Oil "+ base.ToString();
        }
    }
}
