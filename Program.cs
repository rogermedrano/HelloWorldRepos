using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!  What is your favorite animal?");
            var favAnimal = Console.ReadLine();
            Console.WriteLine("Well, I see " + favAnimal "is your favorite animal.")
        }
    }
}
