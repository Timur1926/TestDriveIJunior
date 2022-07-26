using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        double crystalСost = 1.25; 

        Console.Write("\nТы проверяешь, свои карманы и находишь ... золота.\nВведите желаемо количество золота: ");
        double playerGold = double.Parse(Console.ReadLine());
        Console.Write($"\nТы проверяешь, свои карманы и находишь {playerGold} золота.\n" +
            $"Имея такое количество золота, ты решаешь зайти в магазин драгоценностей для покупики кристаллов." +
            $"\nКристаллы нынче стоят по {crystalСost}, ты решаешь купить ... кристалов." +
            $"\nВведите желаемо количество кристаллов: ");
        int playerCrystals = int.Parse(Console.ReadLine());
        playerGold = playerGold - (crystalСost * playerCrystals);

        Console.WriteLine($"По итогу у игрока осталось {playerGold} золота и он приобрел {playerCrystals} кристаллов");
        Console.ReadLine();
    }
}
