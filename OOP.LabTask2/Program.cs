using OOP.LabTask2.Services;

namespace OOP.LabTask2
{
    public static class Program
    {
        public delegate void ControllerRegister(User user,Company company);
        public delegate void ControllerLogin(Company company,string email,string password);
        public delegate void ControllerGetAll(Company company);

        public static void Main()
        {
            User user = new()
            {
                Name = "Qudrat",
                Surname = "Abidzada",
                Password = "password",
            };
            User user2 = new()
            {
                Name = "Zulfuqar",
                Surname = "Ka",
                Password = "password2",
            };
            Company company = new() { Name = "salam" };
            ControllerRegister register = new(Controller.Register);
            ControllerLogin login = new(Controller.Login);
            ControllerGetAll getAll = new(Controller.GetAll);
            register.Invoke(user, company);
            login.Invoke(company, "qudrat.abidzada@gmail.com", "password");
            getAll.Invoke(company);

            //company.Register(user);
            //company.Register(user2);
            //company.GetById(2);
            //company.UpdateById(2, "salam", "aleykum");
            //company.DeleteUser(2);
            //company.GetAll();
        }

    }
}