using System.Text.RegularExpressions;
using System.Text;
using System.Collections.Generic;
using ProductsLib;
using System;

namespace BakeryLib
{
    public abstract class BakeryProduct : IBakeryProductManager
    {
        public BakeryProduct(string name)
        {
            this.Name = name;
            this.markUpForSale = 10;
        }
        public BakeryProduct(string name, decimal markUpForSale)
        {
            this.Name = name;
            this.markUpForSale = markUpForSale;
        }
        public string Name { get; set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            
            result.Append($"Product: {this.GetType().Name};\n");

            int countOfIgredients = listOfIngredients.Count;
            int index = 0;

            for (index = 0; index < countOfIgredients; index++)
            {
                result.Append($"Ingredient {index}: {listOfIngredients[index].NameOfProduct}; Weight: {listOfIngredients[index].ProductWeight};" +
                    $";Colories: {listOfIngredients[index].CalorificPerKilogram * listOfIngredients[index].ProductWeight} Kkal, price: " +
                    $"{(decimal)listOfIngredients[index].ProductWeight * listOfIngredients[index].PricePerKilogram}\n");
            }
            return result.ToString();
        }
        public List<Product> listOfIngredients { get; set; } = new List<Product>();

        public decimal markUpForSale;
        public virtual double GetCaloric()
        {
            double res = 0;
            foreach (Product p in listOfIngredients)
            {
                res += (double)p.CalorificPerKilogram;
            }
            return res;
        }
        public virtual decimal GetPrice()
        {
            decimal res = 0;
            foreach (Product p in listOfIngredients)
            {
                res += p.PricePerKilogram;
            }
            return res;
        }
        public virtual void AddProduct(Product product)
        {
            if(product!=null)
                listOfIngredients.Add(product);
        }
    }
}
