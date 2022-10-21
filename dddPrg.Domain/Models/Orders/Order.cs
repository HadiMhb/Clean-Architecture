using dddPrg.Domain.DomainEvents.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dddPrg.Domain.Models.Orders
{
    public class Order:Entity
    {
        public Order()
        {
            _orderItems = new List<OrderItem>();
        }

        public Order(int id, int userId,DateTime createdAt) : this()
        {
            Id = id;
            UserId = userId;
            CreatedAt = createdAt;
        }

        public int Id { get; private set; }
        public int UserId { get; private set; }
        public DateTime CreatedAt { get; private set; }


        private readonly List<OrderItem> _orderItems;
        public IReadOnlyCollection<OrderItem> OrderItems => _orderItems;

        public void AddItem(List<OrderItem> orderItems)
        {
            foreach(var item in orderItems)
            {
                _orderItems.Add(item);

                AddDomainEvent(new OrderAddedEvent(UserId));
            }
        }
    }
}
