using System;


class Program
{
    static void Main(string[] args)
    {
        string playerName = "Kovtunenko";
        string playerSurname = "Alex";

        (playerName, playerSurname) = (playerSurname, playerName);

        //Console.WriteLine(playerName);
        //Console.WriteLine(playerSurname);
        //Console.ReadLine();
    }
}
