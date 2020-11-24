namespace BakeryLib.CategoriesOfBakeryProduct
{
    /// <summary>
    /// this class is the base class for the Bread type
    /// <para>Sets a mark-up for bread products</para>
    /// </summary>
    public abstract class Bread : BakeryProduct
    {
        public Bread()
        {
            markUpForSale = 100;
        }
    }
}
