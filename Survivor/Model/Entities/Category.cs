namespace Survivor.Model.Entities
{
    public class Category : BaseEntity
    {
        // Name of the category
        public string Name { get; set; }

        // Navigation property: One category can have many competitors
        public ICollection<Competitor> Competitors { get; set; } = new List<Competitor>();
    }
}
