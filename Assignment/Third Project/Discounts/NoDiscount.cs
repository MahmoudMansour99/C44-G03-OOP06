using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Third_Project.Discounts
{
    internal class NoDiscount : Discount
    {
        public NoDiscount()
        {
            Name = "No Discount";
        }

        public override decimal CalcDiscount(decimal price, int quantity)
        {
            return 0;
        }
    }
}
