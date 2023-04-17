using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using ProduKey.Business;
using ProduKey.DataAccess;
using System.Security.Claims;

namespace ProduKey.UI.Controllers
{
    public class LoginController : Controller
    {
        public BaseController bc = new BaseController();

        public ProduKeyContext db;
        public LoginController()
        {
            db = new ProduKeyContext();
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(string kadi, string sifre)
        {
            var kontrol = db.Admins.FirstOrDefault(x => x.Mail == kadi && x.Password == sifre);
            if (kontrol != null)
            {
                var identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme);
                identity.AddClaim(new Claim(ClaimTypes.Name, kadi));
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(identity));

                return RedirectToAction("Index", "Admin");
            }
            else
            {
                return View();
            }
        }
    }
}
