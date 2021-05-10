using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NodeOrders500_HW.Controllers
{
    public class StoreSalesController : ApiController
    {
        NodeOrders500Entities myDB = new NodeOrders500Entities();

        [HttpGet]
        public IHttpActionResult GetStoreSales(string storeCity)
        {
            try
            {
                var storeSales =
                (from order in myDB.Orders
                 where order.StoreTable.City == storeCity
                 select order.pricePaid).Sum();

                return Ok(storeSales);
            }
            catch (Exception)
            {
                return Json(0);
            }
        }
    }
}
