using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WowBased.Entities
{
    internal class Painting
    {
        public void PaintRed()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
        }

        public void PaintGreen()
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }

        public void RemovePaint()
        {
            Console.ResetColor();
        }
    }
}
