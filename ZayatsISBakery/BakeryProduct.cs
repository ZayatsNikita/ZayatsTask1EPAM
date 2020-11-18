using System.Text.RegularExpressions;
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

            for (index = 0; index < countOfIgredients; index++)
            {
                result.Append($"Ingredient {index}: {listOfIngredients[index].NameOfProduct}; Weight: {listOfIngredients[index].ProductWeight};" +
                    $";Colories: {listOfIngredients[index].CalorificPerKilogram * listOfIngredients[index].ProductWeight} Kkal, price: " +
                    $"{(decimal)listOfIngredients[index].ProductWeight * listOfIngredients[index].PricePerKilogram}\n");
            }
            return result.ToString();
        }
        public List<Product> listOfIngredients;

        public decimal MarkUpForSale;
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
        
    }
}
