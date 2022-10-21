using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dddPrg.Domain.Models.Users
{
    public class CustomIdentityUser :IdentityUser<int>
    {
        public CustomIdentityUser()
        {

        }

        [StringLength(32)]
        public string FirstName { get; private set; }
        [StringLength(32)]
        public string LastName { get; private set; }
        public long Mobile { get; private set; }
        [StringLength(32)]
        public string PhotoFileName { get; private set; }
        public DateTimeOffset? BirthDate { get; private set; }
        public DateTimeOffset? LastVisitDateTime { get; private set; }

        public void UpdatePurchasedNumber()
        {
            PurchaseNumber = PurchaseNumber + 1; 
        }

        public bool IsEmailPublic{ get; private set; }
        public string Location { get; private set; }
        public bool IsActive { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public int LoginCount { get; private set; }
        public int PurchaseNumber { get; private set; }
    }
}
