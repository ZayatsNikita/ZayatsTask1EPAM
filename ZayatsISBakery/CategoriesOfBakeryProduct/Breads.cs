using System;
using System.Collections.Generic;
using System.Text;

namespace BakeryLib.CategoriesOfBakeryProduct
{
    public class Breads : BakeryProduct
    {

        private int calorieCoefficient;

        #region class constructor
        public Breads(int calorieCoefficient) : base(100)
        {
            this.calorieCoefficient = calorieCoefficient;
        }
        public Breads(decimal markUpForSale, int calorieCoefficient) : base(markUpForSale)
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
            return base.GetPrice() * MarkUpForSale;
        }


        public override bool Equals(object obj)
        {
            if (obj is Pies p)
            {
                return (p.Name == this.Name);
            }
            else
            {
                return false;
            }
        }
    }
}
