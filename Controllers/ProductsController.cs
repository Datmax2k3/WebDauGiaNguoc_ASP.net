using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebDauGiaGiaNguoc.Data;
using WebDauGiaGiaNguoc.Models;
using MailKit.Net.Smtp;
using MimeKit;
using WebDauGiaGiaNguoc.Configuration;
using WebDauGiaGiaNguoc.Services;
using Microsoft.Extensions.Options;
using System.Security.Claims;

namespace WebDauGiaGiaNguoc.Controllers
{
    public class ProductsController : Controller
    {
        private readonly WebDauGiaGiaNguocContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly SmtpSettings _smtpSettings;
        private readonly EmailService _emailService;

        public ProductsController(WebDauGiaGiaNguocContext context, IWebHostEnvironment webHostEnvironment, IOptions<SmtpSettings> smtpSettings, EmailService emailService)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
            _smtpSettings = smtpSettings.Value;
            _emailService = emailService;
        }

        // GET: Products
        public async Task<IActionResult> Index()
        {
            var webDauGiaGiaNguocContext = _context.Product.Include(p => p.Category).Include(p => p.User);
            return View(await webDauGiaGiaNguocContext.ToListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> UpdatePrice(int id, decimal newPrice)
        {
            Console.WriteLine($"Received request to update product with ID {id} to new price {newPrice}");

            var product = await _context.Product
                                .Include(p => p.User) // Include the User table
                                .FirstOrDefaultAsync(p => p.ProductID == id);

            if (product == null)
            {
                Console.WriteLine($"Product with ID {id} not found.");
                return NotFound();
            }

            Console.WriteLine($"Found product {product.ProductName} with current price {product.CurrentPrice}");

            product.CurrentPrice = newPrice;
            _context.Update(product);
            await _context.SaveChangesAsync();

            Console.WriteLine($"Updated product {product.ProductName} to new price {product.CurrentPrice}");

            if (product.CurrentPrice <= product.EddingPrice)
            {
                Console.WriteLine($"Product price {product.CurrentPrice} is less than or equal to EddingPrice {product.EddingPrice}");
                var emailClaim = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Email);
                var email = emailClaim?.Value;

                if (email != null)
                {
                    var sellerFullName = product.User.FullName; // Lấy tên của người bán
                    var sellerEmail = product.User.Email; // Lấy email của người bán
                    var subject = "Chúc mừng! Bạn đã đấu giá thành công";
                    var messageBody = $@"
                        <p>Xin chúc mừng {User.Identity.Name}, bạn đã đấu giá thành công cho sản phẩm {product.ProductName} với giá {product.CurrentPrice} VND.</p>
                        <p>Bạn hãy liên hệ với người muốn mua sản phẩm có tên {sellerFullName}</p>
                        <p>Thông qua Email này: {sellerEmail}</p>
                        <p>Xin cảm ơn!</p>";

                    try
                    {
                        Console.WriteLine($"User email: {email}"); // Log giá trị email
                        await _emailService.SendEmailAsync(email, subject, messageBody);
                        Console.WriteLine($"Email sent to {email}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"An error occurred while sending email: {ex.Message}");
                    }
                }
            }
            else
            {
                Console.WriteLine($"Product price {product.CurrentPrice} is greater than EddingPrice {product.EddingPrice}");
            }

            return Ok(new { success = true });
        }


        [HttpPost]
        public async Task<IActionResult> UpdateBidUser(int productId, string userName)
        {
            var product = await _context.Product.FindAsync(productId);
            if (product == null)
            {
                return NotFound();
            }

            product.ResultBidUser = userName;
            _context.Update(product);
            await _context.SaveChangesAsync();

            return Ok();
        }

        public async Task<IActionResult> ProductByCategory(int catId)
        {
            var webDauGiaGiaNguocContext = _context.Product.Include(p => p.Category).Where(p => p.CategoryId == catId);
            return View(await webDauGiaGiaNguocContext.ToListAsync());
        }

        public async Task<IActionResult> ProductDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Product
                .Include(p => p.Category)
                .FirstOrDefaultAsync(m => m.ProductID == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Products/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Product
                .Include(p => p.Category)
                .Include(p => p.User)
                .FirstOrDefaultAsync(m => m.ProductID == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Products/Create
        public IActionResult Create()
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
        public async Task<IActionResult> Create([Bind("ProductID,ProductName,ImageUrl,StartingPrice,CurrentPrice,EddingPrice,StartTime,EndTime,Status,ResultBidUser,CategoryId,UserId")] Product product, IFormFile file)
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

        // GET: Products/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Product.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            ViewData["CategoryId"] = new SelectList(_context.Category, "CategoryID", "CategoryName", product.CategoryId);
            ViewData["UserId"] = new SelectList(_context.User, "UserId", "Username", product.UserId);
            return View(product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProductID,ProductName,ImageUrl,StartingPrice,CurrentPrice,EddingPrice,StartTime,EndTime,Status,ResultBidUser,CategoryId,UserId")] Product product, IFormFile file)
        {
            if (id != product.ProductID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
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
                    _context.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.ProductID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = new SelectList(_context.Category, "CategoryID", "CategoryName", product.CategoryId);
            ViewData["UserId"] = new SelectList(_context.User, "UserId", "Username", product.UserId);
            return View(product);
        }

        // GET: Products/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Product
                .Include(p => p.Category)
                .Include(p => p.User)
                .FirstOrDefaultAsync(m => m.ProductID == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _context.Product.FindAsync(id);
            _context.Product.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(int id)
        {
            return _context.Product.Any(e => e.ProductID == id);
        }
    }
}
