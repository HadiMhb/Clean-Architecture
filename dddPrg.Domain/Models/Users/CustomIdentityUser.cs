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
        [StringLength(32)]
        public string FirstName { get; private set; }
        [StringLength(32)]
        public string LastName { get; private set; }
        public long Mobile { get; private set; }
        [StringLength(32)]
        public string PhotoFileName { get; private set; }
        public DateTimeOffset BirthDate { get; private set; }
        public string ImagePath { get; private set; }
        public string FilePath { get; private set; }
        public short ProductCategoryId { get; private set; }
        public bool IsVisible { get; private set; }
        public bool IsDeleted { get; private set; }
        public bool IsSellable { get; private set; }
    }
}
