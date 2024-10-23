using System;

namespace Challenge1
{
    internal class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("Digite seu nome");
            var name = Console.ReadLine();

            Console.WriteLine($"Ola, {name}! Seja muito bem-vindo!");
            Console.ReadKey();
        }
    }
}
