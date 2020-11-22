using ProductsLib.ModelsOfProduct;
using System;
using ProductsLib.ProductFactories;

namespace ProductsLib
{

    public static class ProductFabrica
    {
        public static IProduct CreateProduct(string source, double weight)
        {
            switch (source)
            {
                case "Eggs":
                    return EggsFabrica.GetProduct(weight);
                case "Flour":
                    return FlourFabrica.GetProduct(weight);
                case "Meat":
                    return MeatFabrica.GetProduct(weight);
                case "Oil":
                    return OilFabrica.GetProduct(weight);
                case "Salt":
                    return SaltFabrica.GetProduct(weight);
                case "SourCream":
                    return SourСreamFabrica.GetProduct(weight);
                case "Water":
                    return WaterFabrica.GetProduct(weight);
                default:
                    throw new ArgumentException("The specified string is not in the correct format");
            }
        }
    }
}
