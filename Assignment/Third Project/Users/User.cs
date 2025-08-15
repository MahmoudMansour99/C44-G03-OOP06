using Assignment.Third_Project.Discounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Third_Project.Users
{
    internal abstract class User
    {
        public string? Name { get; set; }

        protected User(string? name)
        {
            Name = name;
        }
        public abstract Discount GetDiscount();
    }
}
