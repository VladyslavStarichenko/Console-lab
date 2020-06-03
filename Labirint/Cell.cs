using System;
using System.Collections.Generic;
using System.Text;

namespace Labirint
{
   public struct Cell
    {
        public char ShowChar { get; set; }
        public CellType Type { get; set; }
        public ConsoleColor Color { get; set; }
        public Cell(char schar, CellType type, ConsoleColor color)
        {
            ShowChar = schar;
            Type = type;
            Color = color;
        }

    }
}
