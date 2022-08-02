﻿using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class OrderDetails
    {
        [Key]
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int FoodId { get; set; }
        public int Qnt { get; set; }
        public float Price { get; set; }
        public float TotalPrice { get; set; }
        public virtual OrderMaster? OrderMaster { get; set; }
        public virtual Food? Food { get; set; }

    }
}
