using System;
using System.Collections.Generic;
using ProductsLib;
using System.Text.RegularExpressions;
using System.Text;

namespace BakeryLib.CategoriesOfBakeryProduct
{
    public class Bread : BakeryProduct, ICloneable
    {

        private int calorieCoefficient;

        #region class constructor
        public Bread(string name, int calorieCoefficient) : base(name, 100)
        {
            this.calorieCoefficient = calorieCoefficient;
        }
        public Bread(string name, decimal markUpForSale, int calorieCoefficient) : base(name, markUpForSale)
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

        public object Clone()
        {
            Bread bread =  new Bread(this.Name,this.markUpForSale,this.calorieCoefficient);
            List <Product> products = this.listOfIngredients;
            foreach(Product p in products)
            {
                bread.listOfIngredients.Add((Product)p.Clone());
            }
            return bread;
        }
    }
}
