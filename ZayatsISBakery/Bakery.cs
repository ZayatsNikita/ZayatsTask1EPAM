using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using BakeryLib.Interfaces;
using BakeryLib.SubclassesOfCategoriesOfBakeryProducts.BreadSubClasses;
using System.Linq;
//using BakeryLib.SubclassesOfCategoriesOfBakeryProducts.BunSubClasses;
//using BakeryLib.SubclassesOfCategoriesOfBakeryProducts.PieSubClasses;
//using BakeryLib.SubclassesOfCategoriesOfBakeryProducts.CakeSubClasses;
using ProductsLib;

namespace BakeryLib
{
    public class Bakery
    {
        public Bakery()
        {
            
        }
        
        Dictionary<BakeryProduct, int> listOfManufacturedProducts;

        public void AddProduct(BakeryProduct product, int count)
        {
            if (product != null)
                listOfManufacturedProducts.Add(product, count);
            else
                throw new ArgumentNullException();
        }
        public BakeryProduct[] SortByPrice(BakeryProduct[] bakeryProducts)
        {
            return  bakeryProducts.OrderBy(x=>x.GetPrice()).ToArray();
            #region quickSort
            //int i = left, j = right;
            //BakeryProduct tmp;
            //decimal avgPrice=0;
            //for(int index=left;index<right;index++)
            //{
            //    avgPrice += bakeryProducts[index].GetPrice();
            //}
            //avgPrice /= (right - left + 1);
            //while(i<=j)
            //{
            //    while (bakeryProducts[i].GetPrice() < avgPrice)
            //        i++;
            //    while (bakeryProducts[j].GetPrice() > avgPrice)
            //        j--;
            //    if(i<=j)
            //    {
            //        tmp = bakeryProducts[i];
            //        bakeryProducts[i] = bakeryProducts[j];
            //        bakeryProducts[j] = tmp;
            //        i++;
            //        j--;
            //    }
            //}
            //if (left < j)
            //    SortByPrice(bakeryProducts,left,j);
            //if(i<right)
            //    SortByPrice(bakeryProducts, i, right);
            #endregion
        }
        public BakeryProduct[] SortByCaories(BakeryProduct[] bakeryProducts)
        {
            var res = bakeryProducts.OrderBy(x=>x.GetCaloric());
            return res.ToArray();
        }
        public BakeryProduct[] FilterByPriceAndColories(BakeryProduct[] bakeryProducts, BakeryProduct product)
        {
            var result = bakeryProducts.Where(x=> (x.GetPrice() == product.GetPrice()) && x.GetCaloric() == product.GetCaloric());
            return result.ToArray();
        }
        public BakeryProduct[] FilterByIngridientWeight(BakeryProduct[] bakeryProducts, IProduct product, double necessaryWeight)
        {
            //foreach(BakeryProduct bakery in bakeryProducts)
            //{
            //    foreach(IProduct product1 in bakery.NecessaryIngredients)
            //    {
            //        if(product1.GetType().Name== product.GetType().Name)
            //        {
            //            if (product1.ProductWeight > necessaryWeight)
            //                yield return product1;
            //        }
            //    }
            //}
            var result = from bProduct in bakeryProducts
                         from ingredient in bProduct.NecessaryIngredients
                         where ingredient.GetType() == product.GetType()
                         where ingredient.ProductWeight > necessaryWeight
                         select bProduct;
            return result.ToArray();
        }
        //Ингриденты с числом элементов больше заданного
        public BakeryProduct[] FilterByIngridientsCount(BakeryProduct[] bakeryProducts, int countOfIngreedient)
        {
            var res = bakeryProducts.Where(x => x.NecessaryIngredients.Count > countOfIngreedient);
            if(res.Count()!=0)
            {
                return res.ToArray();
            }
            return null;
        }
        public static BakeryProduct CreateBakeryProduct(string source, List<IProduct> products)
        {
            switch (source)
            {
                case "BorodinskyBread":
                    if(BorodinskyBread.IsBorodinsky(products))
                    return new BorodinskyBread() {NecessaryIngredients= products };
                    break;
                case "KupalovskyBread":
                    if(KupalovskyBread.IsKupalovskyBread(products))
                        return new KupalovskyBread() { NecessaryIngredients = products };
                    break;
            }
            throw new ArgumentException("The bakery doesn't bake product liki this");
        }
    }
}

