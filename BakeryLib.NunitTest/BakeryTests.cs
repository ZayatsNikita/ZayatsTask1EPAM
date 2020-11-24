using BakeryLib.SubclassesOfCategoriesOfBakeryProducts.BreadSubClasses;
using BakeryLib.SubclassesOfCategoriesOfBakeryProducts.CakeSubClasses;
using BakeryLib.SubclassesOfCategoriesOfBakeryProducts.PieSubClasses;
using NUnit.Framework;
using ProductsLib;
using ProductsLib.ModelsOfProduct;
using System.Collections.Generic;


namespace BakeryLib.NunitTest
{
    [TestFixture]
    class BakeryTests
    {

        BakeryForWorkingWithBakeryProducts bakery;
        BakeryProduct[] sourceArray;
        [SetUp]
        public void Initialization()
        {
            bakery = new BakeryForWorkingWithBakeryProducts();

            sourceArray = new BakeryProduct[] {
             new LuntikCake ( new List<Product>{ new Salt(0.5) , new Water(4.85) , new Eggs(1) }  ),
             new KupalovskyBread (new List<Product>() { new Eggs(0.1),new Flour(0.34), new Oil(0.1), new Salt(0.1)   } ),
             new BorodinskyBread( new List<Product> { new Water(4.233),new Flour(4.2) } ),
             new YaltPie(new List<Product>{ new Meat(0.1),new Salt(0.1), new Flour(0.6),new SourСream(0.1),new Oil (0.1) } ),
             new MinskPie( new List<Product>{ new Flour(0.45),new Meat(1),new Water(7.5),new Eggs(0.6) } ),
             new NapoleonCake(new List<Product>{new SourСream(0.2),new Eggs(0.2) } )
            };
        }
        [Test]
        public void SortByPriceTest_TheOrderIsIncorrect_TheOrderOfElementsWillChange()
        {
            BakeryProduct[] bakeryProducts = bakery.SortByPrice(sourceArray);

            bool actual = bakeryProducts[0].GetType().Name == "KupalovskyBread" && bakeryProducts[1].GetType().Name == "BorodinskyBread"
                && bakeryProducts[2].GetType().Name == "NapoleonCake" && bakeryProducts[3].GetType().Name == "LuntikCake"
                && bakeryProducts[4].GetType().Name == "YaltPie" && bakeryProducts[5].GetType().Name == "MinskPie";

            Assert.IsTrue(actual);
        }
        [Test]
        public void SortByCaloricTest_TheOrderIsIncorrect_TheOrderOfElementsWillChange()
        {

            BakeryProduct[] bakeryProducts = bakery.SortByCalories(sourceArray);

            bool actual = bakeryProducts[0].GetType().Name == "NapoleonCake" && bakeryProducts[1].GetType().Name == "LuntikCake" && bakeryProducts[2].GetType().Name == "KupalovskyBread"
                && bakeryProducts[3].GetType().Name == "YaltPie" && bakeryProducts[4].GetType().Name == "MinskPie" && bakeryProducts[5].GetType().Name == "BorodinskyBread";
            Assert.IsTrue(actual);
        }


        [Test]
        public void FilterByPriceAndColoriesTest_ArrayWithOneMatch_1ElementsFind()
        {
            BakeryProduct expectedProduct = new BorodinskyBread(new List<Product> { new Water(4.233), new Flour(4.2)} );
            BakeryProduct[] bakeryProducts = bakery.FilterByPriceAndColories(sourceArray, expectedProduct);
            int expectedNumberOfProducts = 1;

            bool actual = expectedNumberOfProducts == bakeryProducts.Length && bakeryProducts[0].GetType() == expectedProduct.GetType();

            Assert.IsTrue(actual);

        }
        [Test]
        public void FilterByPriceAndColoriesTest_WrongData_ZeroLengthArray()
        {

            BakeryProduct expectedProduct = new BorodinskyBread(new List<Product> { new Water(2.233), new Flour( 4.2) } );
            BakeryProduct[] actual = bakery.FilterByPriceAndColories(sourceArray, expectedProduct);
            
            Assert.IsEmpty(actual);
        }
        [Test]
        public void FilterByIngridientWeightTest_ExistingElementsAreUsed_NotZeroLengthArray()
        {
            Flour flour = new Flour(0.6);
            Water water = new Water(4.5);
            Eggs eggs = new Eggs(0.19);
            Meat meat = new Meat(0.05);


            BakeryProduct[] flourBac = bakery.FilterByIngridientWeight(sourceArray, flour);
            BakeryProduct[] warerBac = bakery.FilterByIngridientWeight(sourceArray, water);
            BakeryProduct[] eggsBac = bakery.FilterByIngridientWeight(sourceArray, eggs);
            BakeryProduct[] meatBac = bakery.FilterByIngridientWeight(sourceArray, meat);

            bool actual1 = (flourBac[0].GetType().Name == "BorodinskyBread" && flourBac.Length==1);
            bool actual2 = warerBac[0].GetType().Name == "LuntikCake" && warerBac[1].GetType().Name == "MinskPie" && warerBac.Length==2;
            bool actual3 = (eggsBac[0].GetType().Name== "LuntikCake" && eggsBac[1].GetType().Name == "MinskPie" && eggsBac[2].GetType().Name == "NapoleonCake"  && eggsBac.Length == 3);
            bool actual4 = meatBac[1].GetType().Name == "MinskPie" && meatBac[0].GetType().Name == "YaltPie" && meatBac.Length==2;

            Assert.IsTrue(actual1 && actual2 && actual3 && actual4);
        }
        [Test]
        public void FilterByIngridientWeightTest_NonexistentElementsAreUsed_ZeroLengthArray()
        {
            Flour flour = new Flour(10.4);
            Water water = new Water(8.99);


            BakeryProduct[] flourBac = bakery.FilterByIngridientWeight(sourceArray, flour);
            BakeryProduct[] warerBac = bakery.FilterByIngridientWeight(sourceArray, water);

            bool actual = (flourBac.Length == 0 && warerBac.Length == 0);

            Assert.IsTrue(actual);
        }


        [TestCase(1,6,1)]
        [TestCase(2,4,2)]
        [TestCase(3,3,3)]
        [TestCase(4,1,4)]
        [TestCase(5,0,5)]
        public void FilterByIngridientCountTest(int count, int expected,int testCaseNum)
        {
            BakeryProduct[] bakeryProducts = bakery.FilterByIngridientsCount(sourceArray, count);
            bool actual=false;
            switch (testCaseNum)
            {
                case 1:
                    actual = bakeryProducts[0].GetType().Name == "LuntikCake" && bakeryProducts[1].GetType().Name == "KupalovskyBread" && bakeryProducts[2].GetType().Name == "BorodinskyBread"
                        && bakeryProducts[3].GetType().Name == "YaltPie" && bakeryProducts[4].GetType().Name == "MinskPie" && bakeryProducts[5].GetType().Name == "NapoleonCake";
                    break;
                case 2:
                    actual = bakeryProducts[0].GetType().Name == "LuntikCake" && bakeryProducts[1].GetType().Name == "KupalovskyBread"  && bakeryProducts[2].GetType().Name == "YaltPie" 
                        && bakeryProducts[3].GetType().Name == "MinskPie";

                    break;

                case 3:
                    actual = bakeryProducts[0].GetType().Name == "KupalovskyBread" && bakeryProducts[1].GetType().Name == "YaltPie"
                        && bakeryProducts[2].GetType().Name == "MinskPie";
                    break;
                case 4:
                    actual = bakeryProducts[0].GetType().Name == "YaltPie";
                    break;
                case 5:
                    actual = true;
                    break;
            }
            actual = actual && bakeryProducts.Length == expected;

            Assert.IsTrue(actual);
        }
    }
}
