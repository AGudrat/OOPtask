
namespace OOPTask.Models
{
    public class Orders : BaseEntity<int>
    {

        public Customer Customer { get; set; } = null!;
        public Seller Seller { get; set; } = null!;
        public Supplier Supplier { get; set; } = null!;
        public ICollection<Product> Products { get; set; } = null!;
        public OrderStatus Status { get; set; }
    }
}
