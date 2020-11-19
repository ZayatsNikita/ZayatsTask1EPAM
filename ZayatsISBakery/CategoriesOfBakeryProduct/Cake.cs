using System;
using System.Collections.Generic;
using System.Text;

namespace BakeryLib.CategoriesOfBakeryProduct
{
    public class Cake : BakeryProduct
    {
        private int costOfServing;

        #region class constructor
        public Cake(string name,int costOfServing) : base(name, 100)
        {
            this.costOfServing = costOfServing;
        }
        public Cake(string name, decimal markUpForSale, int costOfServing) : base(name, markUpForSale)
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
            return base.GetPrice() * markUpForSale + costOfServing;
        }


        public override int GetHashCode()
        {
            return HashCode.Combine(base.GetHashCode(), Name, markUpForSale, costOfServing);
        }
        public override bool Equals(object obj)
        {
            if (obj is Cake p)
            {
                return (p.Name == Name && p.markUpForSale == markUpForSale && p.costOfServing == costOfServing);
            }
            else return false;
        }


    }
}

