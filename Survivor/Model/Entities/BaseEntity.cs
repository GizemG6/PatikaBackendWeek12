namespace Survivor.Model.Entities
{
    // Base class for common entity properties
    public class BaseEntity
    {
        // Primary key
        public int Id { get; set; }

        // Created date
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        // Last modified date
        public DateTime? ModifiedDate { get; set; }

        public bool IsDeleted { get; set; }
    }
}
