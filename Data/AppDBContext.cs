
using Microsoft.EntityFrameworkCore;
public class AppDBContext: DbContext
{
 public AppDBContext(DbContextOptions<AppDBContext> options): base(options)
 {

 }

 public DbSet<Task> Tasks { get; set; }
}