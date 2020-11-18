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


        public override bool Equals(object obj)
        {
            if (obj is Pies p)
            {
                return p.Name == Name;
            }
            else
            {
                return false;
            }
        }
    }
}
