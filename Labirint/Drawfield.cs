using System;
using System.Collections.Generic;
using System.Text;

namespace Labirint
{
   public static class Drawfield
    {
        public static void Draw(Cell[,] field)
        {
            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    Console.SetCursorPosition(j, i);
                    Console.ForegroundColor = field[i, j].Color;
                    Console.Write(field[i, j].ShowChar);
                }
            }
        }
    }
}
