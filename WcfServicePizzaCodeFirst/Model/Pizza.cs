using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfServicePizzaCodeFirst.Model
{
    public class Pizza
    {
        public string PizzaName { get; set; }
        public string Type { get; set; }
        public double Price { get; set; }
        public byte[] Image { get; set; }
    }
}