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
          float crystalPrise = 3f;
            int crystalPlayer = 0;
            Console.WriteLine("Сколько золота у тебя есть?");
            float goldPlayer = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Цена одного кристала {crystalPrise}.\nСколько кристалов хочешь приобрести.");

            int countPurchasedCrystals = Convert.ToInt32(Console.ReadLine());

            goldPlayer = goldPlayer - crystalPrise * countPurchasedCrystals;
            crystalPlayer += countPurchasedCrystals;

            Console.WriteLine($"Колличество золота - {goldPlayer}\nколличество кристалов - {crystalPlayer}");
        }
    }
}
