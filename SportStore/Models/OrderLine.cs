﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportStore.Models
{
    public class OrderLine
    {
        public int Id { get; set; }
        public int Count { get; set; }

        public int ProductId { get; set; }
        public int OrderId { get; set; }

        public Product Product { get; set; }
        public Order Order { get; set; }
    }
}