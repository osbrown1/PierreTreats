using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PierreSweets.Models
{
  public class Treat
  {
    public int TreatId { get; set; }

    [Required(ErrorMessage = "Please enter a name")]
    [StringLength(100, MinimumLength = 1)]
    public string Name { get; set; }

    public List<TreatFlavor> JoinEntities { get; }
    public ApplicationUser User { get; set; }
  }
}


// public int TreatId { get; set; }
    
//     [Required(ErrorMessage = "Please enter a name")]
//     public string Name {get; set;}
//     public List<TreatFlavor> JoinEntities { get;}
//     public ApplicationUser User { get; set; }