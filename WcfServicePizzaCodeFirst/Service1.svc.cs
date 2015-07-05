using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfServicePizzaCodeFirst.Model;
using WcfServicePizzaCodeFirst.Persistence;

namespace WcfServicePizzaCodeFirst
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public PizzaDbContext db = new PizzaDbContext();

        public bool SignUp(Customer customer)
        {
            try
            {
                db.Customers.Add(customer);
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public string Login(string phoneNo, string password)
        {
            try
            {
                Customer customer = db.Customers.Where(c => c.PhoneNo == phoneNo && c.Password == password).SingleOrDefault();
                if (customer == null)
                    return "false";
                return "true";
            }
            catch (Exception e)
            {
                return "I'm here" + e.InnerException.ToString();
            }
        }

        public bool CreatePizza(Pizza pizza)
        {
            try
            {
                db.Pizzas.Add(pizza);
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool OrderPizza(Order order, List<OrderDetail> orderDetails)
        {
            try
            {
                db.Orders.Add(order);
                foreach (var orderDetail in orderDetails)
                {
                    db.OrderDetails.Add(orderDetail);
                }
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }


        public List<Order> GetAllOrders()
        {
            var orders = db.Orders;
            List<Order> ordersList = null;
            if (orders != null)
            {
                ordersList = new List<Order>();
            }
            foreach (var order in orders)
            {
                ordersList.Add(order);
            }
            return ordersList;
        }


        public List<OrderDetail> GetOrderDetails(string orderId)
        {
            int orderIdInt = Int32.Parse(orderId);
            var orderDetails = db.OrderDetails.Where(o => o.OrderId == orderIdInt);
            List<OrderDetail> orderDetailsList = null;
            if (orderDetails != null)
            {
                orderDetailsList = new List<OrderDetail>();
            }
            foreach (var order in orderDetails)
            {
                orderDetailsList.Add(order);
            }
            return orderDetailsList;
        }
    }
}
