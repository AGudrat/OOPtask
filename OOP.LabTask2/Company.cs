using OOP.LabTask2.Services;

namespace OOP.LabTask2
{
    public class Company
    {
        public Company()
        {
            Users = new List<User>();
        }
        public string? Name { get; set; }
        public List<User> Users { get; set; } = null!;
       
    }
}