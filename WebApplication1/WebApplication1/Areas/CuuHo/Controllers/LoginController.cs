using Model.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Areas.CuuHo.Models;
using WebApplication1.Common;

namespace WebApplication1.Areas.CuuHo.Controllers
{
    public class LoginController : Controller
    {
        // GET: CuuHo/Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(LoginModel login)
        {
            if (ModelState.IsValid)
            {
                var dao = new LoginDAO();
                var result = dao.login(login.UserName, Encryptor.EncryptMD5(login.Password));
                if (result == 1)
                {
                    //ModelState.AddModelError("","Đăng nhập thành công");
                    return RedirectToAction("Index", "Admin");

                }
                else if (result == 2)
                {
                    return RedirectToAction("Index", "User");
                }
                if (result == 0)
                {
                    ModelState.AddModelError("", " Tài khoản hoặc mật khẩu sai");
                }
                if (result == 3)
                {
                    return RedirectToAction("Index", "Rescue_Center");
                }
            }
            return View("Index");

        }
    }
}