using BakeryLib.CategoriesOfBakeryProduct;
using ProductsLib;
using System;
using System.Collections.Generic;
using System.Text;

namespace BakeryLib.SubclassesOfCategoriesOfBakeryProducts.BreadSubClasses
{
    public class BorodinskyBread : Bread
    {
        public override void AddProduct(Product product)
        {
            base.AddProduct(product);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override double GetCaloric()
        {
            return base.GetCaloric();
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override decimal GetPrice()
        {
            return base.GetPrice();
        }

        public override string ToString()
        {
            return "Borodinsky" + base.ToString();
        }
    }
}
