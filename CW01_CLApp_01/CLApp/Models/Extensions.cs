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
        public static string? getName(in string txt="text")
        {
            Console.Write($"enter {txt}:\t");
            return Console.ReadLine();
        }

        public static void showInColor(string txt, ConsoleColor color = ConsoleColor.Black)
        {
            Console.BackgroundColor = color;
            Console.WriteLine(txt != String.Empty? txt : "Text empty!!!");
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
