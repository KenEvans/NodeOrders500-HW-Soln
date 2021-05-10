using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NodeOrders500_HW.Controllers
{
    public class Query2Controller : ApiController
    {
        NodeOrders500Entities myDB = new NodeOrders500Entities();

        [HttpGet]
        public IHttpActionResult GetAnnualSales(string lastName)
        {
            try
            {
                var annualSales = (from salesPerson in myDB.Orders
                                   where salesPerson.SalesPersonTable.LastName == lastName
                                   select salesPerson.pricePaid).Sum();
                return Json(annualSales);
            }
            catch (Exception)
            {

                return Json(0);
            }
            
        }
    }
}
