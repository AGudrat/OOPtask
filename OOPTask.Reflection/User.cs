namespace OOPTask.Reflection
{
    public class User
    {
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public string Method(string name, string surname)
        {
            if(name is not null)Name = name;
            if(surname is not null)Surname = surname;
            return $"{Name.ToLower().Trim()}.{Surname.ToLower().Trim()}@code.edu.az";
        }
    }
}
