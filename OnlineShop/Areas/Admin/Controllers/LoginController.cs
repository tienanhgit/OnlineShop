using OnlineShop.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models.Framework;
using Models;
using OnlineShop.Areas.Admin.Code;

namespace OnlineShop.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login

        [HttpGet]
        public ActionResult Index()
        {
   
            if (ModelState.IsValid)
            {

                return View();

            }
            else
            {
                ModelState.AddModelError("", "Ten dang nhap va mat khau khong dung !");

            }
            return null;


        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(LoginModel model)
        {
            var result = new AccountModel().Login(model.UserName, model.PassWord);
            if(result|| ModelState.IsValid)
            {
                SessionHelper.SetSession(new UserSession() { UserName=model.UserName});
                return RedirectToAction("Index", "Home");

            }
            else
            {
                ModelState.AddModelError("", "Ten dang nhap va mat khau khong dung !");

            }





            return View(model);
        }


    }
}