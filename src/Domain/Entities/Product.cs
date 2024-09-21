using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace C__RIWI.src.Domain.Entities
{
  public class Product
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }


    [Column(TypeName = "decimal(18,2)")]
    public double Price { get; set; }

    public int Stock { get; set; }

    public IEnumerable<Order>? Orders { get; set; }
  }
}