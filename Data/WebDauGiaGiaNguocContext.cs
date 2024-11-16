using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebDauGiaGiaNguoc.Models;

namespace WebDauGiaGiaNguoc.Data
{
    public class WebDauGiaGiaNguocContext : DbContext
    {
        public WebDauGiaGiaNguocContext (DbContextOptions<WebDauGiaGiaNguocContext> options)
            : base(options)
        {
        }

        public DbSet<WebDauGiaGiaNguoc.Models.User> User { get; set; }

        public DbSet<WebDauGiaGiaNguoc.Models.Category> Category { get; set; }

        public DbSet<WebDauGiaGiaNguoc.Models.Product> Product { get; set; }
        public object Users { get; internal set; }
    }
}
