using C__RIWI.src.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace C__RIWI.src.Domain
{



  public class AppDBContext : DbContext
  {
    public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
    {
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Order> Orders { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      //.HasMany(u => u.Ordenes)-> Esto indica que un Usuario puede tener muchas órdenes (HasMany), y especificamos que el usuario tiene una colección de órdenes (Ordenes), lo que corresponde a la propiedad de navegación en la entidad Usuario:
      //public IEnumerable<Orden> Ordenes { get; set; }

      /*
      .WithOne(o => o.Usuario)
      Esto indica que cada Orden está asociada con un único Usuario (WithOne). Aquí estamos diciendo que la entidad Orden tiene una propiedad de navegación hacia el usuario (Usuario), que es la relación inversa de la colección de órdenes en la entidad Usuario.

      */
      modelBuilder.Entity<User>().HasMany(u => u.Orders).WithOne(o => o.User);
       modelBuilder.Entity<Product>().HasMany(p => p.Orders).WithOne(o => o.Product);

      // Orden tiene un usuario con muchas órdenes
      modelBuilder.Entity<Order>().HasOne(o => o.User).WithMany(u => u.Orders).HasForeignKey(o => o.UserId);
      // Orden tiene un producto con muchas órdenes

      modelBuilder.Entity<Order>()
          .HasOne(o => o.Product)
          .WithMany(p => p.Orders)
          .HasForeignKey(o => o.ProductId);

    }
  }
}