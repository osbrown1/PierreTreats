using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PierreSweets.Models
{
  public class Treat
  {
    public int TreatId { get; set; }
    [Required(ErrorMessage = "The treats's name can't be empty!")]
    public string Name {get; set;}
    public List<TreatFlavor> JoinEntities { get;}
    public ApplicationUser User { get; set; }
  }
}