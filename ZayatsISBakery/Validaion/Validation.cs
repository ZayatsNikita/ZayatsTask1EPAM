using System;
using System.Text.RegularExpressions;

namespace BakeryLib.Validaion
{
    class Validation
    {
        public static bool IsProduct(ref string source, Regex regex)
        {
            Match match1 = regex.Match(source);
            if (match1.Success)
            {
                source = match1.Groups["ProductType"].Value.Replace("\"", "") + match1.Groups["Product"].Value;
                Console.WriteLine(match1.Groups["Product"].Value + "   " + match1.Groups["ProductType"].Value + "  " + match1.Groups["CountOfProduct"]);
                return true;
            }
            return false;
        }
        public static bool IsIngredient(ref string source, Regex regex, ref double weight, ref double colories, ref decimal price)
        {
            Match match2 = regex.Match(source);
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
