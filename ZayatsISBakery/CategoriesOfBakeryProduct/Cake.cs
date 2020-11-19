using System;
using System.Collections.Generic;
using System.Text;
using ProductsLib;
namespace BakeryLib.CategoriesOfBakeryProduct 
{
    public class Cake : BakeryProduct, ICloneable
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

        public object Clone()
        {
            Cake cake = new Cake(this.Name, this.markUpForSale, this.costOfServing);
            List<Product> products = this.listOfIngredients;
            foreach (Product p in products)
            {
                cake.listOfIngredients.Add((Product)p.Clone());
            }
            return cake;
        }


    }
}

