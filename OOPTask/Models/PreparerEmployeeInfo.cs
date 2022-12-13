
namespace OOPTask.Models
{
    public class PreparerEmployeeInfo : BaseEntity<int>
    {
        private string nameSurname = null!;
        private string name = null!;
        private string surname = null!;

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string NameSurname { get => nameSurname; set => nameSurname = $"{Name}+{Surname}"; }
        public Preparer Preparer { get; set; } = null!;
    }
}
