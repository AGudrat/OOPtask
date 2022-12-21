using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using OOP.VCard.Models;
using System;

public static class Program
{
    public static void Main()
    {
        List<VCard> model = new();
        var client = new HttpClient();
        var task = client.GetAsync("https://randomuser.me/api?results=2")
          .ContinueWith((taskwithresponse) =>
          {
              var response = taskwithresponse.Result;
              var jsonString = response.Content.ReadAsStringAsync();
              jsonString.Wait();
              var json = JObject.Parse(jsonString.Result);
              model = JsonConvert.DeserializeObject<List<VCard>>(json["results"].ToString());
          });
        task.Wait();
        ConvertToVCard(model);
    }
    public static async void ConvertToVCard(List<VCard> model)
    {

        for (int i = 1; i <= model.Count; i++)
        {
            //Saves to C:\Users\user\Desktop\OOPTask\OOP.VCard\bin\Debug\net7.0

            string path = AppDomain.CurrentDomain.BaseDirectory;
            string textFileName = Path.Combine(path, $@"vcard{i}.txt");
            string vcfFileName = Path.Combine(path, $@"vcard{i}.vcf");
            using (StreamWriter sw = File.CreateText(textFileName))
            {
                sw.WriteLine("BEGIN:VCARD");
                sw.WriteLine("VERSION:3.0");
                sw.WriteLine($"UID:urn:uuid:{model[i-1].Id.Value}");
                sw.WriteLine($"FN:{model[i-1].Info.Name} {model[i-1].Info.Surname}");
                sw.WriteLine($"N:{model[i-1].Info.Surname};{model[i-1].Info.Name}");
                sw.WriteLine($"TEL;type=CELL:{model[i-1].Phone}");
                sw.WriteLine($"EMAIL;type=INTERNET;type=WORK;type=pref:{model[i-1].Email}");
                sw.WriteLine($"item1.ADR;type=HOME:;;{model[i-1].Location.Country};{model[i - 1].Location.City}");
                sw.WriteLine($"END:VCARD");
            };
            using (StreamWriter sw = File.CreateText(vcfFileName))
            {
                sw.WriteLine("BEGIN:VCARD");
                sw.WriteLine("VERSION:3.0");
                sw.WriteLine($"UID:urn:uuid:{model[i - 1].Id.Value}");
                sw.WriteLine($"FN:{model[i - 1].Info.Name} {model[i - 1].Info.Surname}");
                sw.WriteLine($"N:{model[i - 1].Info.Surname};{model[i - 1].Info.Name}");
                sw.WriteLine($"TEL;type=CELL:{model[i - 1].Phone}");
                sw.WriteLine($"EMAIL;type=INTERNET;type=WORK;type=pref:{model[i - 1].Email}");
                sw.WriteLine($"item1.ADR;type=HOME:;;{model[i - 1].Location.Country};{model[i - 1].Location.City}");
                sw.WriteLine($"END:VCARD");
            };
            using (StreamReader sr = File.OpenText(textFileName))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
            Console.WriteLine(new System.String('-', 60));
        }
    }
}