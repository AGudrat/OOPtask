
namespace OOPTask.Models
{
    public class ProductType : BaseEntity<int>
    {
        private string type = null!;
        public string Type { get => type; set {if(value.Length >=5) type = value; } }
        public ICollection<Product> Products { get; set; } = null!;
    }
}
