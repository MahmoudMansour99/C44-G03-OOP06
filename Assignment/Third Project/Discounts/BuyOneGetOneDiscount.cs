using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Third_Project.Discounts
{
    internal class BuyOneGetOneDiscount : Discount
    {
        public BuyOneGetOneDiscount()
        {
            Name = "Buy One Get One 50% Off";
        }
        public override decimal CalcDiscount(decimal price, int quantity)
        {
            return (price / 2) * (quantity / 2);
        }
    }
}
