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
           int playerMoney;
        	int crystalPrise = 3;
          
        	
            Console.WriteLine("Добро пожаловать в мою лавку, путник!");
            Console.WriteLine("Сколько золота ты можешь потратить?");
            playerMoney = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("Значит у тебя есть " + playerMoney + " золотых.");
            int crystalSell = playerMoney / crystalPrise;
            int playerRemains = playerMoney - (crystalSell * crystalPrise);
            
            Console.WriteLine("За это количество монет я могу дать тебе " + crystalSell + " кристалов и у тебя останется еще " + playerRemains + " золотых!");
        }
    }
}
