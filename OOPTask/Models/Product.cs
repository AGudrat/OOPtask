
namespace OOPTask.Models
{
    public class Product : BaseEntity<int>
    {
        private double price = 0.99;
        private double rate = 0;
        private string name = null!;

        public string Name
        {
            get => name;
            set
            {
                if (value.Length >= 3)
                { name = value; }
            }
        }
        public double Price
        {
            get => price;
            set
            {
                if (value > 0.99)
                { price = value; }
            }
        }
        public double Rate { get => rate; set => rate = value; }
        public ProductType ProductType { get; set; } = null!;
    }
}
