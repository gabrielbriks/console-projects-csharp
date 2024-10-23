using System;
using System.Linq;

namespace Challenge4
{
    internal class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("Digite sua frase:");
            var phrase = Console.ReadLine();

            var arrayOfCharacters = phrase.ToCharArray();

            var totalCharacters = arrayOfCharacters.Count(c => !string.IsNullOrEmpty(c.ToString()));

            Console.WriteLine($"Total de caracteres: {totalCharacters}");
            Console.ReadKey();
        }
    }
}
