using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dddPrg.Domain.Models.Products
{
    public class ProductTag
    {
        public ProductTag(int id, int productId, int tagId)
        {
            Id = id;
            ProductId = productId;
            TagId = tagId;
        }

        public int Id { get; private set; }
        public int ProductId { get; private set; }
        public int TagId { get; private set; }
    }
}
