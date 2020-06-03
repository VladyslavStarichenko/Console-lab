using System;
using System.Collections.Generic;
using System.Text;

namespace Labirint
{
   public static class Level
    {
        public static Cell[,] FirstLevel()
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Cell[,] field = new Cell[20, 20];
            for(int i = 0; i < 20; i++)
            {
                field[0,i] =  new Cell(ShowChar.WALL, CellType.Wall, ConsoleColor.Black);
                field[i, 0] = new Cell(ShowChar.WALL, CellType.Wall, ConsoleColor.Black);
                field[19, i] = new Cell(ShowChar.WALL, CellType.Wall, ConsoleColor.Black);
                field[i, 19] = new Cell(ShowChar.WALL, CellType.Wall, ConsoleColor.Black);
            }
            field[1, 1] = new Cell(ShowChar.HERO, CellType.Player, ConsoleColor.DarkGreen);
            for(int i = 0; i < 18; i++)
            {
                field[2, i] = new Cell(ShowChar.WALL, CellType.Wall, ConsoleColor.Black);
            }
            field[2, 18] = new Cell(ShowChar.DOOR, CellType.Door, ConsoleColor.DarkCyan);
            field[2, 9] = new Cell(ShowChar.EMPTY, CellType.Empty, ConsoleColor.DarkCyan);
            field[1, 4] = new Cell(ShowChar.KEY, CellType.Key, ConsoleColor.DarkRed);
            field[1, 11] = new Cell(ShowChar.COIN, CellType.Coin, ConsoleColor.Yellow);
            field[1, 4] = new Cell(ShowChar.COIN, CellType.Coin, ConsoleColor.Yellow);
           
            field[1, 17] = new Cell(ShowChar.COIN, CellType.Coin, ConsoleColor.Yellow);
            field[7, 2] = new Cell(ShowChar.COIN, CellType.Coin, ConsoleColor.Yellow);
            field[10, 13] = new Cell(ShowChar.COIN, CellType.Coin, ConsoleColor.Yellow);
            field[8, 18] = new Cell(ShowChar.COIN, CellType.Coin, ConsoleColor.Yellow);
            field[19, 18] = new Cell(ShowChar.FINISH, CellType.Finish, ConsoleColor.Red);
            field[4, 10] = new Cell(ShowChar.WALL, CellType.Wall, ConsoleColor.Black);
            field[5, 5] = new Cell(ShowChar.WALL, CellType.Wall, ConsoleColor.Black);
            field[5, 4] = new Cell(ShowChar.COIN, CellType.Coin, ConsoleColor.Yellow);
            field[5, 3] = new Cell(ShowChar.WALL, CellType.Wall, ConsoleColor.Black);
            field[18, 10] = new Cell(ShowChar.WALL, CellType.Wall, ConsoleColor.Black);
            field[18, 14] = new Cell(ShowChar.WALL, CellType.Wall, ConsoleColor.Black);
            field[18, 17] = new Cell(ShowChar.WALL, CellType.Wall, ConsoleColor.Black);
            field[6, 15] = new Cell(ShowChar.WALL, CellType.Wall, ConsoleColor.Black);
            field[6, 16] = new Cell(ShowChar.WALL, CellType.Wall, ConsoleColor.Black);
            field[18, 8] = new Cell(ShowChar.WALL, CellType.Wall, ConsoleColor.Black);
            field[6, 7] = new Cell(ShowChar.KEY, CellType.Key, ConsoleColor.DarkCyan);
            field[15, 7] = new Cell(ShowChar.COIN, CellType.Coin, ConsoleColor.Yellow);
            field[10, 4] = new Cell(ShowChar.COIN, CellType.Coin, ConsoleColor.Yellow);
            field[3, 4] = new Cell(ShowChar.COIN, CellType.Coin, ConsoleColor.Yellow);
            field[18, 3] = new Cell(ShowChar.COIN, CellType.Coin, ConsoleColor.Yellow);
            field[18, 12] = new Cell(ShowChar.COIN, CellType.Coin, ConsoleColor.Yellow);
            

            for (int i = 1; i < 20; i++)
            {
                if(i == 8 || i == 10)
                {
                    field[3, i] = new Cell(ShowChar.WALL, CellType.Wall, ConsoleColor.Black);
                    
                }
                

            }
            for (int i = 5; i < 9; i++)
            {
                field[5, i] = new Cell(ShowChar.WALL, CellType.Wall, ConsoleColor.Black);
            }
            for (int i = 2; i < 5; i++)
            {
                field[4, i] = new Cell(ShowChar.WALL, CellType.Wall, ConsoleColor.Black);
            }
            for (int i = 12; i < 19; i++)
            {
                field[4, i] = new Cell(ShowChar.WALL, CellType.Wall, ConsoleColor.Black);
            }
            for (int i = 5; i < 18; i++)
            {
                field[i, 10] = new Cell(ShowChar.WALL, CellType.Wall, ConsoleColor.Black);
                field[i, 12] = new Cell(ShowChar.WALL, CellType.Wall, ConsoleColor.Black);
            }
            
            for (int i = 6; i < 18; i++)
            {
                field[i, 14] = new Cell(ShowChar.WALL, CellType.Wall, ConsoleColor.Black);
                field[i, 17] = new Cell(ShowChar.WALL, CellType.Wall, ConsoleColor.Black);
            }
            for (int i = 5; i < 18; i++)
            {
                field[i, 2] = new Cell(ShowChar.WALL, CellType.Wall, ConsoleColor.Black);
                field[i, 5] = new Cell(ShowChar.WALL, CellType.Wall, ConsoleColor.Black);
                field[i, 8] = new Cell(ShowChar.WALL, CellType.Wall, ConsoleColor.Black);
            }
                return field;
        }

    }
}
