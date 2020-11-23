﻿using NUnit.Framework;
using BakeryLib;
namespace BakeryLib.NunitTest
{
    [TestFixture]
    class WorkWithFileTest
    {
       [Test]
       public void WorkWithFileTest_ReadingFromFile_ArrayWith6Elrments()
       {
            BakeryProduct[] bakeryProducts;
            WorkWithFile.GetData(out bakeryProducts);
            bool actual = bakeryProducts[0].GetType().Name == "BorodinskyBread" && bakeryProducts[1].GetType().Name == "KupalovskyBread" && bakeryProducts[2].GetType().Name == "LuntikCake"
                       && bakeryProducts[3].GetType().Name == "NapoleonCake" && bakeryProducts[4].GetType().Name == "YaltPie" && bakeryProducts[5].GetType().Name == "MinskPie";
            Assert.AreEqual(true,actual);
        }
    }
}
