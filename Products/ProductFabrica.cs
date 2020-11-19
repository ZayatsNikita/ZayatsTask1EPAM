using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using ProductsLib.ModelsOfProduct;
namespace ProductsLib
{
   
    public static class ProductFabrica
    {
        private static bool IsCream(ProductInfo source)
        {
            return new Cream().Equals(source);
        }
        private static bool IsEggs(ProductInfo source)
        {
            return new Eggs().Equals(source);
        }
        private static bool IsFlour(ProductInfo source)
        {
            return new Flour().Equals(source);
        }
        private static bool IsMeat(ProductInfo source)
        {
            return new Meat().Equals(source);
        }
        private static bool IsOil(ProductInfo source)
        {
            return new Oil().Equals(source);
        }
        private static bool IsSalt(ProductInfo source)
        {
            return new Salt().Equals(source);
        }
        private static bool IsSourСream(ProductInfo source)
        {
            return new SourСream().Equals(source);
        }
        private static bool IsSugar(ProductInfo source)
        {
            return new Sugar().Equals(source);
        }
        private static bool IsWater(ProductInfo source)
        {
            return new Water().Equals(source);
        }
        private static ProductInfo StringProcessing(string source)
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
        public static Product CreateProduct(string source)
        {
            if (source == null)
                throw new NullReferenceException("String not set");
            ProductInfo productIfno;
            try
            {
                productIfno = StringProcessing(source);
            }
            catch(NullReferenceException ex)
            {
                throw new NullReferenceException(ex.Message);
            }
            catch(ArgumentException ex)
            {
                throw new ArgumentException(ex.Message);
            }
            if (IsCream(productIfno))
                return new Cream();
            if (IsEggs(productIfno))
                return new Eggs();
            if(IsFlour(productIfno))
                return new Flour();
            if(IsMeat(productIfno))
                return new Meat();
            if(IsOil(productIfno))
                return new Oil();
            if(IsSalt(productIfno))
                return new Salt();
            if(IsSourСream(productIfno))
                return new SourСream();
            if(IsSugar(productIfno))
                return new Sugar();
            if(IsWater(productIfno))
                return new Water();
            throw new ArgumentException("The specified string is not in the correct format");

        }

    }
}
