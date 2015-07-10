using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WcfServicePizzaCodeFirst.Model
{
    public class OrderDetail
    {
        [Key]
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public string PizzaName { get; set; }
        public Pizza Pizza { get; set; }
        public int Quantity { get; set; }
    }
}