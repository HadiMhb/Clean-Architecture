using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dddPrg.Domain.Models.Users
{
    public class UserTag
    {
        public UserTag(int id, int tagId, int userId)
        {
            Id = id;
            TagId = tagId;
            UserId = userId;
        }

        public int Id { get; private set; }
        public int UserId { get; private set; }  
        public int TagId { get; private set; }
    }
}
