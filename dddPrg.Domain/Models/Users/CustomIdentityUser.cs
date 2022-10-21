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
        public string FirstName { get; set; }
        [StringLength(32)]
        public string LastName { get; set; }
        public long Mobile { get; set; }
        [StringLength(32)]
        public string PhotoFileName { get; set; }
        public DateTimeOffset? BirthDate { get; set; }
        public DateTimeOffset? LastVisitDateTime { get; set; }

        public void UpdatePurchasedNumber()
        {
            PurchaseNumber = PurchaseNumber + 1; 
        }

        public bool IsEmailPublic{ get; set; }
        public string Location { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public int LoginCount { get; set; }
        public int PurchaseNumber { get; set; }
    }
}
