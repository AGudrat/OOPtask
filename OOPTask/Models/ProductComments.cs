
namespace OOPTask.Models
{
    public class ProductComments : BaseEntity
    {
        private string messageContent = null!;

        public Customer Customer { get; set; } = null!;
        public Product Product { get; set; } = null!;
        public string MessageContent { get => messageContent; set { if (value.Length >= 30) messageContent = value; } }
        public ICollection<ProductImageFile>? ProductImages { get; set; }
    }
}
