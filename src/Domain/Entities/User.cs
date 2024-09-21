using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace C__RIWI.src.Domain.Entities
{
  public class User

  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string Phone { get; set; }
    //Cuando la relacion es de uno a mucho, desde la fuerte guardamos una lista de la debil
    public IEnumerable<Order> Orders { get; set; }
  }
}