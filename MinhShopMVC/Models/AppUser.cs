using Microsoft.AspNetCore.Identity;

namespace MinhShopMVC.Models
{
    public class AppUser:IdentityUser<Guid>
    {
        public int OrderId { set; get; }
        public int ProductId { set; get; }
        public int Quantity { set; get; }
        public decimal Price { set; get; }

        public Order ?Order { get; set; }

        public Product ?Product { get; set; }
    }
}
