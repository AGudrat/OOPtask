
using OOPTask.Enums.Enums;
using System.Collections.Concurrent;
using System.Reflection;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System;
using System.Xml.Linq;

public static class Program
{
    public static void Main()
    {
        Console.Write("1. Colors\n2. DbConnection\nEnum seçin: ");
        int choosen = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        switch (choosen)
        {
            case 1:
                Console.Write("1. Red\n2. Purple\n3. Green\nSeçim edin : ");
                int selectionColor = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"{(Colors)selectionColor} : {((Colors)selectionColor).GetAttribute(),5}");
                break;
            case 2:
                Console.Write("1. Sql\n2. MySql\n3. Oracle\nSeçim edin : ");
                int selectionDb = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"{(DbConnections)selectionDb} : {((DbConnections)selectionDb).GetAttribute(),5}");
                break;
            default:
                throw new Exception("Belə bir seçim yoxdur.");
        }
    }



    /// <summary>
    /// 
    /// </summary>
    /// <param name="enumValue">Write enum value</param>
    /// <returns>Enums display name</returns>
    public static string GetAttribute<T>(this T enumValue)
             where T : Enum
    {
        string? name = enumValue.GetType()
                                .GetMember(enumValue?.ToString())
                                .First()
                                .GetCustomAttribute<DisplayAttribute>().Name;
        return name;
    }
}

