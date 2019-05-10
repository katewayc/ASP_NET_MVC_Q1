using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASP_NET_MVC_Q1.Models;
using System.Web.Script.Serialization;
using System.IO;

namespace ASP_NET_MVC_Q1.Controllers
{
    public class DataController : Controller
    {
        public ContentResult Save(Customer customer)
        {
            var json = new JavaScriptSerializer().Serialize(customer);

            StreamWriter sw = new StreamWriter(Server.MapPath(@"~/App_Data/save_customer.txt"),true);
            sw.WriteLine(json);
            sw.Close();

            return Content("存檔路徑 : "+Server.MapPath(@"~/App_Data/save_customer.txt")+ "<br><br>存檔內容 : " + json);
        }
    }
}