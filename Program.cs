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
            Console.WriteLine("Сколько человек в очереди перед Вами?");
            int numberPeople = Convert.ToInt32(Console.ReadLine());
            int timeClient = 10;
            int totalTime = numberPeople * timeClient;
            int minutesInOneHour = 60;
            int timeInHours = totalTime / minutesInOneHour;
            int timeInMinutes = totalTime % minutesInOneHour;

            if (totalTime >= minutesInOneHour)
            {
                Console.WriteLine("Вам предстоит простоять в очереди " + timeInHours + " часов и " + timeInMinutes + " минут.");
            }
            else
            {
                Console.WriteLine("Вам предстоит простоять в очереди " + totalTime + " минут.");
            }
        }
    }
}
