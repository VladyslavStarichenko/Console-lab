using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Labirint
{
   public static class Menu
    {
        public static void Menu_(params int[] arr)
        {
            ConsoleKeyInfo key;
            Console.CursorVisible = false;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(40, 10);
            Console.WriteLine("Enter 1 to start the game!");
            Console.WriteLine();
            key = Console.ReadKey(true);
            if(key.Key == ConsoleKey.D1)
            {
                


                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.Clear();
                Console.SetCursorPosition(55, 10);
                Console.WriteLine("Level  1");
                Thread.Sleep(1500);

                
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.Clear();
                Cell[,] cells = Level.FirstLevel();
                Drawfield.Draw(cells);
                Logic.Gameplay(cells);

                
            }



        }

    }
}
