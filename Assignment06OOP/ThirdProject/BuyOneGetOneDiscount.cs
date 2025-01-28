using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment06OOP.ThirdProject
{
    internal class BuyOneGetOneDiscount : Discount
    {
        public BuyOneGetOneDiscount() : base("BuyOneGetOneDiscount")
        { 
        }
        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            return (price / 2) * (quantity / 2);
        }
    }
}
