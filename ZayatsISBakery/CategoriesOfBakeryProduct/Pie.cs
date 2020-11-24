namespace BakeryLib.CategoriesOfBakeryProduct
{
    /// <summary>
    /// this class is the base class for the Pie type
    /// <para>Sets a mark-up for pie products</para>
    /// </summary>
    public abstract class Pie : BakeryProduct
    {

        public Pie()
        {
            markUpForSale = 400;
        }
    }
}
