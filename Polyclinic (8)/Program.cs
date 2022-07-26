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
            int timeAtTheDoctor = 10;

            Console.Write("Введите количество старушек в старушек в очереди: ");
            int pensionersInLine = int.Parse(Console.ReadLine());
            int waitingTimeInMinutes = (timeAtTheDoctor * pensionersInLine) % 60;
            int waitingTimeInHours = (timeAtTheDoctor * pensionersInLine) / 60;
            if (pensionersInLine < 6)
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
