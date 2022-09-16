using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dddPrg.Domain.Models.Orders
{
    public class Order
    {
        public Order()
        {
            _orderItems = new List<OrderItem>();
        }

        public Order(int id, int userId) : this()
        {
            Id = id;
            UserId = userId;
        }

        public int Id { get; private set; }
        public int UserId { get; private set; }


        private readonly List<OrderItem> _orderItems;
        public IReadOnlyCollection<OrderItem> OrderItems => _orderItems;
    }
}
