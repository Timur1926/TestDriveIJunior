using System;


class Program
{
    static void Main(string[] args)
    {
        string playerName = "Kovtunenko";
        string playerSurname = "Alex";

        Console.WriteLine($"Имя до перестановки {playerName}");
        Console.WriteLine($"Фамилия до перестановки {playerSurname}");

        (playerName, playerSurname) = (playerSurname, playerName);

        Console.WriteLine($"\nИмя после перестановки {playerName}");
        Console.WriteLine($"Фамилия после перестановки {playerSurname}");
        Console.ReadLine();
    }
}
