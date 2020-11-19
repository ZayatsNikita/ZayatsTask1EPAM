using System;
using System.Text.RegularExpressions;
using System.Text;
namespace ProductsLib
{
    //Переименовать поля
    public class Product
    {

        private decimal pricePerKilogram;
        private double calorificPerKilogram;
        private double productWeight;

        public string NameOfProduct { get; set; }
        
       

        public Product(decimal pricePerKilogram, double calorificPerKilogram, double productWeight, string name)
        {
            PricePerKilogram = pricePerKilogram;
            CalorificPerKilogram = calorificPerKilogram;
            NameOfProduct = name;
            ProductWeight = productWeight;
        }

        public decimal PricePerKilogram
        {
            get
            {
                return pricePerKilogram;
            }
            set
            {
                if (value <= 0 || value >= 300000)
                {
                    throw new ArgumentException("The product price is incorrect");
                }
                else
                {
                    pricePerKilogram = value;
                }
            }
        }

        public double CalorificPerKilogram
        {
            get
            {
                return calorificPerKilogram;
            }
            set
            {
                if (value < 0 || value >= 1000)
                {
                    throw new ArgumentException("The product calorific is incorrect");
                }
                else
                {
                    calorificPerKilogram = value;
                }
            }
        }

        public double ProductWeight
        {
            get
            {
                return productWeight;
            }
            set
            {
                if (value <= 0 || value >= 10000)
                {
                    throw new ArgumentException("The product weight is incorrect");
                }
                else
                {
                    productWeight = value;
                }
            }
        }


        public static bool TryParse(string source, out Product product)
        {
            if (source == null)
            {
                product = null;
                return false;
            }
            Regex regex = new Regex(@"\s+");
            source = regex.Replace(source, " ");
            StringBuilder resultName = new StringBuilder();
            regex = new Regex(@"(?<Numbers>\d+[,.+]\d+|\d+)");
            MatchCollection matches = regex.Matches(source);

            double weight, colories, price;
            
            if(matches.Count==3)
            {
                if(Double.TryParse(matches[0].Value, out weight) && Double.TryParse(matches[1].Value, out price) && Double.TryParse(matches[2].Value, out colories))
                {
                    regex = new Regex(@"\D+");
                    Match match = regex.Match(source);
                    if(match.Success)
                    {
                        string name = match.Value;
                        name = name.TrimEnd();
                        product = new Product((decimal)price, colories,weight,name);
                        return true;
                    }
                }
            }
            product = null;
            return false;
        }

    }
}
