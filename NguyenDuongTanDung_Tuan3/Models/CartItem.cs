﻿using System.ComponentModel.DataAnnotations;

namespace NguyenDuongTanDung_Tuan3.Models
{
    public class CartItem
    {
        [Key]
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
