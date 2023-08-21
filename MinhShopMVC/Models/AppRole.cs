using Microsoft.AspNetCore.Identity;

namespace MinhShopMVC.Models
{
    public class AppRole : IdentityRole<Guid>
    {
        public string ?Description { get; set; }
    }
}
