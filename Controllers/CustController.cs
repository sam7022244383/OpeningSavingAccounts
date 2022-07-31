using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataAccessLayer;
using BusinessLogic;

namespace OpeningSavingAccounts.Controllers
{
    public class CustController : Controller
    {
        
        // GET: Cust
        [HttpGet]
        public ActionResult CreateCustomer()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateCustomer(CustInfo cust)
        {
            CustInfoOperation customeroperation = new CustInfoOperation();
            bool result = customeroperation.InsertCust(cust);
            if(result)
            {
                ModelState.Clear();
                return View();
            }
            return View();
            
        }
    }
}