
namespace OOPTask.Models
{
    public class BaseEntity
    {
        private Guid ıd = Guid.NewGuid();
        private DateTime createdDate = DateTime.UtcNow.AddHours(4); //Azərbaycan Saatına keçirmək üçün +4 edirik.

        public Guid Id { get => ıd; set => ıd = value; }
        public DateTime CreatedDate { get => createdDate; set => createdDate = value; }
        public DateTime UpdatedDate { get; set; }
        public bool IsDeledet { get; set; }
    }
}
