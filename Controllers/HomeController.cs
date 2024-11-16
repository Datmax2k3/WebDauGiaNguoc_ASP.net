using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using WebDauGiaGiaNguoc.Data;
using WebDauGiaGiaNguoc.Models;

namespace WebDauGiaGiaNguoc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly WebDauGiaGiaNguocContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public HomeController(ILogger<HomeController> logger, WebDauGiaGiaNguocContext context, IWebHostEnvironment webHostEnvironment)
        {
            _logger = logger;
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            var _product = _context.Product.Include(p => p.Category);
            return View(_product.ToList());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        //HTTP Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register([Bind("UserId,Username,UserPassword,Email,FullName,Address,PhoneNumber,Balance")] User user)
        {
            if (ModelState.IsValid)
            {
                // Kiểm tra xem UserName đã tồn tại trong cơ sở dữ liệu hay chưa
                var existingUser = await _context.User.FirstOrDefaultAsync(u => u.Username == user.Username);

                if (existingUser != null)
                {
                    // Nếu UserName đã tồn tại, thêm một thông báo lỗi vào ModelState
                    ModelState.AddModelError(string.Empty, "Tên người dùng đã tồn tại. Vui lòng chọn tên người dùng khác.");
                    return View(user);
                }

                // Nếu UserName chưa tồn tại, thêm người dùng mới vào cơ sở dữ liệu
                _context.Add(user);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }

        public IActionResult RegisterProduct()
        {
            ViewData["CategoryId"] = new SelectList(_context.Category, "CategoryID", "CategoryName");
            ViewData["UserId"] = new SelectList(_context.User, "UserId", "Username");
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RegisterProduct([Bind("ProductID,ProductName,ImageUrl,StartingPrice,CurrentPrice,EddingPrice,StartTime,EndTime,Status,ResultBidUser,CategoryId,UserId")] Product product, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                // Lưu hình ảnh vào đường dẫn cố định
                if (file != null && file.Length > 0)
                {
                    var fileName = Path.GetFileName(file.FileName);
                    var filePath = Path.Combine(_webHostEnvironment.WebRootPath, "img", fileName);
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }
                    product.ImageUrl = "/img/" + fileName; // Cập nhật đường dẫn hình ảnh trong sản phẩm
                }
                _context.Add(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = new SelectList(_context.Category, "CategoryID", "CategoryName", product.CategoryId);
            ViewData["UserId"] = new SelectList(_context.User, "UserId", "Username", product.UserId);
            return View(product);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
