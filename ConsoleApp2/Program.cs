using System;

namespace Challage2
{
    internal class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("Digite seu nome");
            var name = Console.ReadLine();

            Console.WriteLine("Digite seu sobrenome");
            var lastName = Console.ReadLine();


            Console.WriteLine($"Ola, {name} {lastName}! Seja muito bem-vindo!");
            Console.ReadKey();
        }
    }
}
