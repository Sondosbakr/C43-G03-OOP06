using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assignment06OOP.ThirdProject
{
    internal abstract class User
    {
        public string Name { get; set; }

        public User(string name)
        {
            Name = name;
        }
        public abstract Discount GetDiscount();
       
    }

    class RegularUser : User
    {
        public RegularUser(string name):base(name)
        {

        }
        public override Discount GetDiscount()
        {
            return new PercentageDiscount(5);
        }
    }

    class PremiumUser : User
    {
        public PremiumUser(string name) : base(name)
        { }
        public override Discount GetDiscount()
        {
            return new FlatDiscount(100);
        }
    }

    class GuestUser : User
    {
        public GuestUser(string name) : base(name)
        { }
        public override Discount GetDiscount()
        {
            return null;
        }
    }

}

