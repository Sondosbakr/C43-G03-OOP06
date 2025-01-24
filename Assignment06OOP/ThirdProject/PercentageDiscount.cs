using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment06OOP.ThirdProject
{
    internal class PercentageDiscount : Discount
    {

        private readonly decimal percentage;
        public PercentageDiscount(decimal percentage) : base("PercentageDiscount")
        {
            this.percentage = percentage;
        }

        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            return price * quantity * (percentage / 100);
        }
    }
}
