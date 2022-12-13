
namespace OOPTask.Models
{
    public class SupploerEmployeeInfo : BaseEntity<int>
    {
        private string nameSurname = null!;
        private string name = null!;
        private string surname = null!;
        private string position = null!;

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string NameSurname { get => nameSurname; set => nameSurname = $"{Name}+{Surname}"; }
        public Supplier Supplier { get; set; } = null!;
        public string Position { get => position; set => position = value; }
        public ICollection<Orders>? Orders { get; set; }
    }
}
