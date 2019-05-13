using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASP_NET_MVC_Q1.Models;

namespace ASP_NET_MVC_Q1.Controllers
{
    public class CustomerController : Controller
    {
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

            return RedirectToAction("Detail", customer);
        }

        public ActionResult Detail2()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Check2(Customer customer)
        {
          //  re - write server validation
            if (ModelState.IsValid)
            {
                return View(customer);
            }

            return RedirectToAction("Detail2", customer);
        }
    }
}