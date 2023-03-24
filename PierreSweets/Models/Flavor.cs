namespace YourNamespace.Models
{
    public class Flavor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<TreatFlavor> JoinEntities { get; set; }
    }
}