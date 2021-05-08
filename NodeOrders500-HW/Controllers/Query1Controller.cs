using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NodeOrders500_HW.Controllers
{
    public class Query1Controller : ApiController
    {
        NodeOrders500Entities myDB = new NodeOrders500Entities();
        public IEnumerable<Order> GetOrders()
        {
            return myDB.Orders;
        }
    }
}
