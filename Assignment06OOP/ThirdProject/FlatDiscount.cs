using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment06OOP.ThirdProject
{
    internal class FlatDiscount : Discount
    {
        private readonly decimal flatAmount;

        public FlatDiscount(decimal flatAmount):base("FlatDiscount")
        {
            this.flatAmount = flatAmount;
        }
        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            return flatAmount * Math.Min(quantity, 1);
        }
    }
}
