using System;
using System.Collections.Generic;
using System.Text;

namespace BakeryLib.CategoriesOfBakeryProduct
{
    public class Cakes : BakeryProduct
    {
        private int costOfServing;

        #region class constructor
        public Cakes(int costOfServing) : base(100)
        {
            this.costOfServing = costOfServing;
        }
        public Cakes(decimal markUpForSale, int costOfServing) : base(markUpForSale)
        {
            this.costOfServing = costOfServing;
        }
        #endregion



        public override double GetCaloric()
        {
            return base.GetCaloric();
        }

        public override decimal GetPrice()
        {
            return base.GetPrice() * MarkUpForSale + costOfServing;
        }


        public override int GetHashCode()
        {
            return HashCode.Combine(base.GetHashCode(), Name, MarkUpForSale, costOfServing);
        }
        public override bool Equals(object obj)
        {
            if (obj is Cakes p)
            {
                return (p.Name == Name && p.MarkUpForSale == MarkUpForSale && p.costOfServing == costOfServing);
            }
            else return false;
        }


    }
}

