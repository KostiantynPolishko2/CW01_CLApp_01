﻿using CLApp.Models;

namespace CLApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start project!");

            Person kopo = new Person(Extensions.getName("First Name"), Extensions.getName("Second Name"));

            Console.WriteLine(kopo);
        }
    }
}