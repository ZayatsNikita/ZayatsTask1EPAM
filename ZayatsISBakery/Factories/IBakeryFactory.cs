﻿using ProductsLib;
using System.Collections.Generic;

namespace BakeryLib.Factories
{
    interface IBakeryFactory
    {
        public static BakeryProduct CreateBakeryProduct(List<Product> products)=>null;
    }
}

