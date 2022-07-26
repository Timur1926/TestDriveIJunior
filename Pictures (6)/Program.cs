using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pictures__6_
{
    class Program
    {
        static void Main(string[] args)
        {
            int picturesInAlbum = 52;
            int picturesInARow = 3;

            int fullRowOfPicture = picturesInAlbum / picturesInARow;
            int picturesBeyondMeasure = picturesInAlbum % picturesInARow;

            Console.WriteLine($"Рядовы полностью занятых картинками: {fullRowOfPicture};");
            Console.WriteLine($"Количество изображений в последнем ряду: {picturesBeyondMeasure}.");
            Console.ReadLine();
        }
    }
}
