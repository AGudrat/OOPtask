

namespace OOPTask.Models
{
    public class CustomerInfo : BaseEntity
    {
        private string nameSurname = null!;
        private string name = null!;
        private string surname = null!;
        private string? address;
        private string? addressHeader;
        private string? cellphone;

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string NameSurname { get => nameSurname; set => nameSurname = $"{Name}+{Surname}"; }
        public string? Address { get => address; set => address = value; }
        public string? AddressHeader { get => addressHeader; set => addressHeader = value; }
        public string? Cellphone { get => cellphone; set { if (value?.Length == 9) cellphone = $"+994{value}"; } }
        public Customer Customer { get; set; } = null!;
    }
}
