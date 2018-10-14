using System;
using System.Linq;

// Реализовать простейшую хэш-функцию. На вход функции подается строка, на выходе сумма кодов символов.

// Александр Коновальцев

namespace Task1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the string, hash of which you are going to get: ");
            var str = Console.ReadLine();
            Console.WriteLine($"Hash of this string is {GetHashOfString(str)}");
        }

        public static int GetHashOfString(string a) 
        {
            return Array.ConvertAll(a.ToCharArray(), c => (int)c).Sum();
        }
    }
}