using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PierreSweets.Models
{
  public class Treat
  {
    public int TreatId { get; set; }
    [Required(ErrorMessage = "The treats's description can't be empty!")]
    public string Name {get; set;}
    public string Description { get; set; }
    [Range(1, int.MaxValue, ErrorMessage = "You must add your item to a category. Have you created a category yet?")]
    public List<TreatFlavor> JoinEntities { get;}
    public ApplicationUser User { get; set; }
  }
}