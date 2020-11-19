using ProductsLib;
using System;

namespace BakeryLib.CategoriesOfBakeryProduct
{
    public class Pie : BakeryProduct
    {

        private int priceCoeficient;

        #region class constructor
        public Pie(string name, int priceCoeficient) : base(name, 100)
        {
            this.priceCoeficient = priceCoeficient;
        }
        public Pie(string name, decimal markUpForSale, int priceCoeficient) : base(name, markUpForSale)
        {
     
            this.priceCoeficient = priceCoeficient;
        }
        #endregion


        public override double GetCaloric()
        {
            return base.GetCaloric();
        }
        
        
        public override decimal GetPrice()
        {
            return base.GetPrice() * markUpForSale * (decimal)priceCoeficient;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(base.GetHashCode(), Name, markUpForSale, priceCoeficient);
        }
        public override bool Equals(object obj)
        {
            if (obj is Pie p)
            {
                return (p.Name == Name && p.markUpForSale == markUpForSale && p.priceCoeficient == priceCoeficient);
            }
            else return false;
        }
    }
}
