using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShop.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login

        [HttpGet]

        public ActionResult Index()
        {
            return View();
        }

        //[HttpPost]
        //public ActionResult Index()


    }
}