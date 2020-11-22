using NUnit.Framework;
using ProductsLib.ProductValidaion;

namespace ProductsLib.NUmitTest
{
    [TestFixture]
    public class ProductValidationTests
    {
        [TestCase("Eggs", 2.22, 5, 155, true)]
        [TestCase("Flour", 2.5, 5, 364, true)]
        [TestCase("Meat", 6.42, 5, 242, true)]
        [TestCase("Oil", 3.21, 5, 717, true)]
        [TestCase("Salt", 0.57, 5, 0, true)]
        [TestCase("Sour—ream", 6.82, 5, 275.3, true)]
        [TestCase("Water", 0.46, 5, 0, true)]
        [TestCase("Meaasft", 6.42, 5, 242, false)]
        [TestCase("Oil", 3.221, 5, 717, false)]
        [TestCase("Salt", 0.57, 5, 10, false)]
        [TestCase("Sour—ream", 6.82, -3, 275.3, false)]
        public void IsDataValidTest__ReturnedNameOfProduct(string source, double price, double weight, double calories, bool expected)
        {
            bool actual = ProductValidation.IsDataValid(source, (decimal)price, weight, calories);
            Assert.AreEqual(actual, expected);
        }
    }
}