namespace OOP.LabTask2.Services
{
    public class Controller
    {
        public delegate void LowLevelLoggerDelegate(string message);

        public static void Register(User user, Company company)
        {
            if (company.Users.Any(i => i.Name == user.Name || i.Surname == user.Surname))
            {
                Exception ex = new("İstifadəçi mövcuddur.");
                LowLevelLoggerDelegate lowLevelLoggerDelegate = new(Logger.SetLog);
                lowLevelLoggerDelegate.Invoke(ex.Message);
            }
            else company.Users?.Add(user);
        }
        public static void Login(Company company,string email, string password)
        {
            if (company.Users.Any(i => i.Email == email && i.Password == password))
            {
                Console.WriteLine("Giriş etdiniz");
            }
            else
            {
                Exception ex = new("İstifadəçi adı və ya parol yanlışdır");
                LowLevelLoggerDelegate lowLevelLoggerDelegate = new(Logger.SetLog);
                lowLevelLoggerDelegate.Invoke(ex.Message);
            }
        }
        public static void GetAll(Company company)
        {
            foreach (var user in company.Users)
            {
                Console.WriteLine($"{"Name",-10}: {user.Name}");
                Console.WriteLine($"{"Surname",-10}: {user.Surname}");
                Console.WriteLine($"{"Email",-10}: {user.Email}");
                Console.WriteLine($"{"Username",-10}: {user.Username}");
                Console.WriteLine(new String('-', 60));
            }
        }
        public static void GetById(Company company, int id)
        {
            var selectedUser = company.Users.FirstOrDefault(i => i.Id == id);
            if (selectedUser != null)
            {
                Console.WriteLine($"{"Name",-10}: {selectedUser.Name}");
                Console.WriteLine($"{"Surname",-10}: {selectedUser.Surname}");
                Console.WriteLine($"{"Email",-10}: {selectedUser.Email}");
                Console.WriteLine($"{"Username",-10}: {selectedUser.Username}");
                Console.WriteLine(new String('-', 60));
            }
            else
            {
                Exception ex = new("İstifadəçi tapilmadi");
                LowLevelLoggerDelegate lowLevelLoggerDelegate = new(Logger.SetLog);
                lowLevelLoggerDelegate.Invoke(ex.Message);

            }
        }
        public static void UpdateById(Company company, int id, string name, string surname)
        {
            var selectedUser = company.Users.FirstOrDefault(i => i.Id == id);
            if (selectedUser != null)
            {
                selectedUser.Surname = surname;
                selectedUser.Name = name;
            }
            else
            {
                Exception ex = new("İstifadəçi tapilmadi");
                LowLevelLoggerDelegate lowLevelLoggerDelegate = new(Logger.SetLog);
                lowLevelLoggerDelegate.Invoke(ex.Message);
            }
        }
        public static void DeleteUser(Company company, int id)
        {
            var selectedUser = company.Users.FirstOrDefault(i => i.Id == id);
            if (selectedUser != null) { company.Users.Remove(selectedUser); }
            else
            {
                Exception ex = new("İstifadəçi tapilmadi");
                LowLevelLoggerDelegate lowLevelLoggerDelegate = new(Logger.SetLog);
                lowLevelLoggerDelegate.Invoke(ex.Message);
            }
        }
    }
}
