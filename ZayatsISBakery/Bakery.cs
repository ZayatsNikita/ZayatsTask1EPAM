using System;
using System.Collections.Generic;
using System.Linq;

using BakeryLib.SubclassesOfCategoriesOfBakeryProducts.BreadSubClasses;
using BakeryLib.SubclassesOfCategoriesOfBakeryProducts.PieSubClasses;
using BakeryLib.SubclassesOfCategoriesOfBakeryProducts.CakeSubClasses;

using BakeryLib.Factories;

using ProductsLib;

namespace BakeryLib
{
    public class Bakery
    {
        //private static IBakeryFactory[] productionLine = new IBakeryFactory[] {new BorodinskyBreadFactory(), new KupalovskyBreadFactory(), new LuntikCakeFactory(),new NapoleonCakeFactory(), new MinskPieFactory(),new YaltPieFactory()};
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
        public BakeryProduct[] SortByCalories(BakeryProduct[] bakeryProducts)
        {
            return bakeryProducts.OrderBy(x=>x.GetCaloric()).ToArray();
        }
        public BakeryProduct[] FilterByPriceAndColories(BakeryProduct[] bakeryProducts, BakeryProduct product)
        {
            return bakeryProducts.Where(x=> (x.GetPrice() == product.GetPrice()) && x.GetCaloric() == product.GetCaloric()).ToArray();
        }
        public BakeryProduct[] FilterByIngridientWeight(BakeryProduct[] bakeryProducts, IProduct product)
        {
            var result = from bProduct in bakeryProducts
                         from ingredient in bProduct.NecessaryIngredients
                         where ingredient.GetType() == product.GetType()
                         where ingredient.ProductWeight > product.ProductWeight
                         select bProduct;
            return result.ToArray();
        }
        public BakeryProduct[] FilterByIngridientsCount(BakeryProduct[] bakeryProducts, int countOfIngreedient)
        {
            return bakeryProducts.Where(x => x.NecessaryIngredients.Count > countOfIngreedient).ToArray();
        }
        
        
        
        public static BakeryProduct CreateBakeryProduct(string source, List<IProduct> products)
        {
            switch (source)
            {
                case "BorodinskyBread":
                    if(BorodinskyBread.IsBorodinsky(products))
                    return BorodinskyBreadFactory.CreateBakeryProduct(products);
                    break;
                case "KupalovskyBread":
                    if(KupalovskyBread.IsKupalovskyBread(products))
                        return KupalovskyBreadFactory.CreateBakeryProduct(products);
                    break;
                case "LuntikCake":
                    if (LuntikCake.IsLunticCake(products))
                        return LuntikCakeFactory.CreateBakeryProduct(products);
                    break;
                case "NapoleonCake":
                    if (NapoleonCake.IsNapoleonCake(products))
                        return NapoleonCakeFactory.CreateBakeryProduct(products);
                    break;
                case "MinskPie":
                    if (MinskPie.IsMinskPie(products))
                        return MinskPieFactory.CreateBakeryProduct(products);
                    break;
                case "YaltPie":
                    if (YaltPie.IsYaltPie(products))
                        return YaltPieFactory.CreateBakeryProduct(products);
                    break;
            }
            throw new ArgumentException("The bakery doesn't bake product liki this");

        }
    }
}

