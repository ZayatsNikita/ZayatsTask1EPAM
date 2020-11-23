using NUnit.Framework;
using BakeryLib.Validaion;
namespace BakeryLib.NunitTest
{
    [TestFixture]
    public class ValidationTests
    {
        [TestCase("Cake Napoleon 32 pieces")]
        [TestCase("Cake \"Luntic\" 7 pieces")]
        [TestCase("Pie \"Yalt\" 16 pieces")]
        [TestCase("Bread \"Borodinsky\" 6 pieces")]
        public void IsProductTest_CorrectValue_TrueReturned(string source)
        {
            int stub = 0;
            bool actual = Validation.IsProduct(ref source,ref stub);
            Assert.AreEqual(actual,true);
        }

        [TestCase("Cake Eroor \"Luntic\" 7 pieces")]
        [TestCase("Pie \"Yalt\" pieces")]
        [TestCase("Bread \"Borodinsky\" 6 piecehhs")]
        [TestCase("BreadBorodinsky 6 piecehhs")]
        public void IsProductTest_WrongtValue_FalseReturned(string source)
        {
            int stub = 0;
            bool actual = Validation.IsProduct(ref source,ref stub);
            Assert.AreEqual(false,actual);
        }

        [TestCase("Flour 5,2 kg  2,5 p 364 kkal")]
        [TestCase("Pie 4 kg 9 p 100 kkal")]
        public void IsIngredientTest_CorrectValue_TrueReturned(string source)
        {
            double weight=0, calories=0;
            decimal price=0;
            bool actual = Validation.IsIngredient(ref source,ref weight,ref calories, ref price);
            Assert.AreEqual(true,actual);
        }

        [TestCase("Pie 4 kg 9 p 100 kkl")]
        [TestCase("Pie kg 9 p 100 kkal")]
        [TestCase("Pie 4 9 p 100 kkal")]
        [TestCase("Pie 4 kg p 100 kkal")]
        public void IsIngredientTest_WrongtValue_FalseReturned(string source)
        {
            double weight=0, calories=0;
            decimal price=0;
            bool actual = Validation.IsIngredient(ref source, ref weight, ref calories, ref price);
            Assert.AreEqual(false, actual);
        }


    }
}