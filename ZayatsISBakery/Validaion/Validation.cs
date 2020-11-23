using System;
using System.Text.RegularExpressions;

namespace BakeryLib.Validaion
{
    /// <summary>
    /// A class that is used to determine whether a string matches the format of an ingredient or bakery product
    /// </summary>
    public class Validation
    {
        /// <summary>
        /// Template for bakery products
        /// </summary>
        static Regex productRegex = new Regex(@"\A(?<Product>[a-zA-Z]+)\s+(?<ProductType>[a-zA-Z]+|[""a-zA-Z""]+)\s+(?<CountOfProduct>\d+)+\s+pieces{1}");
        /// <summary>
        /// Template for an ingredient
        /// </summary>
        static Regex ingreedientRegex = new Regex(@"(?<Params>[a-zA-Z]+)\s+(?<Weight>\d+[,.]\d+|\d+)\s+kg\s+(?<Price>\d+[,.]\d+|\d+)\s+[pr$]\s+(?<Power>\d+[,.]\d+|\d+)\s+(kkal){1}");


        /// <summary>
        /// Method that checks whether the string matches the string template for bakery products
        /// </summary>
        /// <param name="source">The string to be parsed</param>
        /// <returns>True if the string matches the bakery product template, else return false.
        /// <para>
        /// <remarks>If the template matches the passed string, the string value is changed to a string that has the format required for the bakery and that contains information about the expected product name</remarks>
        /// </para>
        /// <example>
        /// For example: "Bread \"Borodinsky\" 6 pieces" Will be changed to "BorodinskyBread"
        /// </example>
        /// </returns>
        /// <remarks>If the line fits the template , it does not mean that there is such a bakery product</remarks>
        public static bool IsProduct(ref string source,ref int countOfProduct)
        {
            Match match1 = productRegex.Match(source);
            if (match1.Success)
            {
                source = match1.Groups["ProductType"].Value.Replace("\"", "") + match1.Groups["Product"].Value;
                countOfProduct = Convert.ToInt32(match1.Groups["CountOfProduct"].Value);
                return true;
            }
            return false;
        }



        /// <summary>
        /// Method that checks whether a string matches the string template for ingredients
        /// </summary>
        /// <param name="source">The string to be parsed.If the string matches the template, the name of the ingredient will be placed here</param>
        /// <param name="weight">In case of successful analysis, the weight of the ingredient is placed here</param>
        /// <param name="colories">If the string matches the ingredient template, the number of calories in the ingredient per 1
        /// kg of weight is placed here, otherwise the value of the variable does not change</param>
        /// <param name="price">If the string matches the ingredient template, the price of the ingredient per 
        /// 1 kg of weight is placed here, otherwise the value of the variable does not change</param>
        /// <returns>True if the string matches the ingredients template, else return false.
        /// </returns>
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
