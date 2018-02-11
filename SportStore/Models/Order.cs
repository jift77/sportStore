﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Http;

namespace SportStore.Models
{
    public class Order
    {
        [HttpBindNever]
        public int Id { get; set; }
        [Required]
        public string Customer { get; set; }
        [Required]
        [HttpBindNever]
        public decimal TotalCost { get; set; }
        public ICollection<OrderLine> Lines { get; set; }
    }
}