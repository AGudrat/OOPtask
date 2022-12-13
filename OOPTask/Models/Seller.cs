
namespace OOPTask.Models
{
    public class Seller : BaseEntity<int>
    {
        private string nameSurname = null!;
        private string name = null!;
        private string surname = null!;
        private string companyName = null!;

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string NameSurname { get => nameSurname; set => nameSurname = $"{Name}+{Surname}"; }
        public string CompanyName { get => companyName; set { if (companyName.Length >= 5) companyName = value; } }
        public ICollection<Orders>? Orders { get; set; }
    }
}
