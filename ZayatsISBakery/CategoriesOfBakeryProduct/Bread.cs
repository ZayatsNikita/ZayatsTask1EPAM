using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;

namespace BakeryLib.CategoriesOfBakeryProduct
{
    public class Bread : BakeryProduct
    {

        private int calorieCoefficient;

        #region class constructor
        public Bread(int calorieCoefficient) : base(100)
        {
            this.calorieCoefficient = calorieCoefficient;
        }
        public Bread(decimal markUpForSale, int calorieCoefficient) : base(markUpForSale)
        {
            this.calorieCoefficient = calorieCoefficient;
        }
        #endregion


        public override double GetCaloric()
        {
            return base.GetCaloric() * calorieCoefficient;
        }

        public override decimal GetPrice()
        {
            return base.GetPrice() * markUpForSale;
        }


        public override int GetHashCode()
        {
            return HashCode.Combine(base.GetHashCode(), Name, markUpForSale, calorieCoefficient);
        }
        public override bool Equals(object obj)
        {
            if (obj is Bread p)
            {
                return (p.Name == Name && p.markUpForSale == markUpForSale && p.calorieCoefficient == calorieCoefficient);
            }
            else return false;
        }
    }
}
