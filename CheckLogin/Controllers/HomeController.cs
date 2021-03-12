using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CheckLogin.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        [AllowAnonymous] // đối với action cho phép truy cập không cần kiểm tra
        public ActionResult Index()
        {
            return View();
        }
        //Muốn kiểm tra đăng nhập thì viết Authori/ có thể kiểm tra cả controller
        [Authorize]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        [Authorize]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}