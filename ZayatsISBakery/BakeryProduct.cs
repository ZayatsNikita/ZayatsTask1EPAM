using System.Text;
using System.Collections.Generic;
using ProductsLib;
namespace BakeryLib
{
    public abstract class BakeryProduct : IBakeryProductManager
    {
        private decimal markUpForSale;

        public BakeryProduct()
        {
            this.MarkUpForSale = 10;
        }
        public BakeryProduct(decimal markUpForSale)
        {
            this.MarkUpForSale = markUpForSale;
        }
        public string Name { get; set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            
            result.Append($"Product: {this.GetType().Name};\n");

            int countOfIgredients = listOfIngredients.Count;
            int index = 0;

            foreach (KeyValuePair<Product, double> ingridient in listOfIngredients)
            {
                result.Append($"Ingredient {index}: {ingridient.Key.NameOfProduct}; Weight: {ingridient.Value};" +
                    $";Colories: {ingridient.Key.CalorificPerKilogram * ingridient.Value} Kkal, price: " +
                    $"{(decimal)ingridient.Value * ingridient.Key.PricePerKilogram}\n");
            }
            return result.ToString();
        }
        public Dictionary<Product, double> listOfIngredients;

        public decimal MarkUpForSale;
        public virtual double GetCaloric()
        {
            double res = 0;
            foreach (Product p in listOfIngredients.Keys)
            {
                res += (double)p.CalorificPerKilogram;
            }
            return res;
        }
        public virtual decimal GetPrice()
        {
            decimal res = 0;
            foreach (Product p in listOfIngredients.Keys)
            {
                res += p.PricePerKilogram;
            }
            return res;
        }

    }
}
