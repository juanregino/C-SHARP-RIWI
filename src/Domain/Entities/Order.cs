using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace C__RIWI.src.Domain.Entities
{
  public class Order
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public string UserId { get; set; }

    public string ProductId { get; set; }

    public double TotalPrice { get; set; }
    public DateTime OrderDate { get; set; }
  [ForeignKey("ProductId")]
    public Product Product { get; set; }
    [ForeignKey("UserId")]
  public User User { get; set; }
  }
}