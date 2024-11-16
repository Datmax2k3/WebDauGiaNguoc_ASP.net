using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using WebDauGiaGiaNguoc.Data;
using WebDauGiaGiaNguoc.Models;

namespace WebDauGiaGiaNguoc.Controllers
{
    public class AccountController : Controller
    {
        private readonly WebDauGiaGiaNguocContext _context;

        public AccountController(WebDauGiaGiaNguocContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            // Sinh số ngẫu nhiên từ 1 đến 8
            Random random = new Random();
            int randomNumber = random.Next(1, 9); // 9 is exclusive, so it generates numbers from 1 to 8
            ViewBag.RandomNumber = randomNumber;
            // Lấy tên người dùng hiện đang đăng nhập
            var username = User.Identity.Name;

            // Lấy thông tin người dùng từ database
            var user = _context.User.FirstOrDefault(u => u.Username == username);

            // Truyền thông tin người dùng hiện tại đến view
            return View(user);
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(User _userFromPage)
        {
            var _user = _context.User.Where(m => m.Username == _userFromPage.Username && m.UserPassword == _userFromPage.UserPassword).FirstOrDefault();
            if (_user == null)
            {
                ViewBag.LoginStatus = 0;
            }
            else
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, _user.Username),
                    new Claim("FullName", _user.FullName),
                    new Claim(ClaimTypes.Role, _user.Username),
                    new Claim(ClaimTypes.Email, _user.Email),
                };

                var claimsIdentity = new ClaimsIdentity(
                    claims, CookieAuthenticationDefaults.AuthenticationScheme);

                var authProperties = new AuthenticationProperties
                {
                };

                HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity),
                    authProperties);
                return RedirectToAction("Index", "Account");
            }
            return View();
        }
        public IActionResult Logout()
        {
            HttpContext.SignOutAsync(
            CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Account");
        }
    }
}
