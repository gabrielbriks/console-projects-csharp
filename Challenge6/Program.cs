using System;

namespace Challenge6
{
    internal class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("Informe o tipo do retorno da data");
            Console.WriteLine("1) Formato completo (dia da semana, dia do mês, mês, ano, hora, minutos, segundos).\n" +
                "2) Apenas a data no formato \"01/03/2024\"." +
                "3) Apenas a hora no formato de 24 horas.\n" +
                "4) A data com o mês por extenso.\n");

            var dateType = Console.ReadLine();

            var now = DateTime.Now;

            switch (dateType)
            {
                case "1":
                    string formatoCompleto = now.ToString("dddd, dd MMMM yyyy HH:mm:ss");
                    Console.WriteLine($"Formato completo: {formatoCompleto}");
                    break;
                case "2":
                    string dataFormatada = now.ToString("dd/MM/yyyy");
                    Console.WriteLine($"Formato completo: {dataFormatada}");
                    break;
                case "3":
                    string horaFormatada = now.ToString("HH:mm:ss");
                    Console.WriteLine($"Formato completo: {horaFormatada}");
                    break;
                case "4":
                    string mesPorExtenso = now.ToString("dd 'de' MMMM 'de' yyyy");
                    Console.WriteLine($"Formato completo: {mesPorExtenso}");
                    break;
                default:
                    break;
            }



            Console.ReadKey();
        }
    }
}
