using System;
using System.Collections.Generic;
using System.Text;

namespace ACMBL
{
    public class OrderDisplay
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTimeOffset? OrderDat { get; set; }
        public List<OrderDisplayItem> OrderDisplayItemList { get; set; }
        public int OrderId { get; set; }
        public Address ShippingAddress { get; set; }
    }
}
