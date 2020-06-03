using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Labirint
{
    public static class Logic
    {
        public static void Gameplay(Cell[,] field)
        {
            int Gold_gain = 11;
            int x = 1;
            int y = 1;
            bool isDoorOPen = false;
            bool fin = false;
            ConsoleKeyInfo key;

            Console.CursorVisible = false;
            do
            {
                key = Console.ReadKey(true);
                int prevx = x;
                int prevy = y;
                if (x >= 1 && x <= field.GetLength(1) - 2 && y >= 1 && y <= field.GetLength(0) - 2)
                {

                    Console.SetCursorPosition(x, y);
                    Console.ForegroundColor = field[prevy, prevx].Color;
                    if (field[prevy, prevx].ShowChar != ShowChar.HERO &&
                        field[prevy, prevx].ShowChar != ShowChar.KEY &&
                        field[prevy, prevx].ShowChar != ShowChar.COIN &&
                        field[prevy, prevx].ShowChar != ShowChar.DOOR)
                    {
                        Console.Write(field[prevy, prevx].ShowChar);
                    }
                    else
                    {
                        field[prevy, prevx] = new Cell(ShowChar.EMPTY, CellType.Empty, ConsoleColor.White);
                        Console.Write(field[prevy, prevx].ShowChar);
                    }
                }
               
                switch (key.Key)
                {
                    case ConsoleKey.DownArrow:
                        y++;
                        break;
                    case ConsoleKey.UpArrow:
                        y--;
                        break;
                    case ConsoleKey.LeftArrow:
                        x--;
                        break;
                    case ConsoleKey.RightArrow:
                        x++;
                        break;
                    case ConsoleKey.D1:
                        Menu.Menu_();
                        break;

                }
                if(field[y, x].Type == CellType.Coin)
                {
                    Gold_gain--;
                }
                //стали на ключ или нет
                if (field[y, x].Type == CellType.Key )
                {
                    isDoorOPen = true;
                }
                if (field[y, x].Type == CellType.Finish && Gold_gain == 0)
                {
                    fin = true;                }
                    if (x >= 1 && x <= field.GetLength(1) - 2 && y >= 1 && y <= field.GetLength(0) - 2 &&
                    field[y, x].Type != CellType.Wall && field[y, x].Type != CellType.Door)//проверка что мы не на двери
                {
                    Console.SetCursorPosition(x, y);
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(ShowChar.HERO);

                    if (field[y, x].Type == CellType.Empty)
                        field[y, x] = new Cell(ShowChar.HERO, CellType.Player, ConsoleColor.Black);
                }
                //если мы на двери
                else if(field[y, x].Type == CellType.Door)
                {
                    //если собрали ключ
                    if (isDoorOPen)
                    {
                        Console.SetCursorPosition(x, y);
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write(ShowChar.HERO);
                    }
                    //если не собрали ключ игрок отображается там же
                    else
                    {
                        Console.SetCursorPosition(prevx, prevy);
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write(ShowChar.HERO);
                        x = prevx;
                        y = prevy;
                    }

                }
                else if (fin)
                {
                    Console.Clear();
                    Console.SetCursorPosition(45, 10);
                    Console.WriteLine("Congratilations, you won!");
                    Console.SetCursorPosition(45, 12);
                    Console.WriteLine("Press 1 to return to the menu");
                }
                    
                




                else
                {
                    Console.SetCursorPosition(prevx, prevy);
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(ShowChar.HERO);
                    x = prevx;
                    y = prevy;
                }
                
            } while (key.Key != ConsoleKey.Escape);
        }
    }
}
