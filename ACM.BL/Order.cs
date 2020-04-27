using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class Order
    {
        public Order()
        {

        }
        public Order(int orderID)
        {
            OrderID = orderID;
        }
        public int OrderID { get; private set; }
        public DateTimeOffset? OrderDate { get; set; }

        public Order Retreive(int orderID)
        {
            return new Order();
        }
        public bool Save()
        {
            return true;
        }
        public bool Validate()
        {
            var isValid = true;

            if (OrderDate == null) isValid = false;

            return isValid;
        }
    }
}
