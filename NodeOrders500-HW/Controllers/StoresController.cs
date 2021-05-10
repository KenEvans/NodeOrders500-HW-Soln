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
        /// <summary>
        /// Get method to return all the stores for the dropdown (select) menu
        /// Returns city name and storeID
        /// Written by Ken Evans
        /// </summary>

        NodeOrders500Entities myDB = new NodeOrders500Entities();

        [HttpGet]
        public IEnumerable<string> GetAllStores()
        {
            var allStores =
                (from myStores in myDB.Orders
                 select myStores.StoreTable.City).Distinct().AsEnumerable();

            return allStores;

            //var allStores = from myStores in myDB.StoreTables
            //                     orderby myStores.City ascending
            //                     select new
            //                     {
            //                         myStores.City,
            //                         myStores.storeID
            //                     };
            //return Json(allStores);
        }
    }
}
