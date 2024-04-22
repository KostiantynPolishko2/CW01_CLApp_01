using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLApp.Models
{
    public static class Extensions
    {
        public static string? getName(in string txt)
        {
            Console.Write($"enter {txt}:\t");
            return Console.ReadLine();
        }

        public static void showInColor(in string txt, ConsoleColor color = ConsoleColor.Black)
        {
            Console.BackgroundColor = color;
            Console.WriteLine(txt);
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
