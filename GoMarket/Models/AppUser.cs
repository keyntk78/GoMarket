using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace GoMarket.Models
{
    public class AppUser : IdentityUser
    {
        [StringLength(100)]
        public string? FullName { set; get; }

    }
}
