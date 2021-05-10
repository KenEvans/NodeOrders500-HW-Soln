using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NodeOrders500_HW.Controllers
{
    public class AnnualSalesController : ApiController
    {
        NodeOrders500Entities myDB = new NodeOrders500Entities();

        [HttpGet]
        public IHttpActionResult GetAnnualSales(string salesPeople)
        {
            try
            {
                var annualSales = (from salesPerson in myDB.Orders
                                   where salesPerson.SalesPersonTable.FirstName + " " + salesPerson.SalesPersonTable.LastName  == salesPeople
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
