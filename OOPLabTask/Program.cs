using OOPLabTask.Models;

namespace OOPLabTask
{
    public static class Program
    {
        public static void Main()
        {
            User user = new();
            Console.Write("Adınızı daxil edin: ");
            string name = Console.ReadLine();
            Console.Write("Soyadınızı daxil edin: ");
            string surname = Console.ReadLine();
            Console.Write("Emailinizi daxil edin: ");
            string email = Console.ReadLine();
            Console.Write("Parolunuzu daxil edin: ");
            string password = Console.ReadLine();
            if (user.PasswordChecker(password))
            {
                user.Name = name;
                user.Surname = surname;
                user.Email = email;
                user.Password = password;
            }
            else throw new Exception("Parolunuz qaydalara uyğun deyil;");
            user.ShowInfo();
        }


    }
}