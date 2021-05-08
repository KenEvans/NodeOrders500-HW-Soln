using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NodeOrders500_HW.Controllers
{
    public class StoresController : ApiController
    {
        NodeOrders500Entities myDB = new NodeOrders500Entities();

        [HttpGet]
        public IHttpActionResult GetAllStores()
        {
            var allStores = from myStores in myDB.StoreTables
                                 orderby myStores.City ascending
                                 select new
                                 {
                                     myStores.City,
                                     myStores.storeID
                                 };
            return Json(allStores);
        }
    }
}
