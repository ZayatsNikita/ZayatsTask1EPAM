using System;
using System.Collections.Generic;
using System.Text;

namespace BakeryLib.CategoriesOfBakeryProduct
{
    public class Cake : BakeryProduct
    {
        private int costOfServing;

        #region class constructor
        public Cake(int costOfServing) : base(100)
        {
            this.costOfServing = costOfServing;
        }
        public Cake(decimal markUpForSale, int costOfServing) : base(markUpForSale)
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
            if (obj is Cake p)
            {
                return (p.Name == Name && p.MarkUpForSale == MarkUpForSale && p.costOfServing == costOfServing);
            }
            else return false;
        }


    }
}

