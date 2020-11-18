namespace BakeryLib.CategoriesOfBakeryProduct
{
    public class Buns : BakeryProduct
    {
        private int mandatoryExpenses;

        #region class constructor
        public Buns(int calorieCoefficient) : base(100)
        {
            mandatoryExpenses = calorieCoefficient;
        }
        public Buns(decimal markUpForSale, int mandatoryExpenses) : base(markUpForSale)
        {
            this.mandatoryExpenses = mandatoryExpenses;
        }
        #endregion


        public override double GetCaloric()
        {
            return base.GetCaloric();
        }

        public override decimal GetPrice()
        {
            return base.GetPrice() * MarkUpForSale + (decimal)mandatoryExpenses;
        }


        public override int GetHashCode()
        {
            return HashCode.Combine(base.GetHashCode(), Name, MarkUpForSale, mandatoryExpenses);
        }
        public override bool Equals(object obj)
        {
            if (obj is Buns p)
            {
                return (p.Name == Name && p.MarkUpForSale == MarkUpForSale && p.mandatoryExpenses == mandatoryExpenses);
            }
            else return false;
        }
    }
}
