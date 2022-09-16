using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dddPrg.Domain.Models.Products
{
    public class Product
    {
        public Product()
        {
            _comments = new List<Comment>();
            _productRates = new List<ProductRate>();
            _productTags = new List<ProductTag>();
        }

        public Product(int id, string title, string body, DateTime createdAt, decimal price, string imagePath, string filePath, short productCategoryId, bool isVisible, bool isDeleted, bool isSellable)
        :this(){
            Id = id;
            Title = title;
            Body = body;
            CreatedAt = createdAt;
            Price = price;
            ImagePath = imagePath;
            FilePath = filePath;
            ProductCategoryId = productCategoryId;
            IsVisible = isVisible;
            IsDeleted = isDeleted;
            IsSellable = isSellable;
        }

        public int Id { get; private set; }
        public string Title { get; private set; }
        public string Body { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public decimal Price { get; private set; }
        public string ImagePath { get; private set; }
        public string FilePath { get; private set; }
        public short ProductCategoryId { get; private set; }
        public bool IsVisible { get; private set; }
        public bool IsDeleted { get; private set; }
        public bool IsSellable { get; private set; }

        private readonly List<Comment> _comments;
        public IReadOnlyCollection<Comment> Comments => _comments;


        private readonly List<ProductRate> _productRates;
        public IReadOnlyCollection<ProductRate> ProductRates => _productRates;


        private readonly List<ProductTag> _productTags;
        public IReadOnlyCollection<ProductTag> ProductTags => _productTags;

    }
}
