
namespace OOPTask.Models
{
    public class Preparer : BaseEntity
    {
        private string companyName = null!;

        public string CompanyName { get => companyName; set { if (companyName.Length >= 5) companyName = value; } }
        public ICollection<PreparerEmployeeInfo> EmployeesInfo { get; set; } = null!;
        public ICollection<Orders>? Orders { get; set; }
    }
}
