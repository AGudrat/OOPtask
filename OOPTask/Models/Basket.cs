
namespace OOPTask.Models
{
    public class Basket : BaseEntity<int>
    {
        private int basketSize;

        public ICollection<Product>? Products { get; set; }
        public Customer Customer { get; set; } = null!;
        public int BasketSize { get => basketSize; set => basketSize = value; }
    }
}
