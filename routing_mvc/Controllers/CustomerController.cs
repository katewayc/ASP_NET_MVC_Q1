﻿using System;
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

            return View("Detail2", customer);
        }

        [HttpPost]
        public ActionResult Verify(string Name)
        {
            var inValid = true;
            if (inValid)
            {
                return Json($"{Name} is not valid");
            }

            return Json(true);
        }


    }
}