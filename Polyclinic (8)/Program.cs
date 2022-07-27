using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polyclinic__8_
{
    class Program
    {
        static void Main(string[] args)
        {
            int timeAtDoctor = 10;
            int minutesInHour = 60;
            Console.Write("Введите количество старушек в старушек в очереди: ");
            int pensionersInLine = int.Parse(Console.ReadLine());
            int waitingTimeInMinutes = (timeAtDoctor * pensionersInLine) % minutesInHour;
            int waitingTimeInHours = (timeAtDoctor * pensionersInLine) / minutesInHour;

            if (waitingTimeInHours == 1)
            {
                Console.WriteLine($"Осталось ждать {waitingTimeInHours} час и {waitingTimeInMinutes} минут.");
            }
            else
            {
                Console.WriteLine($"Осталось ждать {waitingTimeInHours} часов и {waitingTimeInMinutes} минут.");
            }

            Console.ReadLine();

        }
    }
}
