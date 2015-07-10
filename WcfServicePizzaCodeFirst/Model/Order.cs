using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfServicePizzaCodeFirst.Model
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public string Address { get; set; }
        public bool Status { get; set; }
        public string PhoneNo { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}