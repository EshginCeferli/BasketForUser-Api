using Microsoft.AspNetCore.Identity;

namespace Domain.Entities
{
    public class AppUser : IdentityUser
    {
        public string? Fullname { get; set; }
        public Basket Basket { get; set; }
    }
}
