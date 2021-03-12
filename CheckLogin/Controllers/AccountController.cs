using CheckLogin.Models;
using System.Web.Mvc;
using System.Web.Security;

namespace CheckLogin.Controllers
{
    public class AccountController : Controller
    {
        public ViewResult Login(string returnUrl)
        {
            ViewBag.returnUrl = returnUrl;
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Login(AccountModel acc, string ReturnUrl)
        {
            if (ModelState.IsValid)
            {
                if (acc.Username == "admin" && acc.Password == "123123")
                {
                    FormsAuthentication.SetAuthCookie(acc.Username, true);
                    return RedirectToLocal(ReturnUrl);
                }
            }
            return View(acc);
        }
        // Hàm đăng xuất khỏi chương trình
        public ActionResult Logoff()
        {
            FromsAuthentication.SignOut();
            return RedirectToLocal("Index", "Home");
        }
    }
    private ActionResult RedirectToLocal(string returnUrl)
    {
        if (Url.IsLocalUrl(returnUrl))
        {
            return Redirect(returnUrl);
        }
        else
        {
            return RedirectToAction("Index", "Home");

        }
    }
}







                    