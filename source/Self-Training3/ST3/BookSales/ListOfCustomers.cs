using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSales
{
    class ListOfCustomers
    {
        List<Customers> listCustomerses = new List<Customers>();
        public List<Customers> Customer
        {
            get { return listCustomerses; }
        }

        public void Buy(Customers cs)
        {
            listCustomerses.Add(cs);
        }

        public int TotalCustomers
        {
            get { return listCustomerses.Count; }
        }

        public int TotalCustomersIsStudent
        {
            get
            {
                int numStudent = 0;
                foreach (Customers cs in listCustomerses)
                {
                    if (cs.IsStudent == true)
                    {
                        numStudent++;
                    }
                }
                return numStudent;
            }
        }

        public double TotalRevenue
        {
            get
            {
                double sum = 0;
                foreach (Customers cs in listCustomerses)
                {
                    sum += cs.Charged;
                }
                return sum;
            }
        }
    }
}
