using System;
using System.Collections.Generic;
using System.Text;

namespace BakeryLib
{
    interface IBakeryProductManager
    {
        public abstract double GetCaloric();
        public abstract decimal GetPrice();
    }
}
