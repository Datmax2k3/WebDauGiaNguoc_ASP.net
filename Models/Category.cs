using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebDauGiaGiaNguoc.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }

        [Required]
        [StringLength(50)]
        public String CategoryName { get; set; } // Khóa ngoại tới bảng Loại Sản Phẩm

        public ICollection<Product>? Products { get; set; }
    }
}
