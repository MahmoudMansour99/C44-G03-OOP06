using Assignment.Third_Project.Discounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Third_Project.Users
{
    internal class GuestUser:User
    {
        public GuestUser(string name) : base(name) { }

        public override Discount GetDiscount()
        {
            return new NoDiscount();
        }
    }
}
