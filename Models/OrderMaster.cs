﻿using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class OrderMaster
    {
        [Key]
        public int OrderId { get; set; }
        public int? UserId { get; set; }
        public float TotalPrice { get; set; }
        [Display(Name = "Payment Type")]
        public string? Type { get; set; }
        public string? BankName { get; set; }
        public int? CardNo { get; set; }
        public int? CCV { get; set; }
        public virtual UserList User { get; set; }
        public virtual ICollection<OrderDetails>? OrderDetails { get; set; }
    }
}
