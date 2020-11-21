using ProductsLib;
using System.Collections.Generic;

namespace BakeryLib.Factories
{
    interface IBakeryFactory
    {
        public BakeryProduct CreateBakeryProduct(List<IProduct> products);
    }
}

