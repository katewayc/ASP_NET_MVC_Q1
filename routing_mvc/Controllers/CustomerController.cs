using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using routing_mvc.Models;

namespace routing_mvc.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Detail()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Check([Bind(Include = "Name,Phone,Email")]Customer customer)
        {
            if (ModelState.IsValid)
            {
                return View(customer);
            }

            return View("Detail", customer);
        }
    }
}