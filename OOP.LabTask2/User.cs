namespace OOP.LabTask2
{
    public class User
    {
        private static int _id = 0;
        private string name = null!;
        private string surname =null!;
        private string password = null! ;

        
        public int Id { get => ++_id; } 
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Username { get => $"{Name}{Surname}".ToLower().Trim(); }
        public string Email { get => $"{Name}.{Surname}@gmail.com".ToLower().Trim(); }
        public string Password { get => password; set => password = value; }
    }
}