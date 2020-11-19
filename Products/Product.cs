using System;
using System.Text.RegularExpressions;
using System.Text;
namespace ProductsLib
{
    //Переименовать поля
    internal struct ProductInfo
    {
        public string name;
        public double weight;
        public double colories;
        public decimal price;
    }
    public abstract class Product
    {
        public abstract decimal PricePerKilogram { get; }

        public abstract double CalorificPerKilogram { get; }

        public abstract double ProductWeight { get; }


        //public static bool TryParse(string source, out Product product)
        //{
        //    if (source == null)
        //    {
        //        product = null;
        //        return false;
        //    } 
        //    Regex regex = new Regex(@"\s+");
        //    source = regex.Replace(source, " ");
        //    StringBuilder resultName = new StringBuilder();
        //    regex = new Regex(@"(?<Numbers>\d+[,.+]\d+|\d+)");
        //    MatchCollection matches = regex.Matches(source);

        //    double weight, colories, price;

        //    if(matches.Count==3)
        //    {
        //        if(Double.TryParse(matches[0].Value, out weight) && Double.TryParse(matches[1].Value, out price) && Double.TryParse(matches[2].Value, out colories))
        //        {
        //            regex = new Regex(@"\D+");
        //            Match match = regex.Match(source);
        //            if(match.Success)
        //            {
        //                string name = match.Value;
        //                name = name.TrimEnd();
        //                product = new Product((decimal)price, colories,weight,name);
        //                return true;
        //            }
        //        }
        //    }
        //    product = null;
        //    return false;
        //}
    }
}
