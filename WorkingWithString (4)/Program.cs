using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Привет!\nКак тебя зовут?");
        string playerName = Console.ReadLine();
        Console.WriteLine($"Так {playerName}, чем занимаешься?");
        string playerAction = Console.ReadLine();
        Console.WriteLine("Прикольно, кстати мне оч нужно узнать, кто твоя любимая девочка из DDLC?");
        string playerFavoriteGirl = Console.ReadLine().ToLower();

        if (playerFavoriteGirl == "моника")
        {
            Console.WriteLine("Одобряю :)");
        }
        else if (playerFavoriteGirl == "юри" || playerFavoriteGirl == "сайори" || playerFavoriteGirl == "нацуки")
        {
            Console.WriteLine("Пон...");
        }
        else 
        {
            Console.WriteLine("Такого персонажа нет, ну и ладно.");
            playerFavoriteGirl = "та которой нет :(";
        }

        Console.WriteLine($"Так если подводить итоги ты {playerName}, занимаешься этим \"{playerAction}\" и твоя любимая девочка из DDLC - это {playerFavoriteGirl}.");
        Console.ReadLine();
    }
}
