
namespace OOPTask.Models
{
    public class OrderStatus : BaseEntity
    {
        private string status = "Prepearing";

        public Orders Orders { get; set; }
        public string Status { get => status; set => status = value; }
    }
}
