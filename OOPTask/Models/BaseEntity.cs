
namespace OOPTask.Models
{
    public class BaseEntity<Tkey> where Tkey : IEquatable<Tkey>
    {
        private DateTime createdDate = DateTime.UtcNow.AddHours(4); //Azərbaycan Saatına keçirmək üçün +4 edirik.
        public Tkey Id { get; set; }

        public DateTime CreatedDate { get => createdDate; set => createdDate = value; }
        public DateTime UpdatedDate { get; set; }
        public bool IsDeledet { get; set; }
    }
}
