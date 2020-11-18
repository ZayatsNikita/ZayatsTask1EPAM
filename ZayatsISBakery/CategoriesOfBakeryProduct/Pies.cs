using ProductsLib;
using System;

namespace BakeryLib.CategoriesOfBakeryProduct
{
    public class Pies : BakeryProduct
    {

        private int priceCoeficient;

        #region class constructor
        public Pies(int priceCoeficient) : base(100)
        {
            this.priceCoeficient = priceCoeficient;
        }
        public Pies(decimal markUpForSale, int priceCoeficient) : base(markUpForSale)
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
            return base.GetPrice() * MarkUpForSale * (decimal)priceCoeficient;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(base.GetHashCode(), Name, listOfIngredients, MarkUpForSale, priceCoeficient);
        }
        public override bool Equals(object obj)
        {
            if (obj is Pies p)
            {
                return (p.Name == Name && p.MarkUpForSale == MarkUpForSale && p.priceCoeficient == priceCoeficient);
            }
            else return false;
        }
    }
}
