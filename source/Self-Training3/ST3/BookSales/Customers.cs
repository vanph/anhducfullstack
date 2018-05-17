using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSales
{
    class Customers
    {
        private const double PRICE = 20000;
        public string Name { get; set; }
        public int NumberBuy { get; set; }
        public bool IsStudent { get; set; }

        public double Charged
        {
            get
            {
                if (IsStudent == true)
                {
                    return NumberBuy * PRICE * 0.95;
                }
                else
                {
                    return NumberBuy * PRICE;
                }
            }
        }
    }
}
