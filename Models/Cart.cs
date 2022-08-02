﻿using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class Cart
    {

        [Key]
        public int CartId { get; set; }

        public int UserId { get; set; }


        public int FoodId { get; set; }
        public int Qnt { get; set; }
        public virtual UserList User { get; set; }
        public virtual Food Food { get; set; }
    }
}
