﻿using System;

namespace BakeryLib.CategoriesOfBakeryProduct
{
    public class Bun : BakeryProduct
    {
        private int mandatoryExpenses;

        #region class constructor
        public Bun(int calorieCoefficient) : base(100)
        {
            mandatoryExpenses = calorieCoefficient;
        }
        public Bun(decimal markUpForSale, int mandatoryExpenses) : base(markUpForSale)
        {
            this.mandatoryExpenses = mandatoryExpenses;
        }
        #endregion


        public override double GetCaloric()
        {
            return base.GetCaloric();
        }

        public override decimal GetPrice()
        {
            return base.GetPrice() * markUpForSale + (decimal)mandatoryExpenses;
        }


        public override int GetHashCode()
        {
            return HashCode.Combine(base.GetHashCode(), Name, markUpForSale, mandatoryExpenses);
        }
        public override bool Equals(object obj)
        {
            if (obj is Bun p)
            {
                return (p.Name == Name && p.markUpForSale == markUpForSale && p.mandatoryExpenses == mandatoryExpenses);
            }
            else return false;
        }
    }
}