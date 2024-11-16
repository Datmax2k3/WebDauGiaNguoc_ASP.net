using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebDauGiaGiaNguoc.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }

        [Required]
        [StringLength(100)]
        public string ProductName { get; set; } // Tên sản phẩm

        [Required]
        [StringLength(100)]
        public string ImageUrl { get; set; } // Đường dẫn ảnh sản phẩm

        [Required]
        public decimal StartingPrice { get; set; } // Giá khởi điểm

        public decimal CurrentPrice { get; set; } // Giá hiện tại

        [Required]
        public decimal EddingPrice { get; set; } // Giá cuối

        [Required]
        public DateTime StartTime { get; set; } // Thời gian bắt đầu đấu giá

        [Required]
        public DateTime EndTime { get; set; } // Thời gian kết thúc đấu giá

        [Required]
        [StringLength(50)]
        public string Status { get; set; } // Trạng thái: đang đấu giá, đã kết thúc, v.v.

        [Required]
        [StringLength(50)]
        public string? ResultBidUser { get; set; }

        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }
        public Category? Category { get; set; }

        [ForeignKey("UserId")]
        public int UserId { get; set; }
        public User? User { get; set; }
    }
}
