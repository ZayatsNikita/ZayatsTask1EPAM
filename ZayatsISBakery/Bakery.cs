using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using BakeryLib.Interfaces;
using BakeryLib.CategoriesOfBakeryProduct;
namespace BakeryLib
{
    class Bakery
    {
        ICheapBakery cheapBakery;
        IExpensiveBakery expensiveBakery;
        Bakery()
        {
            BakeryRealizator bakeryRealizator = new BakeryRealizator();
            cheapBakery = bakeryRealizator;
            expensiveBakery = bakeryRealizator;
        }
        Dictionary<BakeryProduct, int> listOfManufacturedProducts;

        public void AddProduct(BakeryProduct product, int count)
        {
            if (product != null)
                listOfManufacturedProducts.Add(product, count);
            else
                throw new ArgumentNullException();
        }


        

        public static BakeryProduct CreateBakeryProduct(string source)
        {
            if (source == null)
            {
                throw new ArgumentNullException("an empty string was passed");
            }
            //Форматирую строку
            Regex regex = new Regex(@"\s+");
            source = regex.Replace(source, " ");
            string[] stringArr = source.Split();
            //Форматирую строку

            int count, index = 0;
            StringBuilder resultName = new StringBuilder();
            while (!int.TryParse(stringArr[index], out count) && index< stringArr.Length)
            {
                if (index != 0)
                {
                    resultName.Append(" ");
                }
                resultName.Append(stringArr[index]);
                index++;
            }
            if (index != stringArr.Length - 2 && (stringArr[stringArr.Length - 1] != "шт" || stringArr[stringArr.Length - 1] != "pieces"))
            {
                throw new ArgumentException("the passed string is not formatted correctly");
            }
            else
            {
                Random rnd = new Random();
                if (stringArr[0] == "Bread" || stringArr[0]=="Хлеб")
                {
                    return new Bread(resultName.ToString(), rnd.Next(1, 100), rnd.Next(1, 100));
                }
                if (stringArr[0] == "Cake" || stringArr[0] == "Торт")
                {
                    return new Cake(resultName.ToString(), rnd.Next(1, 100), rnd.Next(1, 100));
                }
                if (stringArr[0] == "Pie" || stringArr[0] == "Пирог")
                {
                    return new Pie(resultName.ToString(), rnd.Next(1, 100), rnd.Next(1, 100));
                }
                if (stringArr[0] == "Bun" || stringArr[0] == "Булочка")
                {
                    return new Bun(resultName.ToString(), rnd.Next(1, 100), rnd.Next(1, 100));
                }

                //Если ничего не подошло
                throw new ArgumentException("The bakery doesn't bake "+resultName.ToString());
            }
        }
    }
}
