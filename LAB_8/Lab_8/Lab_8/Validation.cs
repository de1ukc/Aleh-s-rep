using System;
using System.Linq;
namespace Lab_8
{
    public class Validation
    {
        public static bool Word(string item)
        {
            if (item.All(i => ((i >= 'A' && i <= 'Z') || (i >= 'a' && i <= 'z')))) return false;
            return true;
        }
        
        public static string Number(string item)
        {
            if (item.All(i => i <= '9' && i >= '.' && i != '/')) return item;
            return "0";
        }
    }
}