using CLApp.Models;

namespace CLApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start project!");

            Person kopo = new Person("Kostiantyn", "Polishko");

            Console.WriteLine(kopo);
        }
    }
}