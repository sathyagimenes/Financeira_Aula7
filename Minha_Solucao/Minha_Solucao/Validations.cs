using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Minha_Solucao
{
    public class Validations
    {
        public static decimal ValidateValue(string answer)
        {
            decimal answerInDecimal;
            while (!decimal.TryParse(answer, out answerInDecimal))
            {
                Console.WriteLine("Resposta inválida. Escreva um número");
                answer = Console.ReadLine();
            }
            return answerInDecimal;
        }
        public static int ValidateInt(string answer)
        {
            int answerInInt;
            while (!int.TryParse(answer, out answerInInt))
            {
                Console.WriteLine("Resposta inválida. Escreva um número");
                answer = Console.ReadLine();
            }
            return answerInInt;
        }
        public static DateTime ValidateBirthDay(string answer)
        {
            DateTime answerInDate;
            while (!DateTime.TryParse(answer, out answerInDate) || answerInDate > DateTime.Now)
            {
                Console.WriteLine("Resposta inválida. Escreva uma data válida (dd/mm/yyyy) e anterior à data de hoje");
                answer = Console.ReadLine();
            }
            return answerInDate;
        }

        public static double ValidateCpf(string answer)
        {
            var pattern = @"([0-9]{3}[0-9]{3}[0-9]{3}[0-9]{2})";
            Regex regex = new Regex(pattern);
            while (!regex.Match(answer).Success)
            {
                Console.WriteLine("Resposta inválida. Digite um CPF válido (somente numeros)");
                answer = Console.ReadLine();
            }
            return double.Parse(answer);
        }

        public static double ValidateCnpj(string answer)
        {
            var pattern = @"([0-9]{2}[0-9]{3}[0-9]{3}[0-9]{4}[0-9]{2})";
            Regex regex = new Regex(pattern);
            while (!regex.Match(answer).Success)
            {
                Console.WriteLine("Resposta inválida. Digite um CNPJ válido (somente numeros)");
                answer = Console.ReadLine();
            }
            return double.Parse(answer);
        }
    }
}