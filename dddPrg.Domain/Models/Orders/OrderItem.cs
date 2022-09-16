﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dddPrg.Domain.Models.Orders
{
    public class OrderItem
    {
        public OrderItem(int id, int productId, int orderId, DateTime createdAt, decimal price)
        {
            Id = id;
            OrderId = orderId;
            ProductId = productId;
            CreatedAt = createdAt;
            Price = price;
        }

        public int Id { get; private set; }
        public int OrderId { get; private set; }
        public int ProductId { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public decimal Price { get; private set; }
    }
}