using System;
using System.Text.RegularExpressions;

namespace BakeryLib.Validaion
{
    public class Validation
    {
        static Regex productRegex = new Regex(@"\A(?<Product>[a-zA-Z]+)\s+(?<ProductType>[a-zA-Z]+|[""a-zA-Z""]+)\s+(?<CountOfProduct>\d+)+\s+pieces{1}");
        static Regex ingreedientRegex = new Regex(@"(?<Params>[a-zA-Z]+)\s+(?<Weight>\d+[,.]\d+|\d+)\s+kg\s+(?<Price>\d+[,.]\d+|\d+)\s+[pr$]\s+(?<Power>\d+[,.]\d+|\d+)\s+(kkal){1}");

        public static bool IsProduct(ref string source)
        {
            Match match1 = productRegex.Match(source);
            if (match1.Success)
            {
                source = match1.Groups["ProductType"].Value.Replace("\"", "") + match1.Groups["Product"].Value;
                return true;
            }
            return false;
        }
        public static bool IsIngredient(ref string source, ref double weight, ref double colories, ref decimal price)
        {
            Match match2 = ingreedientRegex.Match(source);
            {
                if (match2.Success)
                {
                    source = match2.Groups["Params"].Value;
                    weight = Double.Parse(match2.Groups["Weight"].Value);
                    colories = Double.Parse(match2.Groups["Power"].Value);
                    price = Decimal.Parse(match2.Groups["Price"].Value);
                    return true;
                }
            }
            return false;
        }

    }
}
