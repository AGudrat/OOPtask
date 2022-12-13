using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTask.Reflection
{
    public static class MailOperation
    {
        public static string CharacterRegulatory(string param)
           => param.Replace("\"", "")
                      .Replace("!", "")
                      .Replace("@", "")
                      .Replace("#", "")
                      .Replace("$", "")
                      .Replace("%", "")
                      .Replace("^", "")
                      .Replace("&", "")
                      .Replace("^", "")
                      .Replace("*", "")
                      .Replace("(", "")
                      .Replace(")", "")
                      .Replace("_", "")
                      .Replace("-", "")
                      .Replace("+", "")
                      .Replace("=", "")
                      .Replace("№", "")
                      .Replace(";", "")
                      .Replace("?", "")
                      .Replace(":", "")
                      .Replace(";", "")
                      .Replace("'", "")
                      .Replace("[", "")
                      .Replace("]", "")
                      .Replace("{", "")
                      .Replace("}", "")
                      .Replace("<", "")
                      .Replace(">", "")
                      .Replace("/", "")
                      .Replace(",", "")
                      .Replace("~", "")
                      .Replace("`", "")
                      .Replace(".", "")
                      .Replace("ß", "")
                      .Replace("â", "a")
                      .Replace("î", "i")
                      .Replace("€", "")
                      .Replace("|", "")
                      .Replace("ö", "o")
                      .Replace("Ö", "o")
                      .Replace("ğ", "g")
                      .Replace("Ğ", "g")
                      .Replace("ə", "e")
                      .Replace("Ə", "e")
                      .Replace("ş", "s")
                      .Replace("Ş", "s")
                      .Replace("ç", "c")
                      .Replace("Ç", "c")
                      .Replace("ı", "i")
                      .Replace("I", "i")
                      .Replace("ü", "u")
                      .Replace("Ü", "u")
                      .Replace("æ", "");
    }
}
