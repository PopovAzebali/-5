using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Попов";
            string lastName = "Алексей";
            string reserve;

            Console.WriteLine("До исправления");
            Console.WriteLine("Имя : " + firstName);
            Console.WriteLine("Фамилия : " + lastName);
            reserve = firstName;
            firstName = lastName;
            lastName = reserve;
            Console.WriteLine("После исправления");
            Console.WriteLine("Имя : " + firstName);
            Console.WriteLine("Фамилия : " + lastName);
        }
    }
}
