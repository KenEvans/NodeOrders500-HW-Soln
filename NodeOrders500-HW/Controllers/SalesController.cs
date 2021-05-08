using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NodeOrders500_HW.Controllers
{
    public class SalesController : ApiController
    {
        NodeOrders500Entities myDB = new NodeOrders500Entities();

        [HttpGet]
        public IHttpActionResult GetSalesPeople()
        {
            var allSalesPeople = from salesPpl in myDB.SalesPersonTables
                                 orderby salesPpl.LastName ascending
                                 select new { salesPpl.LastName,
                                              salesPpl.FirstName,
                                              salesPpl.salesPersonID };
            return Json(allSalesPeople);
        }
    }
}
