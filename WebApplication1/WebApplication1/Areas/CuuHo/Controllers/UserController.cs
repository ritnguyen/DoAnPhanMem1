using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Areas.CuuHo.Controllers
{
    public class UserController : Controller
    {
        // GET: CuuHo/User
        public ActionResult Index()
        {
            return View();
        }
    }
}