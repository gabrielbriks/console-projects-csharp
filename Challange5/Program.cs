using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Challenge5
{
    class PlateValidateReturn
    {
        public bool isValid { get; set; }
        public string message { get; set; }
    }

    internal class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("Insira a placa:(Ex: JJJ-8484)");
            string plate = Console.ReadLine().Trim();

            var plateValidate = ValidatePlate(plate);
            if (plateValidate.isValid)
            {
                Console.WriteLine("A Placa está valida!");
            }
            else
            {
                Console.WriteLine(plateValidate.message);
            }

            Console.ReadKey();

        }

        static PlateValidateReturn ValidatePlate (string plate)
        {
            var result = new PlateValidateReturn();
            string patternOnlyLettes = "^[\\p{L}]+$";
            string patternOnlyNumbers = "^[0-9]+$";

            result.isValid = true;

            if (plate.Count() != 8)
            {
                result.message = "ERRO: A placa deve ter 7 caracteres alfanuméricos";
                result.isValid = false;

            }

            var firstChars = plate.Split('-')[0].Trim();

            if (firstChars.Count() != 3)
            {
                result.message = "ERRO: A placa deve iniciar com 3 caracteres";
                result.isValid = false;

            }

            var firstCharsIsValid = Regex.IsMatch(firstChars, patternOnlyLettes);

            if (!firstCharsIsValid)
            {
                result.message = "ERRO: A placa deve iniciar com 3 letras";
                result.isValid = false;

            }

            var lastChars = plate.Split('-')[1].Trim();

            if (lastChars.Count() != 4)
            {
                result.message = "ERRO: A placa deve terminar com 4 números";
                result.isValid = false;

            }

            var lastCharsIsValid = Regex.IsMatch(lastChars, patternOnlyNumbers);

            if (!lastCharsIsValid)
            {
                result.message = "ERRO: A placa deve conter 4 números após o traço(-) ";
                result.isValid = false;

            }

            return result;
        }


    }
}


