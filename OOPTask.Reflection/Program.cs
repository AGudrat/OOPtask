using OOPTask.Reflection;
using System.Reflection;
using System.Xml.Linq;

public class Program
{
    public static void Main()
    {
        Console.Write("Ad daxil edin:");
        string name = Console.ReadLine();
        Console.Write("Soyad daxil edin:");
        string surname = Console.ReadLine();
        name = MailOperation.CharacterRegulatory(name);
        surname = MailOperation.CharacterRegulatory(surname);
        User user = new() { Name = name, Surname = surname };
        Console.WriteLine($"{typeof(User).GetProperty("Name").Name}: {typeof(User).GetProperty("Name").GetValue(user)}");
        Console.WriteLine($"{typeof(User).GetProperty("Surname").Name}: {typeof(User).GetProperty("Surname").GetValue(user)}");
        InvokeHelloMethod(user);
    }

    private static void InvokeHelloMethod(object obj)
    {
        Type type = obj.GetType();
        MethodInfo? methodInfo = type.GetMethod("Method", new Type[] { typeof(string), typeof(string) });
        string result = methodInfo.Invoke(obj, new object[] { null, null }).ToString();
        Console.WriteLine(result);
    }
}