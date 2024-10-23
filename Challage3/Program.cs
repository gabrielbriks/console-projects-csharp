using System;

namespace Challenge3
{
    internal class Program
    {
        static void Main (string[] args)
        {
            double firstValue;
            double secondValue;
            double sumValues;
            double subtractingValues;
            double multiplyingValues;
            double dividingValues;
            double averagingValues;

            Console.WriteLine("Defina o primeiro valor");
            firstValue = Double.Parse(Console.ReadLine());

            Console.WriteLine("Defina o segundo valor");
            secondValue = Double.Parse(Console.ReadLine());

            sumValues = firstValue + secondValue;

            subtractingValues = firstValue - secondValue;

            multiplyingValues = firstValue * secondValue;

            dividingValues = secondValue > 0 ? firstValue / secondValue : 0D;

            averagingValues = sumValues / 2;


            Console.WriteLine($"Soma dos valores: {sumValues}");
            Console.WriteLine($"Subtração dos valores: {subtractingValues}");
            Console.WriteLine($"Multiplicação dos valores: {multiplyingValues}");
            Console.WriteLine($"Divisão dos valores: {dividingValues}");
            Console.WriteLine($"Média dos valores: {averagingValues}");

            Console.ReadKey();

        }
    }
}
