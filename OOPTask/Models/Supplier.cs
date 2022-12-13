
namespace OOPTask.Models
{
    public class Supplier : BaseEntity<int>
    {
        private string companyName = null!;

        public string CompanyName { get => companyName; set { if (companyName.Length >= 5) companyName = value; } }
        public ICollection<Orders>? Orders { get; set; }
        public ICollection<SupploerEmployeeInfo> EmployeesInfo { get; set; } = null!;
    }
}
