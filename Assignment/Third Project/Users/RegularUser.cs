using Assignment.Third_Project.Discounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Third_Project.Users
{
    internal class RegularUser : User
    {
        public RegularUser(string name) : base(name) { }

        public override Discount GetDiscount()
        {
            return new PercentageDiscount(5);
        }
    }
}
