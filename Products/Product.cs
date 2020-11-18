using System;

namespace ProductsLib
{
    //Переименовать поля
    public class Product
    {

        private decimal pricePerKilogram;
        private double calorificPerKilogram;
        private double productWeight;

        public string NameOfProduct { get; set; }
        
        public Product(decimal pricePerKilogram, double calorificPerKilogram, double productWeight, string name)
        {
            PricePerKilogram = pricePerKilogram;
            CalorificPerKilogram = calorificPerKilogram;
            NameOfProduct = name;
            ProductWeight = productWeight;
        }

        public decimal PricePerKilogram
        {
            get
            {
                return pricePerKilogram;
            }
            set
            {
                if (value <= 0 || value >= 300000)
                {
                    throw new ArgumentException("The product price is incorrect");
                }
                else
                {
                    pricePerKilogram = value;
                }
            }
        }

        public double CalorificPerKilogram
        {
            get
            {
                return calorificPerKilogram;
            }
            set
            {
                if (value <= 0 || value >= 1000)
                {
                    throw new ArgumentException("The product calorific is incorrect");
                }
                else
                {
                    calorificPerKilogram = value;
                }
            }
        }

        public double ProductWeight
        {
            get
            {
                return productWeight;
            }
            set
            {
                if (value <= 0 || value >= 10000)
                {
                    throw new ArgumentException("The product weight is incorrect");
                }
                else
                {
                    productWeight = value;
                }
            }
        }

    }
}
