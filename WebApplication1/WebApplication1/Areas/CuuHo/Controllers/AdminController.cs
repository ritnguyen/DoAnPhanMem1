using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Areas.CuuHo.Models;
using WebApplication1.Common;

namespace WebApplication1.Areas.CuuHo.Controllers
{
    public class AdminController : Controller
    {
        // GET: CuuHo/Admin
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Logout()
        {
            Session[Constants.USER_SESSION] = null;
            return RedirectToAction("Index", "Login");
        }
    }
}