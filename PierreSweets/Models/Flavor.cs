using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PierreSweets.Models
{
    public class Flavor
    {
        public int FlavorId { get; set; }

        [Required(ErrorMessage = "Please enter a name.")]
        [StringLength(100, MinimumLength = 1)]
        public string Name { get; set; }
        public List<TreatFlavor> JoinEntities { get; set; }
    }
}

