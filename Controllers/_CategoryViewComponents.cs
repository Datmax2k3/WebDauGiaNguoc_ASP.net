using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebDauGiaGiaNguoc.Data;

namespace WebDauGiaGiaNguoc.Controllers
{
    [ViewComponent(Name = "_Category")]
    public class _CategoryViewComponents : ViewComponent
    {
        private readonly WebDauGiaGiaNguocContext _context;
        public _CategoryViewComponents(WebDauGiaGiaNguocContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var _category = _context.Category.ToList();
            return View("_Category", _category);
        }
    }
}
