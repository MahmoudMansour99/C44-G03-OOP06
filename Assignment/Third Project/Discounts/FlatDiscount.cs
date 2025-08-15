using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Third_Project.Discounts
{
    internal class FlatDiscount : Discount
    {
        private decimal flatAmount;

        public FlatDiscount(decimal flatAmount)
        {
            this.flatAmount = flatAmount;
            Name = $"Flat Discount of {flatAmount:c}";
        }
        public override decimal CalcDiscount(decimal price, int quantity)
        {
            return flatAmount * Math.Min(quantity, 1);
        }
    }
}
