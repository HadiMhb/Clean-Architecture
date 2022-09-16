using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dddPrg.Domain.Models.Products
{
    public class ProductRate
    {
        public ProductRate(int id, int productId, int userId, byte rate)
        {
            Id = id;
            ProductId = productId;
            UserId = userId;
            Rate = rate;
        }

        public int Id { get; private set; }
        public int ProductId { get; private set; }
        public int UserId { get; private set; }
        public byte Rate { get; private set; }
    }
}
