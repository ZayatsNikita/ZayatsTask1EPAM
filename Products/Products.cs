using System;

namespace Products
{
    //Переименовать поля
    public class Products
    {

        private decimal pricePerKilogram;
        private double calorificPerKilogram;
        string NameOfProduct { get; set; }

        public Products(decimal pricePerKilogram, double calorificPerKilogram, string name)
        {
            PricePerKilogram = pricePerKilogram;
            CalorificPerKilogram = calorificPerKilogram;
            NameOfProduct = name;
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

    }
}
