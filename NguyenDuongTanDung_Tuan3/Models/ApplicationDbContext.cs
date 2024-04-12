using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using NguyenDuongTanDung_Tuan3.Models;
namespace NguyenDuongTanDung_Tuan3.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationsUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<NguyenDuongTanDung_Tuan3.Models.CartItem> CartItem { get; set; } = default!;
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}
