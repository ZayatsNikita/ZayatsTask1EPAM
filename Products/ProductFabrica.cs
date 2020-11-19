using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using ProductsLib.ModelsOfProduct;
namespace ProductsLib
{
   
    public class ProductFabrica
    {
        private bool IsCream(ProductInfo source)
        {
            return new Cream().Equals(source);
        }
        private IsEggs();
        private IsFlour();
        private IsMeat();
        private IsOil();
        private IsSalt();
        private IsSourСream();
        private IsSugar();
        private IsWater();
        private ProductInfo StringProcessing(string source)
        {
            ProductInfo extractedInformation=  new ProductInfo();
            if (source == null)
            {
                throw new NullReferenceException("String not set");
            }
            Regex regex = new Regex(@"\s+");
            source = regex.Replace(source, " ");
            StringBuilder resultName = new StringBuilder();
            regex = new Regex(@"(?<Numbers>\d+[,.+]\d+|\d+)");
            MatchCollection matches = regex.Matches(source);

            if (matches.Count == 3)
            {
                if (Double.TryParse(matches[0].Value, out extractedInformation.weight) && Decimal.TryParse(matches[1].Value, out extractedInformation.price) && Double.TryParse(matches[2].Value, out extractedInformation.colories))
                {
                    regex = new Regex(@"\D+");
                    Match match = regex.Match(source);
                    if (match.Success)
                    {
                        extractedInformation.name = match.Value;
                        extractedInformation.name = extractedInformation.name.TrimEnd();
                    }
                    return extractedInformation;

                }

            }
            throw new ArgumentException("The specified string is not in the correct format");
        }
        public void CreateProduct(string source)
        {
           
        }

    }
}
