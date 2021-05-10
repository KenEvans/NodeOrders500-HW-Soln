using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NodeOrders500_HW.Controllers
{
    public class MarkupsController : ApiController
    {
        /// <summary>
        /// Get method for Query1 to return which stores are selling CDs for better markups
        /// Returns store/city name and the count of all CD sales over $13 per store
        /// Written by Ken Evans
        /// </summary>

        NodeOrders500Entities myDB = new NodeOrders500Entities();

        [HttpGet]
        public IHttpActionResult GetOrders()
        {
            var bestMarkups = from cdSales in myDB.Orders
                              where cdSales.pricePaid > 13
                              group cdSales by cdSales.StoreTable.City into salesCount
                              orderby salesCount.Count() descending
                              select new
                              {
                                  City = salesCount.Key,
                                  Count = salesCount.Count()
                              };
            return Json(bestMarkups);
        }
    }
}
