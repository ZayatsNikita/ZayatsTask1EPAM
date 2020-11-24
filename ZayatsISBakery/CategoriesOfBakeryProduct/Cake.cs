namespace BakeryLib.CategoriesOfBakeryProduct
{
    /// <summary>
    /// this class is the base class for the Cake type
    /// <para>Sets a mark-up for cake products</para>
    /// </summary>
    public abstract class Cake : BakeryProduct
    {
         public Cake()
        {
            markUpForSale = 300;
        }
    }
}

