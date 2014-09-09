using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["Message"] = "欢迎使用 ASP.NET MVC!";

            return View();
        }
        public void test()
        {
            Response.Write("nihao");
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
