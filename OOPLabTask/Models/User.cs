using OOPLabTask.Interfaces;
using System.Collections;

namespace OOPLabTask.Models
{
    public class User : IAccaunt
    {
        private static int _id = 0;
        private string name = null!;
        private string surname = null!;
        private string email = null!;
        private string password = null!;

        public int Id
        {
            get => ++_id;
        }

        public string Fullname { get => $"{name} {surname}"; }
        public string Name
        {
            get => name;
            set
            {
                if (value.Length <= 3)
                    throw new Exception("Ad 3 simvoldan kiçik ola bilməz.");
                else if (value.Length >= 20)
                    throw new Exception("Ad 20 simvoldan çox ola bilməz.");
                else name = value;
            }
        }
        public string Surname
        {
            get => surname;
            set
            {
                if (value.Length <= 3)
                    throw new Exception("Soyad 3 simvoldan kiçik ola bilməz.");
                else if (value.Length >= 20)
                    throw new Exception("Soyad 20 simvoldan çox ola bilməz.");
                else surname = value;
            }
        }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public bool PasswordChecker(string password)
        {
            if (password.Length >= 8
                && password.Any(p => char.IsUpper(p))
                && password.Any(p => char.IsLower(p))
                && password.Any(p => char.IsNumber(p)))
            {
                return true;
            }
            return false;
        }

        public void ShowInfo()
        {

            Console.WriteLine($"Id: {Id}\nFullName: {Fullname}\nEmail: {Email}");
        }
    }
}
