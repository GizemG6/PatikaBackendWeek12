namespace Survivor.Model.Entities
{
    public class Competitor : BaseEntity
    {
        // Name of the competitor
        public string Name { get; set; }

        // Foreign key for Category
        public int CategoryId { get; set; }

        // Navigation property: Each competitor belongs to one category
        public Category Category { get; set; }
    }
}
