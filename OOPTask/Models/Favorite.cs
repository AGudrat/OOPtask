
namespace OOPTask.Models
{
    public class Favorite : BaseEntity<int>
    {
        private int favoriteSize = 0;

        public Customer Customer { get; set; } = null!;
        public ICollection<Product>? Products { get; set; }
        public int FavoriteSize { get => favoriteSize; set => favoriteSize = value; }
    }
}
