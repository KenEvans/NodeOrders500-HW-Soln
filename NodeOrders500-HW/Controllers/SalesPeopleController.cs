using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NodeOrders500_HW.Controllers
{
    public class SalesPeopleController : ApiController
    {
        /// <summary>
        /// Get method to return all the salespeople for the dropdown (select) menu
        /// Returns last name, first name, and salesPersonID
        /// Written by Ken Evans
        /// </summary>
        
        NodeOrders500Entities myDB = new NodeOrders500Entities();

        [HttpGet]
        public IEnumerable<string> GetSalesPeople()
        {
            var allSalesPeople =
               (from salesP in myDB.Orders
                select salesP.SalesPersonTable.FirstName + " " + salesP.SalesPersonTable.LastName).Distinct().AsEnumerable();

            return allSalesPeople;
            //var allSalesPeople = from salesPpl in myDB.SalesPersonTables
            //                     orderby salesPpl.LastName ascending
            //                     select new { salesPpl.LastName,
            //                                  salesPpl.FirstName
            //                                   };
            //return Json(allSalesPeople);
        }
    }
}
