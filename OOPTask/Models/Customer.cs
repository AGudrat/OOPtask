
namespace OOPTask.Models
{
    public class Customer : BaseEntity
    {
        private string? ıdCardNumber;
        private string? bankCard;
        private Basket? basket;
        private Favorite? favorite;
        private ICollection<Orders>? orders;

        public CustomerInfo CustomerInfo { get; set; } = null!;
        public string? IdCardNumber { get => ıdCardNumber; set { if (value?.Length == 8) { ıdCardNumber = value; } } }
        public string? BankCard { get => bankCard; set { if (value?.Length == 16) bankCard = value; } }
        public Basket? Basket { get => basket; set => basket = value; }
        public Favorite? Favorite { get => favorite; set => favorite = value; }
        public ICollection<Orders>? Orders { get => orders; set => orders = value; }
    }
}
