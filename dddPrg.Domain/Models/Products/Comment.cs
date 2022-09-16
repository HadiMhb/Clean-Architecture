using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dddPrg.Domain.Models.Products
{
    public class Comment
    {
        public Comment(int id, int procustId, int userId, DateTime createdAt, string body, bool isVerified, int? parentId)
        {
            Id = id;
            ProcustId = procustId;
            UserId = userId;
            CreatedAt = createdAt;
            Body = body;
            IsVerified = isVerified;
            ParentId = parentId;
        }

        public int Id { get; private set; }
        public int ProcustId { get; private set; }
        public int UserId { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public string Body{ get; private set; }
        public bool IsVerified { get; private set; }
        public int? ParentId { get; private set; }

    }
}
