using NUnit.Framework;
using BakeryLib;
using System.Collections.Generic;
using ProductsLib;
using ProductsLib.ModelsOfProduct;
using BakeryLib.SubclassesOfCategoriesOfBakeryProducts.BreadSubClasses;
using BakeryLib.SubclassesOfCategoriesOfBakeryProducts.CakeSubClasses;
using BakeryLib.SubclassesOfCategoriesOfBakeryProducts.PieSubClasses;


namespace BakeryLib.NunitTest
{
    [TestFixture]
    class BakeryTests
    {
        Bakery bakery;
        [SetUp]
        public void Initialization()
        {
            bakery = new Bakery();
        }
        [Test]
        public void SortByPriceTest_TheOrderIsIncorrect_TheOrderOfElementsWillChange()
        {
            BakeryProduct[] bakeryProducts = new BakeryProduct[] {new LuntikCake (){NecessaryIngredients = new List<IProduct>{ new Salt() {ProductWeight= 0.5}, new Water {ProductWeight=0.75 }, new Eggs {ProductWeight=1 } } },
             new KupalovskyBread () {NecessaryIngredients= new List<IProduct>() { new Eggs() {ProductWeight=0.1 },new Flour() {ProductWeight=0.1 }, new Oil() { ProductWeight = 0.1 }, new Salt() { ProductWeight = 0.1 } } },
             new BorodinskyBread() {NecessaryIngredients= new List<IProduct>() { new Water() {ProductWeight=5 },new Flour() {ProductWeight=5 } } }

            };

            bakeryProducts = new Bakery().SortByPrice(bakeryProducts);

            bool expexted = bakeryProducts[0].GetType().Name == "KupalovskyBread" && bakeryProducts[1].GetType().Name == "BorodinskyBread" && bakeryProducts[2].GetType().Name == "LuntikCake";

            Assert.IsTrue(expexted);
        }
        [Test]
        public void SortByCaloricTest_TheOrderIsIncorrect_TheOrderOfElementsWillChange()
        {
            BakeryProduct[] bakeryProducts = new BakeryProduct[] {
             new LuntikCake (){NecessaryIngredients = new List<IProduct>{ new Salt() {ProductWeight= 0.5}, new Water {ProductWeight=0.75 }, new Eggs {ProductWeight=1 } } },
             new KupalovskyBread () {NecessaryIngredients= new List<IProduct>() { new Eggs() {ProductWeight=0.1 },new Flour() {ProductWeight=0.1 }, new Oil() { ProductWeight = 0.1 }, new Salt() { ProductWeight = 0.1 } } },
             new BorodinskyBread() {NecessaryIngredients= new List<IProduct>() { new Water() {ProductWeight=5 },new Flour() {ProductWeight=5 } } },
             new YaltPie(){NecessaryIngredients=new List<IProduct>{ new Meat() {ProductWeight=0.1 },new Salt() {ProductWeight=0.1 }, new Flour() {ProductWeight=0.1 },new SourСream() {ProductWeight=0.1 },new Oil {ProductWeight=0.1 } } },
             new MinskPie(){NecessaryIngredients = new List<IProduct>{ new Flour() {ProductWeight=0.3 },new Meat() {ProductWeight=1.5},new Water() {ProductWeight=0.1},new Eggs() {ProductWeight=0.6 } } },
             new NapoleonCake(){NecessaryIngredients = new List<IProduct>{new SourСream(){ ProductWeight=0.2 },new Eggs {ProductWeight=0.2 } } }
            };

            bakeryProducts = bakery.SortByCalories(bakeryProducts);

            bool expexted = bakeryProducts[0].GetType().Name == "NapoleonCake" && bakeryProducts[1].GetType().Name == "KupalovskyBread" && bakeryProducts[2].GetType().Name == "LuntikCake"
                && bakeryProducts[3].GetType().Name == "YaltPie" && bakeryProducts[4].GetType().Name == "MinskPie" && bakeryProducts[5].GetType().Name == "BorodinskyBread";
            Assert.IsTrue(expexted);
        }


        [Test]
        public void FilterByPriceAndColoriesTest__2ElementsFind()
        {
            
            BakeryProduct[] bakeryProducts = new BakeryProduct[] {
             new LuntikCake (){NecessaryIngredients = new List<IProduct>{ new Salt() {ProductWeight= 0.5}, new Water {ProductWeight=0.75 }, new Eggs {ProductWeight=1 } } },
             new KupalovskyBread () {NecessaryIngredients= new List<IProduct>() { new Eggs() {ProductWeight=0.1 },new Flour() {ProductWeight=0.1 }, new Oil() { ProductWeight = 0.1 }, new Salt() { ProductWeight = 0.1 } } },
             new BorodinskyBread() { NecessaryIngredients = new List<IProduct> { new Water() { ProductWeight = 4.233 }, new Flour() { ProductWeight = 4.2 } } },
             new YaltPie(){NecessaryIngredients=new List<IProduct>{ new Meat() {ProductWeight=0.1 },new Salt() {ProductWeight=0.1 }, new Flour() {ProductWeight=0.1 },new SourСream() {ProductWeight=0.1 },new Oil {ProductWeight=0.1 } } },
             new MinskPie(){NecessaryIngredients = new List<IProduct>{ new Flour() {ProductWeight=0.4 },new Meat() {ProductWeight=1},new Water() {ProductWeight=0.1},new Eggs() {ProductWeight=0.6 } } },
             new NapoleonCake(){NecessaryIngredients = new List<IProduct>{new SourСream(){ ProductWeight=0.2 },new Eggs {ProductWeight=0.2 } } }
            };
            BakeryProduct expectedProduct = new BorodinskyBread() { NecessaryIngredients = new List<IProduct> { new Water() { ProductWeight = 4.233 }, new Flour() { ProductWeight = 4.2 } } };
            bakeryProducts = new Bakery().FilterByPriceAndColories(bakeryProducts, expectedProduct);
            int expectedNumberOfProducts = 1;

            bool actual = expectedNumberOfProducts == bakeryProducts.Length && bakeryProducts[0].GetType() == expectedProduct.GetType();

            Assert.IsTrue(actual);

        }
        [Test]
        public void FilterByPriceAndColoriesTest_Wrong_2ElementsFind()
        {

            BakeryProduct[] bakeryProducts = new BakeryProduct[] {
             new LuntikCake (){NecessaryIngredients = new List<IProduct>{ new Salt() {ProductWeight= 0.5}, new Water {ProductWeight=0.75 }, new Eggs {ProductWeight=1 } } },
             new KupalovskyBread () {NecessaryIngredients= new List<IProduct>() { new Eggs() {ProductWeight=0.1 },new Flour() {ProductWeight=0.1 }, new Oil() { ProductWeight = 0.1 }, new Salt() { ProductWeight = 0.1 } } },
             new BorodinskyBread() { NecessaryIngredients = new List<IProduct> { new Water() { ProductWeight = 4.233 }, new Flour() { ProductWeight = 4.2 } } },
             new YaltPie(){NecessaryIngredients=new List<IProduct>{ new Meat() {ProductWeight=0.1 },new Salt() {ProductWeight=0.1 }, new Flour() {ProductWeight=0.1 },new SourСream() {ProductWeight=0.1 },new Oil {ProductWeight=0.1 } } },
             new MinskPie(){NecessaryIngredients = new List<IProduct>{ new Flour() {ProductWeight=0.4 },new Meat() {ProductWeight=1},new Water() {ProductWeight=0.1},new Eggs() {ProductWeight=0.6 } } },
             new NapoleonCake(){NecessaryIngredients = new List<IProduct>{new SourСream(){ ProductWeight=0.2 },new Eggs {ProductWeight=0.2 } } }
            };
            BakeryProduct expectedProduct = new BorodinskyBread() { NecessaryIngredients = new List<IProduct> { new Water() { ProductWeight = 2.233 }, new Flour() { ProductWeight = 4.2 } } };
            bakeryProducts = bakery.FilterByPriceAndColories(bakeryProducts, expectedProduct);
            
            Assert.IsEmpty(bakeryProducts);
        }
        [Test]
        public void FilterByIngridientWeightTest_PPPP_TRUE()
        {
            Flour flour = new Flour() { ProductWeight = 0.4 };
            Water water = new Water() { ProductWeight = 4.99 };
            Eggs eggs = new Eggs() { ProductWeight = 0.19 };
            Meat meat = new Meat() { ProductWeight = 0.3 };


            BakeryProduct[] bakeryProducts = new BakeryProduct[] {
             new LuntikCake (){NecessaryIngredients = new List<IProduct>{ new Salt() {ProductWeight= 0.5}, new Water {ProductWeight=4.85 }, new Eggs {ProductWeight=1 } } },
             new KupalovskyBread () {NecessaryIngredients= new List<IProduct>() { new Eggs() {ProductWeight=0.1 },new Flour() {ProductWeight=0.34 }, new Oil() { ProductWeight = 0.1 }, new Salt() { ProductWeight = 0.1 } } },
             new BorodinskyBread() { NecessaryIngredients = new List<IProduct> { new Water() { ProductWeight = 5.3 }, new Flour() { ProductWeight = 0.2 } } },
             new YaltPie(){NecessaryIngredients=new List<IProduct>{ new Meat() {ProductWeight=0.1 },new Salt() {ProductWeight=0.1 }, new Flour() {ProductWeight=0.6 },new SourСream() {ProductWeight=0.1 },new Oil {ProductWeight=0.1 } } },
             new MinskPie(){NecessaryIngredients = new List<IProduct>{ new Flour() {ProductWeight=0.45 },new Meat() {ProductWeight=1},new Water() {ProductWeight=7.5},new Eggs() {ProductWeight=0.6 } } },
             new NapoleonCake(){NecessaryIngredients = new List<IProduct>{new SourСream(){ ProductWeight=0.2 },new Eggs {ProductWeight=0.2 } } }
            };

            BakeryProduct[] flourBac = bakery.FilterByIngridientWeight(bakeryProducts, flour);
            BakeryProduct[] warerBac = bakery.FilterByIngridientWeight(bakeryProducts, water);
            BakeryProduct[] eggsBac = bakery.FilterByIngridientWeight(bakeryProducts, eggs);
            BakeryProduct[] meatBac = bakery.FilterByIngridientWeight(bakeryProducts, meat);

            bool actual1 = (flourBac[0].GetType().Name == "YaltPie" && flourBac[1].GetType().Name == "MinskPie" && flourBac.Length==2);
            bool actual2 = (warerBac[0].GetType().Name == "BorodinskyBread" && warerBac[1].GetType().Name == "MinskPie" && warerBac.Length==2);
            bool actual3 = (eggsBac[0].GetType().Name== "LuntikCake" && eggsBac[1].GetType().Name == "MinskPie" && eggsBac[2].GetType().Name == "NapoleonCake"  && eggsBac.Length == 3);
            bool actual4 = meatBac[0].GetType().Name == "MinskPie" && meatBac.Length==1;

            Assert.IsTrue(actual1 && actual2 && actual3 && actual4);
        }
        [Test]
        public void FilterByIngridientWeightTest_PPPP_FALSE()
        {
            Flour flour = new Flour() { ProductWeight = 10.4 };
            Water water = new Water() { ProductWeight = 8.99 };


            BakeryProduct[] bakeryProducts = new BakeryProduct[] {
             new LuntikCake (){NecessaryIngredients = new List<IProduct>{ new Salt() {ProductWeight= 0.5}, new Water {ProductWeight=4.85 }, new Eggs {ProductWeight=1 } } },
             new KupalovskyBread () {NecessaryIngredients= new List<IProduct>() { new Eggs() {ProductWeight=0.1 },new Flour() {ProductWeight=0.34 }, new Oil() { ProductWeight = 0.1 }, new Salt() { ProductWeight = 0.1 } } },
             new BorodinskyBread() { NecessaryIngredients = new List<IProduct> { new Water() { ProductWeight = 5.3 }, new Flour() { ProductWeight = 0.2 } } },
             new YaltPie(){NecessaryIngredients=new List<IProduct>{ new Meat() {ProductWeight=0.1 },new Salt() {ProductWeight=0.1 }, new Flour() {ProductWeight=0.6 },new SourСream() {ProductWeight=0.1 },new Oil {ProductWeight=0.1 } } },
             new MinskPie(){NecessaryIngredients = new List<IProduct>{ new Flour() {ProductWeight=0.45 },new Meat() {ProductWeight=1},new Water() {ProductWeight=7.5},new Eggs() {ProductWeight=0.6 } } },
             new NapoleonCake(){NecessaryIngredients = new List<IProduct>{new SourСream(){ ProductWeight=0.2 },new Eggs {ProductWeight=0.2 } } }
            };

            BakeryProduct[] flourBac = bakery.FilterByIngridientWeight(bakeryProducts, flour);
            BakeryProduct[] warerBac = bakery.FilterByIngridientWeight(bakeryProducts, water);

            bool actual1 = (flourBac.Length == 0);
            bool actual2 = (warerBac.Length == 0);

            Assert.IsTrue(actual1 && actual2);
        }


        [TestCase(1,6,1)]
        [TestCase(2,4,2)]
        [TestCase(3,3,3)]
        [TestCase(4,1,4)]
        [TestCase(5,0,5)]
        public void FilterByIngridientCountTest_PPPP_FALSE(int count, int expected,int testCaseNum)
        {
            BakeryProduct[] bakeryProducts = new BakeryProduct[] {
             new LuntikCake (){NecessaryIngredients = new List<IProduct>{ new Salt() {ProductWeight= 0.5}, new Water {ProductWeight=4.85 }, new Eggs {ProductWeight=1 } } },
             new KupalovskyBread () {NecessaryIngredients= new List<IProduct>() { new Eggs() {ProductWeight=0.1 },new Flour() {ProductWeight=0.34 }, new Oil() { ProductWeight = 0.1 }, new Salt() { ProductWeight = 0.1 } } },
             new BorodinskyBread() { NecessaryIngredients = new List<IProduct> { new Water() { ProductWeight = 5.3 }, new Flour() { ProductWeight = 0.2 } } },
             new YaltPie(){NecessaryIngredients=new List<IProduct>{ new Meat() {ProductWeight=0.1 },new Salt() {ProductWeight=0.1 }, new Flour() {ProductWeight=0.6 },new SourСream() {ProductWeight=0.1 },new Oil {ProductWeight=0.1 } } },
             new MinskPie(){NecessaryIngredients = new List<IProduct>{ new Flour() {ProductWeight=0.45 },new Meat() {ProductWeight=1},new Water() {ProductWeight=7.5},new Eggs() {ProductWeight=0.6 } } },
             new NapoleonCake(){NecessaryIngredients = new List<IProduct>{new SourСream(){ ProductWeight=0.2 },new Eggs {ProductWeight=0.2 } } }
            };

            bakeryProducts = bakery.FilterByIngridientsCount(bakeryProducts, count);
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
