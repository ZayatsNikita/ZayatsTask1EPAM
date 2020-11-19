using System;
using ProductsLib;
using System.Collections.Generic;
namespace BakeryLib.CategoriesOfBakeryProduct
{
    public class Bun : BakeryProduct, ICloneable
    {
        private int mandatoryExpenses;

        #region class constructor
        public Bun(string name, int calorieCoefficient) : base(name, 100)
        {
            mandatoryExpenses = calorieCoefficient;
        }
        public Bun(string name, decimal markUpForSale, int mandatoryExpenses) : base(name ,markUpForSale)
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

        public object Clone()
        {
            Bun bun = new Bun(this.Name, this.markUpForSale, this.mandatoryExpenses);
            List<Product> products = this.listOfIngredients;
            foreach (Product p in products)
            {
                bun.listOfIngredients.Add((Product)p.Clone());
            }
            return bun;
        }
    }
}
