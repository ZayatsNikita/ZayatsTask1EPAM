using System;
using System.Text.RegularExpressions;
using System.Text;
namespace ProductsLib
{
    public interface IProduct
    {
        public decimal PricePerKilogram { get; }
        public double CalorificPerKilogram { get; }
        public double ProductWeight { get; }
    }
}
