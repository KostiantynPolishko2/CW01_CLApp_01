using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLApp.Models
{
    public static class Extensions
    {
        public static string? getName(in string name)
        {
            Console.Write($"enter {name}:\t");
            return Console.ReadLine();
        }
    }
}
